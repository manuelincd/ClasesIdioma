using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesIdioma.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maestros_Idiomas_IdiomaId1",
                table: "Maestros");

            migrationBuilder.DropIndex(
                name: "IX_Maestros_IdiomaId1",
                table: "Maestros");

            migrationBuilder.DropColumn(
                name: "IdiomaId1",
                table: "Maestros");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FK_Maestros_Idiomas_IdiomaId1",
                table: "Maestros",
                column: "IdiomaId1",
                principalTable: "Idiomas",
                principalColumn: "Id");
        }
    }
}
