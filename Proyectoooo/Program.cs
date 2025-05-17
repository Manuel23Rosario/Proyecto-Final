namespace Proyectoooo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Creamos el formulario de login
            using (FormLogin login = new FormLogin())
            {
                // Mostramos el formulario de login como diálogo
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Si el login fue exitoso, abrimos el formulario principal
                    Application.Run(new FormClientes());
                }
            }
        }
    }
}
