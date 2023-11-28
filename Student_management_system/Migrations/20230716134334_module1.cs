using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_management_system.Migrations
{
    /// <inheritdoc />
    public partial class module1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LecturerModules_Modules_ModuleModCode",
                table: "LecturerModules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LecturerModules",
                table: "LecturerModules");

            migrationBuilder.RenameColumn(
                name: "ModuleModCode",
                table: "LecturerModules",
                newName: "ModCodelec");

            migrationBuilder.RenameIndex(
                name: "IX_LecturerModules_ModuleModCode",
                table: "LecturerModules",
                newName: "IX_LecturerModules_ModCodelec");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LecturerModules",
                table: "LecturerModules",
                columns: new[] { "LecturerId", "ModCodelec" });

            migrationBuilder.AddForeignKey(
                name: "FK_LecturerModules_Modules_ModCodelec",
                table: "LecturerModules",
                column: "ModCodelec",
                principalTable: "Modules",
                principalColumn: "ModCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LecturerModules_Modules_ModCodelec",
                table: "LecturerModules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LecturerModules",
                table: "LecturerModules");

            migrationBuilder.RenameColumn(
                name: "ModCodelec",
                table: "LecturerModules",
                newName: "ModuleModCode");

            migrationBuilder.RenameIndex(
                name: "IX_LecturerModules_ModCodelec",
                table: "LecturerModules",
                newName: "IX_LecturerModules_ModuleModCode");

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
    }
}
