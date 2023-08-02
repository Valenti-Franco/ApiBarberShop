using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class Compras2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "Id", "Estado", "ProductoId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "pendiente", 1, 1 },
                    { 2, "confirmada", 2, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProductoId",
                table: "Compras",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_UsuarioId",
                table: "Compras",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

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
    }
}
