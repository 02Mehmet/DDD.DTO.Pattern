using Microsoft.EntityFrameworkCore.Migrations;

namespace QLTEQ.EntityFrameworkPostgre.Migrations
{
    public partial class test7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Customers",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tcid",
                table: "Customers",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "tcid",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");
        }
    }
}
