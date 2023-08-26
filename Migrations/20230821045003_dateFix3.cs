using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class dateFix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicado",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicado",
                table: "SubCategory",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicado",
                table: "Puntos",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicado",
                table: "OrdenCompras",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicado",
                table: "DetalleCompra",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaPublicado",
                table: "Category",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaPublicado",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FechaPublicado",
                table: "SubCategory");

            migrationBuilder.DropColumn(
                name: "FechaPublicado",
                table: "Puntos");

            migrationBuilder.DropColumn(
                name: "FechaPublicado",
                table: "OrdenCompras");

            migrationBuilder.DropColumn(
                name: "FechaPublicado",
                table: "DetalleCompra");

            migrationBuilder.DropColumn(
                name: "FechaPublicado",
                table: "Category");

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 47, 52, 604, DateTimeKind.Local).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 47, 52, 604, DateTimeKind.Local).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 47, 52, 604, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 47, 52, 604, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 47, 52, 604, DateTimeKind.Local).AddTicks(7442));
        }
    }
}
