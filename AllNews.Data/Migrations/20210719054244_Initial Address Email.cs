using Microsoft.EntityFrameworkCore.Migrations;

namespace AllNews.Data.Migrations
{
    public partial class InitialAddressEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WatsappIdName",
                table: "SocialManagments");

            migrationBuilder.AddColumn<string>(
                name: "AddressEmail",
                table: "SocialManagments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GmailIdName",
                table: "SocialManagments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressEmail",
                table: "SocialManagments");

            migrationBuilder.DropColumn(
                name: "GmailIdName",
                table: "SocialManagments");

            migrationBuilder.AddColumn<string>(
                name: "WatsappIdName",
                table: "SocialManagments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
