using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FIDO_BE.Migrations
{
    public partial class DBFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADUserGroups",
                columns: table => new
                {
                    ADUserGroupID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AAStatus = table.Column<string>(nullable: true),
                    ADUserGroupName = table.Column<string>(nullable: true),
                    ADUserGroupDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADUserGroups", x => x.ADUserGroupID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADUserGroups");
        }
    }
}
