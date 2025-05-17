namespace CapaEntidad
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Obligatorio
        public string? Correo { get; set; } // Opcional
        public string? Telefono { get; set; } // Opcional
        public string? Estado { get; set; } // Opcional
    }
    public class Factura
    {
        public int IdFactura { get; set; }
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}