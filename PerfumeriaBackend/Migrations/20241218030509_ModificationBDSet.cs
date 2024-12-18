using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PerfumeriaBackend.Migrations
{
    /// <inheritdoc />
    public partial class ModificationBDSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pVentas",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Fecha",
                value: new DateTime(2024, 12, 18, 3, 5, 8, 535, DateTimeKind.Utc).AddTicks(2303));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pVentas",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Fecha",
                value: new DateTime(2024, 12, 18, 3, 2, 0, 761, DateTimeKind.Utc).AddTicks(4063));
        }
    }
}
