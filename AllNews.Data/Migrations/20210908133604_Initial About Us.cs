using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class InitialAboutUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LangId",
                table: "About",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_About_LangId",
                table: "About",
                column: "LangId");

            migrationBuilder.AddForeignKey(
                name: "FK_About_Languages_LangId",
                table: "About",
                column: "LangId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_About_Languages_LangId",
                table: "About");

            migrationBuilder.DropIndex(
                name: "IX_About_LangId",
                table: "About");

            migrationBuilder.DropColumn(
                name: "LangId",
                table: "About");
        }
    }
}
