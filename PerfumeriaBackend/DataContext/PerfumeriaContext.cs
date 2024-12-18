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
        public DbSet<Cliente> pClientes { get; set; }
        public DbSet<Producto> pProductos { get; set; }
        public DbSet<MetodoDePago> pMetodosDePago { get; set; }
        public DbSet<AreaDeVenta> pAreasDeVenta { get; set; }
        public DbSet<Venta> pVentas { get; set; }
        public DbSet<Usuario> pUsuario { get; set; }

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
            modelBuilder.Entity<Cliente>().HasData(
                new Cliente
                {
                    Id = 1,
                    Nombre = "Ana Gómez",
                    Correo = "ana.gomez@example.com",
                    Telefono = "1112223333"
                }
            );

            // Datos semilla para AreaDeVenta
            modelBuilder.Entity<AreaDeVenta>().HasData(
                new AreaDeVenta
                {
                    Id = 1,
                    Nombre = "Perfumes"
                }
            );

            // Datos semilla para Producto
            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Perfume Chanel N°5",
                    Precio = 120.50m,
                    AreaVentaId = 1
                }
            );

            // Datos semilla para MetodoDePago
            modelBuilder.Entity<MetodoDePago>().HasData(
                new MetodoDePago
                {
                    Id = 1,
                    Nombre = "Efectivo"
                }
            );

            // Datos semilla para Venta
            modelBuilder.Entity<Venta>().HasData(
                new Venta
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
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    NombreUsuario = "admin",
                    Email = "admin@example.com",
                    Contraseña = "123456",
                    TipoUsuario = TipoUsuarioEnum.Administrador
                }
            );
        }
        public DbSet<PerfumeriaServices.Models.Usuario> Usuario { get; set; } = default!;


    }
}
