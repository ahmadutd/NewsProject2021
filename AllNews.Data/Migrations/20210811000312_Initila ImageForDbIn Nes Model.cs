using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class InitilaImageForDbInNesModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageCoverPath",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageCoverPath",
                table: "News");
        }
    }
}
