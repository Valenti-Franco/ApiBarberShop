using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TpiBarberShop.Migrations
{
    /// <inheritdoc />
    public partial class detalleCompra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 150, nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagenUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagenUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdenCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdenCompras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Stock = table.Column<int>(type: "INTEGER", nullable: false),
                    Precio = table.Column<int>(type: "INTEGER", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    SubcategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_SubCategory_SubcategoryId",
                        column: x => x.SubcategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<string>(type: "TEXT", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compras_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleCompra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrdenCompraId = table.Column<int>(type: "INTEGER", nullable: false),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleCompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleCompra_OrdenCompras_OrdenCompraId",
                        column: x => x.OrdenCompraId,
                        principalTable: "OrdenCompras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetalleCompra_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImagenProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    URL = table.Column<string>(type: "TEXT", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagenProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImagenProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Puntos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Puntos = table.Column<int>(type: "INTEGER", nullable: false),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    FechaPublicado = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puntos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puntos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Descripcion", "FechaPublicado", "Nombre" },
                values: new object[,]
                {
                    { 1, "es una tijera", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(492), "Tijera" },
                    { 2, "maquinita good", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(493), "Maquinita" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "Email", "FechaPublicado", "Nombre", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "jose@jose.com", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(467), "Jose", "123", "Cliente" },
                    { 2, "Franco@Franco.com", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(468), "Franco", "123", "Admin" },
                    { 3, "Pepito@Pepito.com", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(469), "Pepito", "123", "Cliente" }
                });

            migrationBuilder.InsertData(
                table: "ImagenUsuarios",
                columns: new[] { "Id", "FechaPublicado", "URL", "UsuarioId" },
                values: new object[] { 1, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(531), "www.usuarioImagen", 1 });

            migrationBuilder.InsertData(
                table: "OrdenCompras",
                columns: new[] { "Id", "Estado", "FechaPublicado", "UsuarioId" },
                values: new object[,]
                {
                    { 1, "confirmada", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(511), 1 },
                    { 2, "pendiente", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(513), 2 }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "CategoryId", "FechaPublicado", "Nombre" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(501), "Tijeras" },
                    { 2, 1, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(502), "Maquinita" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "CategoryId", "Descripcion", "FechaPublicado", "Nombre", "Precio", "Stock", "SubcategoryId" },
                values: new object[,]
                {
                    { 1, 2, "Navaja", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(319), "Navaja", 5, 40, 1 },
                    { 2, 1, "Gel de pelo", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(328), "Gel", 15, 100, 1 },
                    { 3, 1, "Maquinita para cortar", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(329), "Maquinita", 80, 15, 1 }
                });

            migrationBuilder.InsertData(
                table: "Compras",
                columns: new[] { "Id", "Cantidad", "Estado", "FechaPublicado", "ProductoId", "UsuarioId" },
                values: new object[,]
                {
                    { 1, 2, "pendiente", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(480), 1, 1 },
                    { 2, 4, "confirmada", new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(482), 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "DetalleCompra",
                columns: new[] { "Id", "Cantidad", "FechaPublicado", "OrdenCompraId", "ProductoId" },
                values: new object[] { 1, 3, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(522), 1, 1 });

            migrationBuilder.InsertData(
                table: "ImagenProductos",
                columns: new[] { "Id", "FechaPublicado", "ProductoId", "URL" },
                values: new object[] { 1, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(540), 1, "www.produtoImagen" });

            migrationBuilder.InsertData(
                table: "Puntos",
                columns: new[] { "Id", "FechaPublicado", "Nombre", "ProductoId", "Puntos", "UsuarioId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(447), "Pepito", 1, 3, 2 },
                    { 2, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(450), "Jorge", 2, 1, 3 },
                    { 3, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(452), "Juanchon", 3, 5, 6 },
                    { 4, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(449), "Robert", 1, 3, 7 },
                    { 5, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(450), "Jesus", 1, 3, 0 },
                    { 6, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(451), "Jorge123", 2, 2, 4 },
                    { 7, new DateTime(2023, 9, 1, 1, 40, 17, 552, DateTimeKind.Local).AddTicks(452), "perro", 2, 3, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProductoId",
                table: "Compras",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_UsuarioId",
                table: "Compras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompra_OrdenCompraId",
                table: "DetalleCompra",
                column: "OrdenCompraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleCompra_ProductoId",
                table: "DetalleCompra",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagenProductos_ProductoId",
                table: "ImagenProductos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_ImagenUsuarios_UsuarioId",
                table: "ImagenUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenCompras_UsuarioId",
                table: "OrdenCompras",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_SubcategoryId",
                table: "Productos",
                column: "SubcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Puntos_ProductoId",
                table: "Puntos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategory_CategoryId",
                table: "SubCategory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "DetalleCompra");

            migrationBuilder.DropTable(
                name: "ImagenProductos");

            migrationBuilder.DropTable(
                name: "ImagenUsuarios");

            migrationBuilder.DropTable(
                name: "Puntos");

            migrationBuilder.DropTable(
                name: "OrdenCompras");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
