using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_management_system.Migrations
{
    /// <inheritdoc />
    public partial class studentdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lecturers",
                columns: table => new
                {
                    LecId = table.Column<string>(type: "TEXT", nullable: false),
                    FirstNamel = table.Column<string>(type: "TEXT", nullable: false),
                    LastNamel = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNol = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturers", x => x.LecId);
                });

            migrationBuilder.CreateTable(
                name: "LecturerModules",
                columns: table => new
                {
                    LecturerId = table.Column<string>(type: "TEXT", nullable: false),
                    ModuleCodel = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturerModules", x => new { x.LecturerId, x.ModuleCodel });
                    table.ForeignKey(
                        name: "FK_LecturerModules_Lecturers_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturers",
                        principalColumn: "LecId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturerModules_Modules_ModuleCodel",
                        column: x => x.ModuleCodel,
                        principalTable: "Modules",
                        principalColumn: "ModCode",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LecturerModules_ModuleCodel",
                table: "LecturerModules",
                column: "ModuleCodel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LecturerModules");

            migrationBuilder.DropTable(
                name: "Lecturers");
        }
    }
}
