using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Achi_Sinema.Migrations
{
    /// <inheritdoc />
    public partial class m4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieActors",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    ActorMoviesMovieID = table.Column<int>(type: "int", nullable: false),
                    MovieActorsActorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => new { x.ActorMoviesMovieID, x.MovieActorsActorID });
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actors_MovieActorsActorID",
                        column: x => x.MovieActorsActorID,
                        principalTable: "Actors",
                        principalColumn: "ActorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movies_ActorMoviesMovieID",
                        column: x => x.ActorMoviesMovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MovieActorsActorID",
                table: "ActorMovie",
                column: "MovieActorsActorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.AddColumn<string>(
                name: "MovieActors",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
