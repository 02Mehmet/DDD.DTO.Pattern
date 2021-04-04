using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTEQ.EntityFrameworkPostgre.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "welcomeEmailWasSent",
                table: "Customers",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "welcomeEmailWasSent",
                table: "Customers");
        }
    }
}
