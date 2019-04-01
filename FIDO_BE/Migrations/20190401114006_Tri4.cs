using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIDO_BE.Migrations
{
    public partial class Tri4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Ngay1",
                table: "ADUserGroups",
                type: "datetime",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ngay1",
                table: "ADUserGroups");
        }
    }
}
