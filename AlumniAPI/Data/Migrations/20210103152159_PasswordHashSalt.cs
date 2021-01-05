using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlumniAPI.Data.Migrations
{
    public partial class PasswordHashSalt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "applicationUsers",
                type: "BLOB",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "applicationUsers",
                type: "BLOB",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "applicationUsers");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "applicationUsers");
        }
    }
}
