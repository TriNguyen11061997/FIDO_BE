using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIDO_BE.Migrations
{
    public partial class Tri2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Ngay",
                table: "ADUserGroups",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Ngay",
                table: "ADUserGroups",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);
        }
    }
}
