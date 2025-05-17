using System.Data;
using CapaNegocio;
using System.Runtime.InteropServices;

namespace CapaPresentacion
{
    public partial class FormFacturas : Form
    {
        private List<CheckBox> checkBoxes;
        private FacturaNegocio facturaNegocio = new FacturaNegocio();
        private Dictionary<string, decimal> productos;

        // Importar funciones de Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes de mensaje
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormFacturas()
        {
            InitializeComponent();
            productos = new Dictionary<string, decimal>
            {
                {"Smart TV", 15000m},
                {"Proyector", 8000m},
                {"Smartwatch", 6500m},
                {"Cámara", 5300m},
                {"Auriculares", 2500m}
            };

            checkBoxes = new List<CheckBox>(); // Inicializamos la lista vacía
        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {
            dvg_Facturas.DataSource = facturaNegocio.ObtenerFacturas();
            cmb_Clientes.DataSource = facturaNegocio.ObtenerClientes();
            cmb_Clientes.DisplayMember = "Nombre";
            cmb_Clientes.ValueMember = "Id";

            // Verifica que los CheckBox existen en el formulario antes de agregarlos
            checkBoxes = new List<CheckBox>
            {
                cbx_SmartTV, cbx_Proyector, cbx_Smartwatch, cbx_Cámara,
                cbx_Auriculares
            };

            // Evitar que `checkBoxes` sea null
            if (checkBoxes.Count == 0)
            {
                MessageBox.Show("Error: No se han encontrado CheckBoxes en el formulario.");
                return;
            }

            foreach (var check in checkBoxes)
            {
                check.CheckedChanged += CalcularTotal;
            }

            cmb_Clientes.SelectedIndexChanged += cmb_Clientes_SelectedIndexChanged;
        }

        private void CalcularTotal(object sender, EventArgs e)
        {
            if (productos == null || productos.Count == 0)
            {
                MessageBox.Show("Error: La lista de productos no ha sido inicializada.");
                return;
            }

            decimal subTotal = checkBoxes.Where(c => c.Checked && !string.IsNullOrEmpty(c.Text))
                                         .Sum(c =>
                                         {
                                             string productoNombre = c.Text.Split('$')[0].Trim();
                                             return productos.TryGetValue(productoNombre, out decimal precio) ? precio : 0;
                                         });

            decimal impuesto = subTotal * 0.18m;
            decimal totalCalculado = subTotal + impuesto;

            txt_SubTotal.Text = $"RD{subTotal:C}";
            txt_Impuestos.Text = $"RD{impuesto:C}";
            txt_Total.Text = $"RD{totalCalculado:C}";
        }

        private void btn_GuardarFactura_Click(object sender, EventArgs e)
        {
            if (facturaNegocio.GuardarFactura(txt_Id.Text, txt_Fecha.Text, txt_Estado.Text, productos))
            {
                MessageBox.Show("Factura guardada correctamente.");
                dvg_Facturas.DataSource = facturaNegocio.ObtenerFacturas();
            }
            else
            {
                MessageBox.Show(facturaNegocio.MensajeError);
            }
        }

        private void cmb_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Clientes.SelectedItem != null)
            {
                CapaEntidad.Cliente clienteSeleccionado = (CapaEntidad.Cliente)cmb_Clientes.SelectedItem;
                txt_Id.Text = clienteSeleccionado.Id.ToString();
            }

        }

        private void btn_AreaReportes_Click(object sender, EventArgs e)
        {
            Form formulario = new FormReportes();
            formulario.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void lbl_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}