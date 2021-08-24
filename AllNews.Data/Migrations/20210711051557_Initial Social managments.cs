using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class InitialSocialmanagments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialManagments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    UpdatedBy = table.Column<int>(nullable: true),
                    CreatedUserId = table.Column<int>(nullable: true),
                    UpdatedUserId = table.Column<int>(nullable: true),
                    InstagramIdName = table.Column<string>(nullable: true),
                    WatsappIdName = table.Column<string>(nullable: true),
                    TelegramIdName = table.Column<string>(nullable: true),
                    YoutubeIdName = table.Column<string>(nullable: true),
                    TwitterIdName = table.Column<string>(nullable: true),
                    FacebookIdName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialManagments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialManagments_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SocialManagments_AspNetUsers_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SocialManagments_CreatedUserId",
                table: "SocialManagments",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialManagments_UpdatedUserId",
                table: "SocialManagments",
                column: "UpdatedUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialManagments");
        }
    }
}
