using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CodeFirstCore.Migrations
{
    public partial class AddCategoriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_Courses_CourseId",
                table: "CourseTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag");

            migrationBuilder.DropIndex(
                name: "IX_CourseTag_CourseId",
                table: "CourseTag");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "CourseTag");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CourseTag",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag",
                columns: new[] { "CourseId", "TagId" });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_Courses_CourseId",
                table: "CourseTag",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_Courses_CourseId",
                table: "CourseTag");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "CourseTag",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "CourseTag",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag",
                columns: new[] { "PostId", "TagId" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseTag_CourseId",
                table: "CourseTag",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_Courses_CourseId",
                table: "CourseTag",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
