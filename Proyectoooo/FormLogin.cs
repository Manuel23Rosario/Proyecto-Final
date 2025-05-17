using CapaNegocio;
using System.Runtime.InteropServices;

namespace Proyectoooo
{
    public partial class FormLogin : Form
    {
        // Importar funciones de Windows
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        // Constantes de mensaje
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void lbl_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ingresar_Click_1(object sender, EventArgs e)
        {
            var loginNegocio = new LoginNegocio();
            if (loginNegocio.ValidarUsuario(txt_Usuario.Text, txt_Contraseña.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(loginNegocio.MensajeError);
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}