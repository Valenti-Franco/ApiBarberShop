using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class PAY : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "clientePaypalId",
                table: "OrdenCompras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaPago",
                table: "OrdenCompras",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "pagoId",
                table: "OrdenCompras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "valorPago",
                table: "OrdenCompras",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7862), new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7866), new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "ImagenProductos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "ImagenUsuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Estado", "FechaPublicado", "clientePaypalId", "fechaPago", "pagoId", "valorPago" },
                values: new object[] { "pendiente", new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7904), "121", new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7905), "1", "121" });

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "clientePaypalId", "fechaPago", "pagoId", "valorPago" },
                values: new object[] { new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7906), "1", new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7907), "12", "233" });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "Password" },
                values: new object[] { new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7803), "$2a$11$QBfVcDxBTsNMp/NMGTgAZexNBj/epkt5W1z/GNqP1Blk.d2KoExPm" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "Password" },
                values: new object[] { new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7804), "$2a$11$QBfVcDxBTsNMp/NMGTgAZexNBj/epkt5W1z/GNqP1Blk.d2KoExPm" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaPublicado", "Password" },
                values: new object[] { new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7805), "$2a$11$QBfVcDxBTsNMp/NMGTgAZexNBj/epkt5W1z/GNqP1Blk.d2KoExPm" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "clientePaypalId",
                table: "OrdenCompras");

            migrationBuilder.DropColumn(
                name: "fechaPago",
                table: "OrdenCompras");

            migrationBuilder.DropColumn(
                name: "pagoId",
                table: "OrdenCompras");

            migrationBuilder.DropColumn(
                name: "valorPago",
                table: "OrdenCompras");

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
                columns: new[] { "Estado", "FechaPublicado" },
                values: new object[] { "confirmada", new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9419) });

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
                columns: new[] { "FechaPublicado", "Password" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9362), "123" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "Password" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9364), "123" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaPublicado", "Password" },
                values: new object[] { new DateTime(2023, 10, 8, 18, 37, 28, 552, DateTimeKind.Local).AddTicks(9365), "123" });
        }
    }
}
