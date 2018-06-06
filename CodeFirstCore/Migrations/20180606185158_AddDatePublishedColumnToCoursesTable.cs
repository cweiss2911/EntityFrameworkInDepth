using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstCore.Migrations
{
    public partial class AddDatePublishedColumnToCoursesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Courses");
        }
    }
}
