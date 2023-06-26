using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_LIBROS.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "libros",
                columns: table => new
                {
                    ID_AUTOR = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITULO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRECIO = table.Column<double>(type: "float", nullable: false),
                    CATEGORIA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EXISTENCIA = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libros", x => x.ID_AUTOR);
                });

            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "ID_AUTOR", "CATEGORIA", "EXISTENCIA", "PRECIO", "TITULO" },
                values: new object[,]
                {
                    { 1, "Filosofia", 9, 700.0, "Camino Hacia el Dorado" },
                    { 2, "Historia", 4, 800.0, "EL Alquimista" },
                    { 3, "Aventura", 10, 700.0, "Viaje al Fin del Mundo" },
                    { 4, "Slice of Life", 1, 700.0, "Superman:Legacy" },
                    { 5, "Fantasia Oscura", 9, 10000.0, "Coraline" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "libros");
        }
    }
}
