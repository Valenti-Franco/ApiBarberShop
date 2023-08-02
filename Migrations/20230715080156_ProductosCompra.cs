using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class ProductosCompra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EUsuariosId",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EUsuariosId1",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EUsuariosId", "EUsuariosId1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EUsuariosId", "EUsuariosId1" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EUsuariosId", "EUsuariosId1" },
                values: new object[] { null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_EUsuariosId",
                table: "Productos",
                column: "EUsuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_EUsuariosId1",
                table: "Productos",
                column: "EUsuariosId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Usuarios_EUsuariosId",
                table: "Productos",
                column: "EUsuariosId",
                principalTable: "Usuarios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Usuarios_EUsuariosId1",
                table: "Productos",
                column: "EUsuariosId1",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Usuarios_EUsuariosId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Usuarios_EUsuariosId1",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_EUsuariosId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_EUsuariosId1",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "EUsuariosId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "EUsuariosId1",
                table: "Productos");
        }
    }
}
