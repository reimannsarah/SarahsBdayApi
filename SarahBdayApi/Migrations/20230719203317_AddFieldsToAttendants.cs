using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SarahBdayApi.Migrations
{
    public partial class AddFieldsToAttendants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlusOne",
                table: "Attendants");

            migrationBuilder.AddColumn<string>(
                name: "DoYouBelieve",
                table: "Attendants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Sepcies",
                table: "Attendants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoYouBelieve",
                table: "Attendants");

            migrationBuilder.DropColumn(
                name: "Sepcies",
                table: "Attendants");

            migrationBuilder.AddColumn<bool>(
                name: "PlusOne",
                table: "Attendants",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
