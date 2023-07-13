using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class DAta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { 1, "Navaja Filosa", "Navaja" },
                    { 2, "Gel de pelo", "Gel" },
                    { 3, "Maquinita para cortar", "Maquinita" }
                });

            migrationBuilder.InsertData(
                table: "Puntos",
                columns: new[] { "Id", "Nombre", "ProductoId", "Puntos" },
                values: new object[,]
                {
                    { 1, "Pepito", 1, 3 },
                    { 2, "Jorge", 2, 1 },
                    { 3, "Juanchon", 3, 5 },
                    { 4, "Robert", 1, 3 },
                    { 5, "Jesus", 1, 3 },
                    { 6, "Jorge123", 2, 2 },
                    { 7, "perro", 2, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
