using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTEQ.EntityFrameworkPostgre.Migrations
{
    public partial class test9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "Customers",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "age",
                table: "Customers");
        }
    }
}
