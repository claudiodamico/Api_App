using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api_App.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Titles = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Image", "Location", "Name", "Titles" },
                values: new object[,]
                {
                    { 1, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/5.png&h=200&w=200", "La Boca", "Boca", 74 },
                    { 2, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/16.png&h=200&w=200", "Nuñez", "River", 70 },
                    { 3, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/11.png&h=200&w=200", "Avellaneda", "Independiente", 45 },
                    { 4, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/15.png&h=200&w=200", "Avellaneda", "Racing Club", 39 },
                    { 5, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/18.png&h=200&w=200", "Flores", "San Lorenzo", 22 },
                    { 6, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/21.png&h=200&w=200", "Liniers", "Velez", 16 },
                    { 7, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/8.png&h=200&w=200", "La Plata", "Estudiantes", 14 },
                    { 8, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/10.png&h=200&w=200", "Parque Patricios", "Huracan", 13 },
                    { 9, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/17.png&h=200&w=200", "Rosario", "Rosario Central", 11 },
                    { 10, "https://a.espncdn.com/combiner/i?img=/i/teamlogos/soccer/500/14.png&h=200&w=200", "Rosario", "Newells", 9 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
