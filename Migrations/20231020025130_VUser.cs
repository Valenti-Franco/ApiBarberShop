using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class VUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Usuarios",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "PasswordResetToken",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Usuarios",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<DateTime>(
                name: "ResetTokenExpires",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "VerificationToken",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "VerifiedAt",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9280), new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9284), new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "ImagenProductos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "ImagenUsuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9325), new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9327) });

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9327), new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "PasswordHash", "PasswordResetToken", "PasswordSalt", "ResetTokenExpires", "VerificationToken", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9259), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "adasd", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9262), "adsd", new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "PasswordHash", "PasswordResetToken", "PasswordSalt", "ResetTokenExpires", "VerificationToken", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9264), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "adasd", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9265), "adsd", new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaPublicado", "PasswordHash", "PasswordResetToken", "PasswordSalt", "ResetTokenExpires", "VerificationToken", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9266), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "adasd", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9267), "adsd", new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9267) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ResetTokenExpires",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "VerificationToken",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "VerifiedAt",
                table: "Usuarios");

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
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7904), new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7906), new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7907) });

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
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 16, 20, 50, 41, 763, DateTimeKind.Local).AddTicks(7805));
        }
    }
}
