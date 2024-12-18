using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfumeriaBackend.Migrations
{
    /// <inheritdoc />
    public partial class OpenMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pAreasDeVenta",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pAreasDeVenta", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pClientes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Correo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefono = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pClientes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pMetodosDePago",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pMetodosDePago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NombreUsuario = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Contraseña = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoUsuario = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pProductos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Precio = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AreaVentaId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pProductos_pAreasDeVenta_AreaVentaId",
                        column: x => x.AreaVentaId,
                        principalTable: "pAreasDeVenta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pVentas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    ProductoId = table.Column<long>(type: "bigint", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    MetodoPagoId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pVentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_pVentas_pClientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "pClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pVentas_pMetodosDePago_MetodoPagoId",
                        column: x => x.MetodoPagoId,
                        principalTable: "pMetodosDePago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pVentas_pProductos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "pProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Contraseña", "Email", "IsDeleted", "NombreUsuario", "TipoUsuario" },
                values: new object[] { 1, "123456", "admin@example.com", false, "admin", 1 });

            migrationBuilder.InsertData(
                table: "pAreasDeVenta",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[] { 1L, false, "Perfumes" });

            migrationBuilder.InsertData(
                table: "pClientes",
                columns: new[] { "Id", "Correo", "IsDeleted", "Nombre", "Telefono" },
                values: new object[] { 1L, "ana.gomez@example.com", false, "Ana Gómez", "1112223333" });

            migrationBuilder.InsertData(
                table: "pMetodosDePago",
                columns: new[] { "Id", "IsDeleted", "Nombre" },
                values: new object[] { 1L, false, "Efectivo" });

            migrationBuilder.InsertData(
                table: "pProductos",
                columns: new[] { "Id", "AreaVentaId", "IsDeleted", "Nombre", "Precio" },
                values: new object[] { 1L, 1L, false, "Perfume Chanel N°5", 120.50m });

            migrationBuilder.InsertData(
                table: "pVentas",
                columns: new[] { "Id", "Cantidad", "ClienteId", "Fecha", "IsDeleted", "MetodoPagoId", "ProductoId" },
                values: new object[] { 1L, 2, 1L, new DateTime(2024, 12, 18, 3, 2, 0, 761, DateTimeKind.Utc).AddTicks(4063), false, 1L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_pProductos_AreaVentaId",
                table: "pProductos",
                column: "AreaVentaId");

            migrationBuilder.CreateIndex(
                name: "IX_pVentas_ClienteId",
                table: "pVentas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_pVentas_MetodoPagoId",
                table: "pVentas",
                column: "MetodoPagoId");

            migrationBuilder.CreateIndex(
                name: "IX_pVentas_ProductoId",
                table: "pVentas",
                column: "ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pVentas");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "pClientes");

            migrationBuilder.DropTable(
                name: "pMetodosDePago");

            migrationBuilder.DropTable(
                name: "pProductos");

            migrationBuilder.DropTable(
                name: "pAreasDeVenta");
        }
    }
}
