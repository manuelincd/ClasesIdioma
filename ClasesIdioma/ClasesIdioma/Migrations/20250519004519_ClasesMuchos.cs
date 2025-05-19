using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesIdioma.Migrations
{
    /// <inheritdoc />
    public partial class ClasesMuchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clases_Maestros_MaestroId1",
                table: "Clases");

            migrationBuilder.DropForeignKey(
                name: "FK_Maestros_Idiomas_IdiomaId",
                table: "Maestros");

            migrationBuilder.DropIndex(
                name: "IX_Clases_MaestroId1",
                table: "Clases");

            migrationBuilder.DropColumn(
                name: "MaestroId1",
                table: "Clases");

            migrationBuilder.AddColumn<int>(
                name: "IdiomaId1",
                table: "Maestros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Maestros_IdiomaId1",
                table: "Maestros",
                column: "IdiomaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Maestros_Idiomas_IdiomaId",
                table: "Maestros",
                column: "IdiomaId",
                principalTable: "Idiomas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Maestros_Idiomas_IdiomaId1",
                table: "Maestros",
                column: "IdiomaId1",
                principalTable: "Idiomas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maestros_Idiomas_IdiomaId",
                table: "Maestros");

            migrationBuilder.DropForeignKey(
                name: "FK_Maestros_Idiomas_IdiomaId1",
                table: "Maestros");

            migrationBuilder.DropIndex(
                name: "IX_Maestros_IdiomaId1",
                table: "Maestros");

            migrationBuilder.DropColumn(
                name: "IdiomaId1",
                table: "Maestros");

            migrationBuilder.AddColumn<int>(
                name: "MaestroId1",
                table: "Clases",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clases_MaestroId1",
                table: "Clases",
                column: "MaestroId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Clases_Maestros_MaestroId1",
                table: "Clases",
                column: "MaestroId1",
                principalTable: "Maestros",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Maestros_Idiomas_IdiomaId",
                table: "Maestros",
                column: "IdiomaId",
                principalTable: "Idiomas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
