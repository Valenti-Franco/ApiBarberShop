using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class paypalMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "OrdenCompras");

            migrationBuilder.AddColumn<string>(
                name: "clientePaypalId",
                table: "Compras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "fechaPago",
                table: "Compras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pagoId",
                table: "Compras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "valorPago",
                table: "Compras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "clientePaypalId", "fechaPago", "pagoId", "valorPago" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4113), "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "clientePaypalId", "fechaPago", "pagoId", "valorPago" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4116), "132342f", "8/10/2023", "123424223", "100" });

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "ImagenProductos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "ImagenUsuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4093));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clientePaypalId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "fechaPago",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "pagoId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "valorPago",
                table: "Compras");

            migrationBuilder.AddColumn<int>(
                name: "Total",
                table: "OrdenCompras",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "ImagenProductos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "ImagenUsuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "Total" },
                values: new object[] { new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8151), 100 });

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "Total" },
                values: new object[] { new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8153), 100 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 24, 15, 41, DateTimeKind.Local).AddTicks(8059));
        }
    }
}
