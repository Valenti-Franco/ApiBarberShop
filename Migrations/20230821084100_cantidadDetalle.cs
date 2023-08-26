using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class cantidadDetalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "DetalleCompra",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cantidad", "FechaPublicado" },
                values: new object[] { 3, new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cantidad", "FechaPublicado" },
                values: new object[] { 1, new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cantidad", "FechaPublicado" },
                values: new object[] { 5, new DateTime(2023, 8, 21, 5, 41, 0, 7, DateTimeKind.Local).AddTicks(6855) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "DetalleCompra");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 50, 3, 268, DateTimeKind.Local).AddTicks(5363));
        }
    }
}
