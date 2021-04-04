using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTEQ.EntityFrameworkPostgre.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "Categories",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title1",
                table: "Categories",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Title1",
                table: "Categories");
        }
    }
}
