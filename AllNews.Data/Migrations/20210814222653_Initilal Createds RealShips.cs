using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class InitilalCreatedsRealShips : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VideoImg",
                table: "News",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VideoImg",
                table: "News");
        }
    }
}
