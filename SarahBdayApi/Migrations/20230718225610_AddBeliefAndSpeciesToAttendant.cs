using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SarahBdayApi.Migrations
{
    public partial class AddBeliefAndSpeciesToAttendant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PlusOne",
                table: "Attendants",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DoYouBelieve",
                table: "Attendants",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Species",
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
                name: "Species",
                table: "Attendants");

            migrationBuilder.AlterColumn<bool>(
                name: "PlusOne",
                table: "Attendants",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
