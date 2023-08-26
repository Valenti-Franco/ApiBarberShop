using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class images : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "ImagenProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagenProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagenUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagenUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.InsertData(
                table: "ImagenProductos",
                columns: new[] { "Id", "FechaPublicado", "ProductoId", "URL" },
                values: new object[] { 1, new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1261), 1, "www.produtoImagen" });

            migrationBuilder.InsertData(
                table: "ImagenUsuarios",
                columns: new[] { "Id", "FechaPublicado", "URL", "UsuarioId" },
                values: new object[] { 1, new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1251), "www.usuarioImagen", 1 });

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 22, 11, 13, 45, 24, DateTimeKind.Local).AddTicks(1189));

            migrationBuilder.CreateIndex(
                name: "IX_ImagenProductos_ProductoId",
                table: "ImagenProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagenUsuarios_UsuarioId",
                table: "ImagenUsuarios",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImagenProductos");

            migrationBuilder.DropTable(
                name: "ImagenUsuarios");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.InsertData(
                table: "DetalleCompra",
                columns: new[] { "Id", "Cantidad", "FechaPublicado", "OrdenCompraId", "ProductoId" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6852), 1, 1 },
                    { 2, 1, new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6854), 1, 2 },
                    { 3, 5, new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6855), 1, 3 }
                });

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6793));
        }
    }
}
