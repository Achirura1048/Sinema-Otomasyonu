using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Achi_Sinema.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorBirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActorGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorBiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorID);
                });

            migrationBuilder.CreateTable(
                name: "Directors",
                columns: table => new
                {
                    DirectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DirectorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorBirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DirectorGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorBiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DirectorImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directors", x => x.DirectorID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    StaffID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffSurname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffLogin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.StaffID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieGenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieDirectorDirectorID = table.Column<int>(type: "int", nullable: false),
                    MovieActors = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieRelase = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieIMBDRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieRating = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoviePoster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovieSummary = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Movies_Directors_MovieDirectorDirectorID",
                        column: x => x.MovieDirectorDirectorID,
                        principalTable: "Directors",
                        principalColumn: "DirectorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "StaffID", "StaffLogin", "StaffName", "StaffPassword", "StaffSurname" },
                values: new object[] { 1, "atilla", "Atilla Burak", "12345", "Artıran" });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_MovieDirectorDirectorID",
                table: "Movies",
                column: "MovieDirectorDirectorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Directors");
        }
    }
}
