using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class dateFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 16, 40, 300, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 16, 40, 300, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 8, 21, 1, 16, 40, 300, DateTimeKind.Local).AddTicks(7051));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
