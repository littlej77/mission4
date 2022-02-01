using Microsoft.EntityFrameworkCore.Migrations;

namespace mission4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_responses_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 1, "Romance/Fantasy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 2, "Comedy/Adventure" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 3, "Rom-com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 4, "Horror" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 5, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 6, "Mystery" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryType" },
                values: new object[] { 7, "Drama" });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryID", "Director", "Edited", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, "Richard Curtis", true, "Live your life", "R", "About Time", 2013 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryID", "Director", "Edited", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 2, "Ben Stiller", true, "Start Living", "PG", "The Secret Life of Walter Mitty", 2013 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "MovieId", "CategoryID", "Director", "Edited", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 3, "Christian Ditter", false, "Fight for Love", "R", "Love, Rosie", 2014 });

            migrationBuilder.CreateIndex(
                name: "IX_responses_CategoryID",
                table: "responses",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
