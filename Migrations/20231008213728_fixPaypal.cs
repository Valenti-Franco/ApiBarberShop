using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class fixPaypal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9376), new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9380), new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "ImagenProductos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "ImagenUsuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9342));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9365));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4113), "" });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 28, 45, 768, DateTimeKind.Local).AddTicks(4116), "8/10/2023" });

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
    }
}
