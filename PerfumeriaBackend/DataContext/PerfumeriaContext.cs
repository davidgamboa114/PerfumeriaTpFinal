using Microsoft.EntityFrameworkCore;
using PerfumeriaServices.Enums;
using PerfumeriaServices.Models;



namespace PerfumeriaBackend.DataContext
{
    public partial class PerfumeriaContext : DbContext
    {
        public PerfumeriaContext()
        {
        }
        public PerfumeriaContext(DbContextOptions<PerfumeriaContext> options) : base(options)
        {
        }

        // DbSets
        public DbSet<pCliente> pClientes { get; set; }
        public DbSet<pProducto> pProductos { get; set; }
        public DbSet<pMetodoDePago> pMetodosDePago { get; set; }
        public DbSet<pAreaDeVenta> pAreasDeVenta { get; set; }
        public DbSet<pVenta> pVentas { get; set; }
        public DbSet<pUsuario> pUsuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

            optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
        }

        //Datos Semilla OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Datos semilla para Cliente
            modelBuilder.Entity<pCliente>().HasData(
                new pCliente
                {
                    Id = 1,
                    Nombre = "Ana Gómez",
                    Correo = "ana.gomez@example.com",
                    Telefono = "1112223333"
                }
            );

            // Datos semilla para AreaDeVenta
            modelBuilder.Entity<pAreaDeVenta>().HasData(
                new pAreaDeVenta
                {
                    Id = 1,
                    Nombre = "Perfumes"
                }
            );

            // Datos semilla para Producto
            modelBuilder.Entity<pProducto>().HasData(
                new pProducto
                {
                    Id = 1,
                    Nombre = "Perfume Chanel N°5",
                    Precio = 120.50m,
                    AreaVentaId = 1
                }
            );

            // Datos semilla para MetodoDePago
            modelBuilder.Entity<pMetodoDePago>().HasData(
                new pMetodoDePago
                {
                    Id = 1,
                    Nombre = "Efectivo"
                }
            );

            // Datos semilla para Venta
            modelBuilder.Entity<pVenta>().HasData(
                new pVenta
                {
                    Id = 1,
                    Fecha = DateTime.UtcNow,
                    ClienteId = 1,
                    ProductoId = 1,
                    Cantidad = 2,
                    MetodoPagoId = 1
                }
            );

            // Datos semilla para Usuario
            modelBuilder.Entity<pUsuario>().HasData(
                new pUsuario
                {
                    Id = 1,
                    NombreUsuario = "admin",
                    Email = "admin@example.com",
                    Contraseña = "123456",
                    TipoUsuario = TipoUsuarioEnum.Administrador
                }
            );
        }
        public DbSet<PerfumeriaServices.Models.pUsuario> Usuario { get; set; } = default!;


    }
}
