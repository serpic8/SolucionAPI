using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_LIBROS.Migrations
{
    /// <inheritdoc />
    public partial class Sixthy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "libros",
                columns: new[] { "ID_AUTOR", "CATEGORIA", "EXISTENCIA", "PRECIO", "TITULO" },
                values: new object[] { 8, "Action", 5, 700.0, "Flash-Point" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "libros",
                keyColumn: "ID_AUTOR",
                keyValue: 8);
        }
    }
}
