using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class InitialUnsetParagraphs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstDescriptionSecondParagraph",
                table: "News");

            migrationBuilder.DropColumn(
                name: "FirstDescriptionThirdParagraph",
                table: "News");

            migrationBuilder.DropColumn(
                name: "SecondDescriptionSecondParagraph",
                table: "News");

            migrationBuilder.DropColumn(
                name: "SecondDescriptionThirdParagraph",
                table: "News");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstDescriptionSecondParagraph",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstDescriptionThirdParagraph",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondDescriptionSecondParagraph",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondDescriptionThirdParagraph",
                table: "News",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
