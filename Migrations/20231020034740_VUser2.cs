using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class VUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Usuarios");

            migrationBuilder.AlterColumn<DateTime>(
                name: "VerifiedAt",
                table: "Usuarios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "VerificationToken",
                table: "Usuarios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResetTokenExpires",
                table: "Usuarios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordResetToken",
                table: "Usuarios",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(866), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(869), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(870) });

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "ImagenProductos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "ImagenUsuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(911), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(914) });

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "fechaPago" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(914), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaPublicado", "ResetTokenExpires", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(846), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(849), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(847) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "ResetTokenExpires", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(850), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(852), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaPublicado", "ResetTokenExpires", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(852), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(854), new DateTime(2023, 10, 20, 0, 47, 39, 937, DateTimeKind.Local).AddTicks(853) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VerifiedAt",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VerificationToken",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ResetTokenExpires",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordResetToken",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Usuarios",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Usuarios",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

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
                columns: new[] { "FechaPublicado", "PasswordHash", "PasswordSalt", "ResetTokenExpires", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9259), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9262), new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9261) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaPublicado", "PasswordHash", "PasswordSalt", "ResetTokenExpires", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9264), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9265) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FechaPublicado", "PasswordHash", "PasswordSalt", "ResetTokenExpires", "VerifiedAt" },
                values: new object[] { new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9266), new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9267), new DateTime(2023, 10, 19, 23, 51, 29, 871, DateTimeKind.Local).AddTicks(9267) });
        }
    }
}
