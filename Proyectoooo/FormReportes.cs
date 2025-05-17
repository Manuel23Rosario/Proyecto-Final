using CapaNegocio;
using CapaEntidad;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ClosedXML.Excel;
using CapaDatos;
using System.Runtime.InteropServices;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaPresentacion
{
    public partial class FormReportes : Form
    {
        private FacturaDatos facturaDatos = new FacturaDatos();

        // Importar funciones de Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes de mensaje
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormReportes()
        {
            InitializeComponent();
        }

        /*private void FormReportes_Load(object sender, EventArgs e)
        {
            
        }*/

        private void btn_DescargarPdf_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt_Id.Text, out int idFactura))
            {
                MessageBox.Show("El ID de la factura no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Factura factura = facturaDatos.ObtenerFacturaPorId(idFactura);

            if (factura == null)
            {
                MessageBox.Show("No se encontraron datos para esta factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Imprimir los datos para verificar que la factura fue obtenida
            MessageBox.Show($"Factura encontrada:\nCliente: {factura.NombreCliente}\nFecha: {factura.Fecha}\nTotal: RD${factura.Total:N2}");

            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Archivos PDF (*.pdf)|*.pdf", FileName = "Factura.pdf" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        iTextSharp.text.Document doc = new iTextSharp.text.Document();
                        PdfWriter.GetInstance(doc, stream);
                        doc.Open();

                        doc.Add(new Paragraph("FACTURA"));
                        doc.Add(new Paragraph($"Cliente: {factura.NombreCliente}"));
                        doc.Add(new Paragraph($"Fecha: {factura.Fecha}"));
                        doc.Add(new Paragraph($"Descripción: {factura.Descripcion}"));
                        doc.Add(new Paragraph($"SubTotal: RD${factura.SubTotal:N2}"));
                        doc.Add(new Paragraph($"Total: RD${factura.Total:N2}"));

                        doc.Close();
                    }

                    if (File.Exists(sfd.FileName))
                    {
                        MessageBox.Show($"Factura PDF generada correctamente en: {sfd.FileName}");
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al crear el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btn_DescargarExcel_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txt_Id.Text, out int idFactura))
            {
                Factura factura = facturaDatos.ObtenerFacturaPorId(idFactura);
                if (factura != null)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Archivos Excel (*.xlsx)|*.xlsx", FileName = "Factura.xlsx" })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            var workbook = new XLWorkbook();
                            var worksheet = workbook.Worksheets.Add("Factura");

                            worksheet.Cell("A1").Value = "FACTURA";
                            worksheet.Cell("A2").Value = "Cliente:";
                            worksheet.Cell("B2").Value = factura.IdCliente;

                            worksheet.Cell("A3").Value = "Fecha:";
                            worksheet.Cell("B3").Value = factura.Fecha.ToString();

                            worksheet.Cell("A4").Value = "Descripción:";
                            worksheet.Cell("B4").Value = factura.Descripcion;

                            worksheet.Cell("A5").Value = "SubTotal:";
                            worksheet.Cell("B5").Value = $"RD${factura.SubTotal:N2}";

                            worksheet.Cell("A6").Value = "Total:";
                            worksheet.Cell("B6").Value = $"RD${factura.Total:N2}";

                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show($"Factura Excel generada correctamente en: {sfd.FileName}");
                        }
                    }
                }
            }

        }

        private void lbl_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void dvg_DetalleFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dvg_DetalleFactura.Rows[e.RowIndex];

                txt_Id.Text = fila.Cells["IdFactura"].Value?.ToString();
            }
        }

        private void FormReportes_Load_1(object sender, EventArgs e)
        {
            dvg_DetalleFactura.DataSource = facturaDatos.ObtenerDetallesFactura();
            dtp_Desde.Value = dtp_Desde.MinDate;
            dtp_Hasta.Value = dtp_Hasta.MaxDate;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            string consulta = "SELECT * FROM Facturas WHERE 1=1"; // Base de consulta

            if (dtp_Desde.Value.Date != dtp_Desde.MinDate) // Solo si se usa "Desde"
            {
                consulta += " AND Fecha >= @FechaDesde";
            }

            if (dtp_Hasta.Value.Date != dtp_Hasta.MinDate) // Solo si se usa "Hasta"
            {
                consulta += " AND Fecha <= @FechaHasta";
            }

            using (SqlConnection conexion = new SqlConnection("server=LAPTOP-NANT6IM3;database=ClientesyFacturas; integrated security=true;  TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                {
                    if (dtp_Desde.Value.Date != dtp_Desde.MinDate)
                        cmd.Parameters.AddWithValue("@FechaDesde", dtp_Desde.Value.Date);

                    if (dtp_Hasta.Value.Date != dtp_Hasta.MinDate)
                        cmd.Parameters.AddWithValue("@FechaHasta", dtp_Hasta.Value.Date);

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dvg_DetalleFactura.DataSource = dt; // Mostrar resultados en el DataGridView
                }
            }
        }
    }
}
