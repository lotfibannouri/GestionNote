using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GestionNote.Migrations
{
    /// <inheritdoc />
    public partial class secondmigation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Matieres_matieresID",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_matieresID",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "matieresID",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "Designation",
                table: "Matieres",
                newName: "Description");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_IDMatieres",
                table: "Notes",
                column: "IDMatieres");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Matieres_IDMatieres",
                table: "Notes",
                column: "IDMatieres",
                principalTable: "Matieres",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Matieres_IDMatieres",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_IDMatieres",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Matieres",
                newName: "Designation");

            migrationBuilder.AddColumn<int>(
                name: "matieresID",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_matieresID",
                table: "Notes",
                column: "matieresID");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Matieres_matieresID",
                table: "Notes",
                column: "matieresID",
                principalTable: "Matieres",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
