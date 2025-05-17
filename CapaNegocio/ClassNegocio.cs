using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    //FormLogin
    public class LoginNegocio
    {
        private readonly string Usuario = "UsuarioMR";
        private readonly string Contraseña = "12345$";
        public string MensajeError { get; private set; }

        public bool ValidarUsuario(string usuario, string contraseña)
        {
            if (usuario == Usuario && contraseña == Contraseña)
            {
                return true;
            }
            else if (usuario == Usuario && contraseña != Contraseña)
            {
                MensajeError = "Contraseña Incorrecta.";
            }
            else
                MensajeError = "Usuario Incorrecto.";
                return false;
        }
    }
    //--------------------------------------------------------

    //FormClientes
        public class ClienteNegocio
        {

        private ClienteDatos clienteDatos = new ClienteDatos();
            public string MensajeError { get; private set; }

            public DataTable ObtenerClientes()
            {
                return clienteDatos.ConsultarClientes();
            }

            public bool AgregarCliente(string nombre, string correo, string telefono, string estado)
            {
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) ||
                    string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(estado))
                {
                    MensajeError = "Todos los campos son obligatorios.";
                    return false;
                }
                return clienteDatos.InsertarCliente(nombre, correo, telefono, estado);
            }

        public bool EliminarCliente(string idTexto)
        {
            if (!int.TryParse(idTexto, out int idCliente))
            {
                MensajeError = "El ID del cliente no es válido.";
                return false;
            }

            bool eliminado = clienteDatos.EliminarCliente(idCliente);

            if (!eliminado)
            {
                MensajeError = "No se encontró un cliente con ese ID o hubo un error al eliminar.";
            }

            return eliminado;
        }


        public bool EditarCliente(string id, string nombre, string correo, string telefono, string estado)
            {
                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(correo) ||
                    string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(estado))
                {
                    MensajeError = "Todos los campos son obligatorios.";
                    return false;
                }
                return clienteDatos.EditarCliente(id, nombre, correo, telefono, estado);
            }
    }
    //----------------------------------------------------------------
    //FormFacturas
    public class FacturaNegocio
    {
            private FacturaDatos facturaDatos = new FacturaDatos();
            public string MensajeError { get; private set; }

            public DataTable ObtenerFacturas()
            {
                return facturaDatos.ConsultarFacturas();
            }

            public List<CapaEntidad.Cliente> ObtenerClientes()
            {
                return facturaDatos.ConsultarClientes();
            }

        public bool GuardarFactura(string idCliente, string fecha, string estado, Dictionary<string, decimal> productos)
            {
                if (!int.TryParse(idCliente, out int id) || !DateTime.TryParse(fecha, out DateTime fechaParsed))
                {
                    MensajeError = "ID de cliente o fecha no válidos.";
                    return false;
                }

            decimal subTotal = productos.Sum(p => p.Value);
            decimal totalCalculado = subTotal * 1.18m;

                return facturaDatos.InsertarFactura(id, fechaParsed, totalCalculado, estado, productos);
            }
    }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public override string ToString() => Nombre;
        }
    //---------------------------------------------------------
    //FormReportes
        public class FacturaReporte
        {
           private FacturaDatos facturaDatos = new FacturaDatos();

            public DataTable ObtenerDetallesFactura()
            {
                return facturaDatos.ObtenerDetallesFactura();
            }

            public Factura ObtenerFacturaPorId(int idFactura)
            {
                return facturaDatos.ObtenerFacturaPorId(idFactura);
            }
        }
}