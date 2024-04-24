using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFdemo.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchoolDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "grades",
                columns: table => new
                {
                    gradeid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grades", x => x.gradeid);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    studentid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gradeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.studentid);
                    table.ForeignKey(
                        name: "FK_students_grades_gradeid",
                        column: x => x.gradeid,
                        principalTable: "grades",
                        principalColumn: "gradeid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_gradeid",
                table: "students",
                column: "gradeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "grades");
        }
    }
}
