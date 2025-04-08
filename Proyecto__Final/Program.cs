using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto__Final
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                FormLogin loginForm = new FormLogin();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new FormClientes()); // este es el formulario principal
                }
        }
    }

}
