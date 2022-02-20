using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jachty.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jachts",
                columns: table => new
                {
                    JachtID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: true),
                    Typ = table.Column<string>(type: "TEXT", nullable: true),
                    Opis = table.Column<string>(type: "TEXT", nullable: true),
                    Cena = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageFileName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jachts", x => x.JachtID);
                });

            migrationBuilder.InsertData(
                table: "Jachts",
                columns: new[] { "JachtID", "Cena", "ImageFileName", "Nazwa", "Opis", "Typ" },
                values: new object[] { 1, 400m, "bavaria30.jpg", "Bavaria30", "Lorem Ipsum...", "Srodladowy" });

            migrationBuilder.InsertData(
                table: "Jachts",
                columns: new[] { "JachtID", "Cena", "ImageFileName", "Nazwa", "Opis", "Typ" },
                values: new object[] { 2, 500m, "bavaria31.jpg", "Bavaria31", "Lorem Ipsum...", "Srodladowy" });

            migrationBuilder.InsertData(
                table: "Jachts",
                columns: new[] { "JachtID", "Cena", "ImageFileName", "Nazwa", "Opis", "Typ" },
                values: new object[] { 3, 600m, "bavaria32.jpg", "Bavaria32", "Lorem Ipsum...", "Srodladowy" });

            migrationBuilder.InsertData(
                table: "Jachts",
                columns: new[] { "JachtID", "Cena", "ImageFileName", "Nazwa", "Opis", "Typ" },
                values: new object[] { 4, 800m, "bavaria50.jpg", "Bavaria50", "Lorem Ipsum...", "Morski" });

            migrationBuilder.InsertData(
                table: "Jachts",
                columns: new[] { "JachtID", "Cena", "ImageFileName", "Nazwa", "Opis", "Typ" },
                values: new object[] { 5, 1000m, "bavaria51.jpg", "Bavaria51", "Lorem Ipsum...", "Morski" });

            migrationBuilder.InsertData(
                table: "Jachts",
                columns: new[] { "JachtID", "Cena", "ImageFileName", "Nazwa", "Opis", "Typ" },
                values: new object[] { 6, 1200m, "bavaria55.jpg", "Bavaria55", "Lorem Ipsum...", "Morski" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jachts");
        }
    }
}
