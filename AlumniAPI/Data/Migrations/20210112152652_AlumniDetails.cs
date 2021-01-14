using Microsoft.EntityFrameworkCore.Migrations;

namespace AlumniAPI.Data.Migrations
{
    public partial class AlumniDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Achievements",
                table: "applicationUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Batch",
                table: "applicationUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CurrentPosition",
                table: "applicationUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "applicationUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmploymentHistory",
                table: "applicationUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Memory",
                table: "applicationUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OtherDetails",
                table: "applicationUsers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Achievements",
                table: "applicationUsers");

            migrationBuilder.DropColumn(
                name: "Batch",
                table: "applicationUsers");

            migrationBuilder.DropColumn(
                name: "CurrentPosition",
                table: "applicationUsers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "applicationUsers");

            migrationBuilder.DropColumn(
                name: "EmploymentHistory",
                table: "applicationUsers");

            migrationBuilder.DropColumn(
                name: "Memory",
                table: "applicationUsers");

            migrationBuilder.DropColumn(
                name: "OtherDetails",
                table: "applicationUsers");
        }
    }
}
