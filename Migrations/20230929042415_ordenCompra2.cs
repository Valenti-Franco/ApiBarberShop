using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class ordenCompra2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "ImagenProductos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "ImagenUsuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3666));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 29, 1, 21, 9, 689, DateTimeKind.Local).AddTicks(3833));
        }
    }
}
