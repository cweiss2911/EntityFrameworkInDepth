using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstCore.Migrations
{
    public partial class DeleteDatePublishedFromCoursesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatePublished",
                table: "Courses");
            migrationBuilder.Sql("insert into \"Categories\" values(3, 'Banging')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatePublished",
                table: "Courses",
                nullable: true);
        }
    }
}
