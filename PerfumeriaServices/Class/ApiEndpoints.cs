
namespace PerfumeriaServices.Class
{
    public static class ApiEndpoints
    {
        public static string AreaDeVenta { get; set; } = "AreaDeVentas";
        public static string Cliente { get; set; } = "Clientes";
        public static string MetodoDePago { get; set; } = "MetodoDePagos";
        public static string Producto { get; set; } = "Productos";
        public static string Usuario { get; set; } = "Usuarios";
        public static string Venta { get; set; } = "Ventas";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(AreaDeVenta) => AreaDeVenta,
                nameof(Cliente) => Cliente,
                nameof(MetodoDePago) => MetodoDePago,
                nameof(Producto) => Producto,
                nameof(Usuario) => Usuario,
                nameof(Venta) => Venta,

                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
