using System.Data;
using Microsoft.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class ClienteDatos
    {
        private readonly string connectionString = "server=LAPTOP-NANT6IM3;database=ClientesyFacturas; integrated security=true; TrustServerCertificate=True";

        public DataTable ConsultarClientes()
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clientes";
                var adaptador = new SqlDataAdapter(query, conexion);
                var dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
        }

        public bool InsertarCliente(string nombre, string correo, string telefono, string estado)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clientes (Nombre, Correo, Telefono, Estado) VALUES (@Nombre, @Correo, @Telefono, @Estado)";
                using (var cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    cmd.Parameters.AddWithValue("@Estado", estado);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                    return true;
                }
            }
        }

        public bool EliminarCliente(int idCliente)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                try
                {
                    string consulta = "DELETE FROM Clientes WHERE IdCliente=@IdCliente";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@IdCliente", idCliente);
                        conexion.Open();
                        int filasAfectadas = comando.ExecuteNonQuery();

                        return filasAfectadas > 0; // Retorna true si se eliminó el cliente
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el cliente: " + ex.Message);
                    return false;
                }
            }
        }

        public bool EditarCliente(string id, string nombre, string correo, string telefono, string estado)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                try
                {
                    string consulta = "UPDATE Clientes SET Nombre=@Nombre, Correo=@Correo, Telefono=@Telefono, Estado=@Estado WHERE IdCliente=@Id";
                    using (var comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Nombre", nombre);
                        comando.Parameters.AddWithValue("@Correo", correo);
                        comando.Parameters.AddWithValue("@Telefono", telefono);
                        comando.Parameters.AddWithValue("@Estado", estado);
                        comando.Parameters.AddWithValue("@Id", id);
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        conexion.Close();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

    }
    public class FacturaDatos
    {
        private readonly string connectionString = "server=LAPTOP-NANT6IM3;database=ClientesyFacturas; integrated security=true; TrustServerCertificate=True";

        public DataTable ConsultarFacturas()
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM Facturas";
                var adaptador = new SqlDataAdapter(consulta, conexion);
                var dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
        }

        public List<Cliente> ConsultarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string consulta = "SELECT IdCliente, Nombre FROM Clientes";
                using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                        };
                        listaClientes.Add(cliente);
                    }
                }
            }
            return listaClientes;
        }

        public bool InsertarFactura(int idCliente, DateTime fecha, decimal total, string estado, Dictionary<string, decimal> productos)
        {
            using (var conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                try
                {
                    string consultaFactura = @"
                    INSERT INTO Facturas (IdCliente, Fecha, Total, Estado)
                    VALUES (@IdCliente, @Fecha, @Total, @Estado);
                    SELECT SCOPE_IDENTITY();";

                    int idFacturaInsertado;
                    using (SqlCommand cmd = new SqlCommand(consultaFactura, conexion))
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                        cmd.Parameters.AddWithValue("@Fecha", fecha.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@Estado", estado);

                        idFacturaInsertado = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    string consultaDetalle = @"
                    INSERT INTO DetalleFactura (IdFactura, Descripcion, Total, Subtotal)
                    VALUES (@IdFactura, @Descripcion, @Total, @Subtotal);";

                    string seleccionados = string.Join(", ", productos.Keys); // Obtiene nombres de productos seleccionados
                    using (SqlCommand cmdDetalle = new SqlCommand(consultaDetalle, conexion))
                    {
                        cmdDetalle.Parameters.AddWithValue("@IdFactura", idFacturaInsertado);
                        cmdDetalle.Parameters.AddWithValue("@Descripcion", seleccionados);
                        cmdDetalle.Parameters.AddWithValue("@Total", total);
                        cmdDetalle.Parameters.AddWithValue("@Subtotal", total / 1.18m);

                        cmdDetalle.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public DataTable ObtenerDetallesFactura()
        {
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string consulta = "SELECT * FROM DetalleFactura";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
        }

        public Factura ObtenerFacturaPorId(int idFactura)
        {
            Factura factura = null;
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                string query = @"SELECT C.Nombre AS NombreCliente, F.Fecha, D.Descripcion, D.SubTotal, D.Total
                         FROM Facturas F
                         INNER JOIN Clientes C ON F.IdCliente = C.IdCliente
                         INNER JOIN DetalleFactura D ON F.IdFactura = D.IdFactura
                         WHERE F.IdFactura = @IdFactura";

                using (SqlCommand cmd = new SqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@IdFactura", idFactura);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            factura = new Factura
                            {
                                IdFactura = idFactura,
                                NombreCliente = reader["NombreCliente"].ToString(),
                                Fecha = Convert.ToDateTime(reader["Fecha"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                SubTotal = Convert.ToDecimal(reader["SubTotal"]),
                                Total = Convert.ToDecimal(reader["Total"])
                            };
                        }
                        else
                        {
                            Console.WriteLine($"Factura con ID {idFactura} no encontrada.");
                        }
                    }
                }
            }
            return factura;
        }


    }
}