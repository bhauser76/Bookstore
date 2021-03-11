using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookTitle = table.Column<string>(nullable: false),
                    BookAuthor = table.Column<string>(nullable: false),
                    BookPublisher = table.Column<string>(nullable: false),
                    BookISBN = table.Column<string>(nullable: false),
                    BookCategory = table.Column<string>(nullable: false),
                    BookPrice = table.Column<double>(nullable: false),
                    BookPages = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
