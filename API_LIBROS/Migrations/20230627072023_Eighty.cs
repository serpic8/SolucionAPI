using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API_LIBROS.Migrations
{
    /// <inheritdoc />
    public partial class Eighty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autores",
                columns: table => new
                {
                    ID_AUTOR = table.Column<int>(type: "int", nullable: false),
                    AUTOR = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.ID_AUTOR);
                });

            migrationBuilder.InsertData(
                table: "autores",
                columns: new[] { "ID_AUTOR", "AUTOR" },
                values: new object[,]
                {
                    { 1, "Juan Luis" },
                    { 2, "Miguel Uribina" },
                    { 3, "Ale" },
                    { 4, "Boba" },
                    { 5, "Lloron" },
                    { 6, "Hambre" },
                    { 7, "Dio mio" },
                    { 8, "Ojala Funcione" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "autores");
        }
    }
}
