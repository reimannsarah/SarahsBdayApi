using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SarahBdayApi.Migrations
{
    public partial class AddPlusOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Species",
                table: "Attendants");

            migrationBuilder.AddColumn<bool>(
                name: "PlusOne",
                table: "Attendants",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlusOne",
                table: "Attendants");

            migrationBuilder.AddColumn<string>(
                name: "Species",
                table: "Attendants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
