
namespace PerfumeriaServices.Class
{
    public static class ApiEndpoints
    {
        public static string pAreaDeVenta { get; set; } = "pAreaDeVentas";
        public static string pCliente { get; set; } = "pClientes";
        public static string pMetodoDePago { get; set; } = "pMetodoDePagos";
        public static string pProducto { get; set; } = "pProductos";
        public static string pUsuario { get; set; } = "pUsuarios";
        public static string pVenta { get; set; } = "pVentas";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(pAreaDeVenta) => pAreaDeVenta,
                nameof(pCliente) => pCliente,
                nameof(pMetodoDePago) => pMetodoDePago,
                nameof(pProducto) => pProducto,
                nameof(pUsuario) => pUsuario,
                nameof(pVenta) => pVenta,

                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }
}
