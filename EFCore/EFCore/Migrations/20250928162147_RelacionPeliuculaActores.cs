using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class RelacionPeliuculaActores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeliculasActores",
                columns: table => new
                {
                    PeliculaID = table.Column<int>(type: "int", nullable: false),
                    AutorID = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    Personaje = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Orden = table.Column<int>(type: "int", nullable: false),
                    PeliculasActorAutorID = table.Column<int>(type: "int", nullable: true),
                    PeliculasActorPeliculaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeliculasActores", x => new { x.PeliculaID, x.AutorID });
                    table.ForeignKey(
                        name: "FK_PeliculasActores_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculasActores_Pelicula_PeliculaID",
                        column: x => x.PeliculaID,
                        principalTable: "Pelicula",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeliculasActores_PeliculasActores_PeliculasActorPeliculaID_PeliculasActorAutorID",
                        columns: x => new { x.PeliculasActorPeliculaID, x.PeliculasActorAutorID },
                        principalTable: "PeliculasActores",
                        principalColumns: new[] { "PeliculaID", "AutorID" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeliculasActores_ActorId",
                table: "PeliculasActores",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_PeliculasActores_PeliculasActorPeliculaID_PeliculasActorAutorID",
                table: "PeliculasActores",
                columns: new[] { "PeliculasActorPeliculaID", "PeliculasActorAutorID" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeliculasActores");
        }
    }
}
