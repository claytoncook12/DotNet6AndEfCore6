using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestingNet6EFCore6.Migrations
{
    public partial class PeopleParentGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeopleParentGroups",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentGroupId = table.Column<int>(type: "INTEGER", nullable: false),
                    PeoplePersonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleParentGroups", x => new { x.PersonId, x.ParentGroupId });
                    table.ForeignKey(
                        name: "FK_PeopleParentGroups_ParentGroups_ParentGroupId",
                        column: x => x.ParentGroupId,
                        principalTable: "ParentGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleParentGroups_People_PeoplePersonId",
                        column: x => x.PeoplePersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleParentGroups_ParentGroupId",
                table: "PeopleParentGroups",
                column: "ParentGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleParentGroups_PeoplePersonId",
                table: "PeopleParentGroups",
                column: "PeoplePersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeopleParentGroups");
        }
    }
}
