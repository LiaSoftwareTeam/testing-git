using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPeliculaComentarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeliculaID",
                table: "Comentarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PeliculaID",
                table: "Comentarios",
                column: "PeliculaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comentarios_Pelicula_PeliculaID",
                table: "Comentarios",
                column: "PeliculaID",
                principalTable: "Pelicula",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comentarios_Pelicula_PeliculaID",
                table: "Comentarios");

            migrationBuilder.DropIndex(
                name: "IX_Comentarios_PeliculaID",
                table: "Comentarios");

            migrationBuilder.DropColumn(
                name: "PeliculaID",
                table: "Comentarios");
        }
    }
}
