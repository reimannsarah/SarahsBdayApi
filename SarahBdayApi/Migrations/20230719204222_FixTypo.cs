using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SarahBdayApi.Migrations
{
    public partial class FixTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sepcies",
                table: "Attendants",
                newName: "Species");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Species",
                table: "Attendants",
                newName: "Sepcies");
        }
    }
}
