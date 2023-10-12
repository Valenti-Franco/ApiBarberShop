using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class ordenCompra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ImagenUsuarios_UsuarioId",
                table: "ImagenUsuarios");

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

            migrationBuilder.CreateIndex(
                name: "IX_Productos_CategoryId",
                table: "Productos",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagenUsuarios_UsuarioId",
                table: "ImagenUsuarios",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Category_CategoryId",
                table: "Productos",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Category_CategoryId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_CategoryId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_ImagenUsuarios_UsuarioId",
                table: "ImagenUsuarios");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "OrdenCompras");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "DetalleCompra",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "ImagenProductos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ImagenUsuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "OrdenCompras",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 5,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 6,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Puntos",
                keyColumn: "Id",
                keyValue: 7,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 2,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 3,
                column: "FechaPublicado",
                value: new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.CreateIndex(
                name: "IX_ImagenUsuarios_UsuarioId",
                table: "ImagenUsuarios",
                column: "UsuarioId");
        }
    }
}
