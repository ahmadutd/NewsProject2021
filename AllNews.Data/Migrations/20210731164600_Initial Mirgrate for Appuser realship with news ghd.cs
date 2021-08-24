using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class InitialMirgrateforAppuserrealshipwithnewsghd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_AspNetUsers_UpdatedUserId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_UpdatedUserId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "UpdatedUserId",
                table: "News");

            migrationBuilder.CreateIndex(
                name: "IX_News_UpdatedBy",
                table: "News",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_News_AspNetUsers_UpdatedBy",
                table: "News",
                column: "UpdatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_AspNetUsers_UpdatedBy",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_UpdatedBy",
                table: "News");

            migrationBuilder.AddColumn<int>(
                name: "UpdatedUserId",
                table: "News",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_UpdatedUserId",
                table: "News",
                column: "UpdatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_News_AspNetUsers_UpdatedUserId",
                table: "News",
                column: "UpdatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
