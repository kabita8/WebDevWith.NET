using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CollegeManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class FKSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Session",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Session_CourseId",
                table: "Session",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Courses_CourseId",
                table: "Session",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Session_Courses_CourseId",
                table: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Session_CourseId",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Session");
        }
    }
}
