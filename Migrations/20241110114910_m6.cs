using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Achi_Sinema.Migrations
{
    /// <inheritdoc />
    public partial class m6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MovieRating",
                table: "Movies");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    RatingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RatingName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.RatingId);
                });

            migrationBuilder.CreateTable(
                name: "MovieRating",
                columns: table => new
                {
                    MovieRatingsRatingId = table.Column<int>(type: "int", nullable: false),
                    RatingMoviesMovieID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieRating", x => new { x.MovieRatingsRatingId, x.RatingMoviesMovieID });
                    table.ForeignKey(
                        name: "FK_MovieRating_Movies_RatingMoviesMovieID",
                        column: x => x.RatingMoviesMovieID,
                        principalTable: "Movies",
                        principalColumn: "MovieID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieRating_Ratings_MovieRatingsRatingId",
                        column: x => x.MovieRatingsRatingId,
                        principalTable: "Ratings",
                        principalColumn: "RatingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreID", "GenreName" },
                values: new object[,]
                {
                    { 1, "Aksiyon" },
                    { 2, "Dram" },
                    { 3, "Komedi" },
                    { 4, "Korku" },
                    { 5, "Bilim Kurgu" },
                    { 6, "Fantastik" },
                    { 7, "Macera" },
                    { 8, "Romantik" },
                    { 9, "Belgesel" },
                    { 10, "Romantik" },
                    { 11, "Bilim Kurgu" },
                    { 12, "Gerilim" },
                    { 13, "Gizem" },
                    { 14, "Polisye" },
                    { 15, "Savaş" },
                    { 16, "Animasyon" },
                    { 17, "Çocuk" },
                    { 18, "Müzikal" },
                    { 19, "Tarih" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[,]
                {
                    { 1, "6 Yaş Altı" },
                    { 2, "6 Yaş Üstü" },
                    { 3, "10 Yaş Altı" },
                    { 4, "10 Yaş Üstü" },
                    { 5, "13 Yaş Altı" },
                    { 6, "13 Yaş Üstü" },
                    { 7, "16 Yaş Üstü" },
                    { 8, "18 Yaş Üstü" },
                    { 9, "Genel İzleyici Kitlesi" },
                    { 10, "Şiddet/Korku" },
                    { 11, "Cinsellik/Çıplaklık" },
                    { 12, "Olumsuz Örnek" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieRating_RatingMoviesMovieID",
                table: "MovieRating",
                column: "RatingMoviesMovieID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieRating");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreID",
                keyValue: 19);

            migrationBuilder.AddColumn<string>(
                name: "MovieRating",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
