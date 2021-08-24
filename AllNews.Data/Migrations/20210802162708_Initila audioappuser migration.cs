using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class Initilaaudioappusermigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audios_AspNetUsers_CreatedUserId",
                table: "Audios");

            migrationBuilder.DropForeignKey(
                name: "FK_Audios_AspNetUsers_UpdatedUserId",
                table: "Audios");

            migrationBuilder.DropIndex(
                name: "IX_Audios_CreatedUserId",
                table: "Audios");

            migrationBuilder.DropIndex(
                name: "IX_Audios_UpdatedUserId",
                table: "Audios");

            migrationBuilder.DropColumn(
                name: "CreatedUserId",
                table: "Audios");

            migrationBuilder.DropColumn(
                name: "UpdatedUserId",
                table: "Audios");

            migrationBuilder.CreateIndex(
                name: "IX_Audios_CreatedBy",
                table: "Audios",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Audios_UpdatedBy",
                table: "Audios",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Audios_AspNetUsers_CreatedBy",
                table: "Audios",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Audios_AspNetUsers_UpdatedBy",
                table: "Audios",
                column: "UpdatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audios_AspNetUsers_CreatedBy",
                table: "Audios");

            migrationBuilder.DropForeignKey(
                name: "FK_Audios_AspNetUsers_UpdatedBy",
                table: "Audios");

            migrationBuilder.DropIndex(
                name: "IX_Audios_CreatedBy",
                table: "Audios");

            migrationBuilder.DropIndex(
                name: "IX_Audios_UpdatedBy",
                table: "Audios");

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserId",
                table: "Audios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedUserId",
                table: "Audios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Audios_CreatedUserId",
                table: "Audios",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Audios_UpdatedUserId",
                table: "Audios",
                column: "UpdatedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Audios_AspNetUsers_CreatedUserId",
                table: "Audios",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Audios_AspNetUsers_UpdatedUserId",
                table: "Audios",
                column: "UpdatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
