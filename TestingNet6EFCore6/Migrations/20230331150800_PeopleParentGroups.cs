using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingNet6EFCore6.Migrations
{
    public partial class PeopleParentGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeopleParentGroup",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentGroupId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleParentGroup", x => new { x.PersonId, x.ParentGroupId });
                    table.ForeignKey(
                        name: "FK_PeopleParentGroup_ParentGroups_ParentGroupId",
                        column: x => x.ParentGroupId,
                        principalTable: "ParentGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleParentGroup_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleParentGroup_ParentGroupId",
                table: "PeopleParentGroup",
                column: "ParentGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeopleParentGroup");
        }
    }
}
