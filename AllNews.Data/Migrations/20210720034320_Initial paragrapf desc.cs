using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class Initialparagrapfdesc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstDescriptionFirstParagraph",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstDescriptionSecondParagraph",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstDescriptionThirdParagraph",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondDescriptionFirstParagraph",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondDescriptionSecondParagraph",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondDescriptionThirdParagraph",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstDescriptionFirstParagraph",
                table: "News");

            migrationBuilder.DropColumn(
                name: "FirstDescriptionSecondParagraph",
                table: "News");

            migrationBuilder.DropColumn(
                name: "FirstDescriptionThirdParagraph",
                table: "News");

            migrationBuilder.DropColumn(
                name: "SecondDescriptionFirstParagraph",
                table: "News");

            migrationBuilder.DropColumn(
                name: "SecondDescriptionSecondParagraph",
                table: "News");

            migrationBuilder.DropColumn(
                name: "SecondDescriptionThirdParagraph",
                table: "News");
        }
    }
}
