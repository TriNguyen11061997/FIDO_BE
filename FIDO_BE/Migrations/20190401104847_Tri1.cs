using Microsoft.EntityFrameworkCore.Migrations;

namespace FIDO_BE.Migrations
{
    public partial class Tri1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ngay",
                table: "ADUserGroups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ngay",
                table: "ADUserGroups");
        }
    }
}
