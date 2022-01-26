using Microsoft.EntityFrameworkCore.Migrations;

namespace mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Romance/Fantasy", "Richard Curtis", true, "Live your life", "R", "About Time", 2013 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Adventure", "Ben Stiller", true, "Start Living", "PG", "The Secret Life of Walter Mitty", 2013 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "Category", "Director", "Edited", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Comedy/Romance", "Christian Ditter", false, "Fight for Love", "R", "Love, Rosie", 2014 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
