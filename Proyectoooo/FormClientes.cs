using CapaNegocio;
using CapaPresentacion;
using System.Runtime.InteropServices;

namespace Proyectoooo
{
    public partial class FormClientes : Form
    {
        // Importar funciones de Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes de mensaje
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            var clienteNegocio = new ClienteNegocio();
            dvg_Usuarios.DataSource = clienteNegocio.ObtenerClientes();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var clienteNegocio = new ClienteNegocio();

            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                MessageBox.Show("Por favor, ingrese un ID válido antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool eliminado = clienteNegocio.EliminarCliente(txt_Id.Text);

            if (eliminado)
            {
                MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dvg_Usuarios.DataSource = clienteNegocio.ObtenerClientes(); // Refrescar DataGridView
            }
            else
            {
                MessageBox.Show(clienteNegocio.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Id.Text = "";
            txt_Nombre.Text = "";
            txt_Correo.Text = "";
            txt_Telefono.Text = "";
            cmb_Estado.Text = "";
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            var clienteNegocio = new ClienteNegocio();
            if (clienteNegocio.EditarCliente(txt_Id.Text, txt_Nombre.Text, txt_Correo.Text, txt_Telefono.Text, cmb_Estado.Text))
            {
                MessageBox.Show("Registro Modificado");
                dvg_Usuarios.DataSource = clienteNegocio.ObtenerClientes();
            }
            else
            {
                MessageBox.Show(clienteNegocio.MensajeError);
            }

        }

        private void btn_VerFactura_Click(object sender, EventArgs e)
        {
            Form formu = new FormFacturas();
            formu.Show();
        }

        private void dvg_Usuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvg_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para evitar errores con el encabezado
            {
                DataGridViewRow fila = dvg_Usuarios.Rows[e.RowIndex];

                txt_Id.Text = fila.Cells[0].Value?.ToString();
                txt_Nombre.Text = fila.Cells[1].Value?.ToString();
                txt_Correo.Text = fila.Cells[2].Value?.ToString();
                txt_Telefono.Text = fila.Cells[3].Value?.ToString();
                cmb_Estado.Text = fila.Cells[4].Value?.ToString();
            }

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            var clienteNegocio = new ClienteNegocio();
            if (clienteNegocio.AgregarCliente(txt_Nombre.Text, txt_Correo.Text, txt_Telefono.Text, cmb_Estado.Text))
            {
                MessageBox.Show("Cliente agregado correctamente");
                dvg_Usuarios.DataSource = clienteNegocio.ObtenerClientes();
            }
            else
            {
                MessageBox.Show(clienteNegocio.MensajeError);
            }
        }
    }
}