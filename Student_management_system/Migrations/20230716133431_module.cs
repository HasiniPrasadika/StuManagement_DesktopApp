using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_management_system.Migrations
{
    /// <inheritdoc />
    public partial class module : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LecturerModules_Modules_ModuleCodel",
                table: "LecturerModules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LecturerModules",
                table: "LecturerModules");

            migrationBuilder.RenameColumn(
                name: "ModuleCodel",
                table: "LecturerModules",
                newName: "ModuleModCode");

            migrationBuilder.RenameIndex(
                name: "IX_LecturerModules_ModuleCodel",
                table: "LecturerModules",
                newName: "IX_LecturerModules_ModuleModCode");

            migrationBuilder.AddColumn<string>(
                name: "ModCodel",
                table: "Lecturers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LecturerModules",
                table: "LecturerModules",
                column: "LecturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_LecturerModules_Modules_ModuleModCode",
                table: "LecturerModules",
                column: "ModuleModCode",
                principalTable: "Modules",
                principalColumn: "ModCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LecturerModules_Modules_ModuleModCode",
                table: "LecturerModules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LecturerModules",
                table: "LecturerModules");

            migrationBuilder.DropColumn(
                name: "ModCodel",
                table: "Lecturers");

            migrationBuilder.RenameColumn(
                name: "ModuleModCode",
                table: "LecturerModules",
                newName: "ModuleCodel");

            migrationBuilder.RenameIndex(
                name: "IX_LecturerModules_ModuleModCode",
                table: "LecturerModules",
                newName: "IX_LecturerModules_ModuleCodel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LecturerModules",
                table: "LecturerModules",
                columns: new[] { "LecturerId", "ModuleCodel" });

            migrationBuilder.AddForeignKey(
                name: "FK_LecturerModules_Modules_ModuleCodel",
                table: "LecturerModules",
                column: "ModuleCodel",
                principalTable: "Modules",
                principalColumn: "ModCode",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
