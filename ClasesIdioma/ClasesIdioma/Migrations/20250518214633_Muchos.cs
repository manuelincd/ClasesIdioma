using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClasesIdioma.Migrations
{
    /// <inheritdoc />
    public partial class Muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Correo",
                table: "Maestros",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Maestros",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Correo",
                table: "Maestros");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Maestros");
        }
    }
}
