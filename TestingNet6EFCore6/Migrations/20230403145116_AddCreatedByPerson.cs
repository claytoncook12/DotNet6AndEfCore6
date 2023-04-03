using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingNet6EFCore6.Migrations
{
    public partial class AddCreatedByPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatedByPersonId",
                table: "ParentGroups",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByPersonId",
                table: "ParentGroups");
        }
    }
}
