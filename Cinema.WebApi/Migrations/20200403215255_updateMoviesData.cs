using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations
{
    public partial class updateMoviesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "164ca3af-4b7f-454f-bd07-9b8d6c3736cc",
                columns: new[] { "Actors", "Country", "Director", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer" },
                values: new object[] { "Tom Holland, Samuel L. Jackson, Jake Gyllenhaal, Marisa Tomei", "USA", "Jon Watts", "Action, Adventure, Sci-Fi", "Following the events of Avengers: Endgame (2019), Spider-Man must step up to take on new threats in a world that has changed forever.", "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SX300.jpg", "PG-13", "02 Jul 2019", "129 min", "Spider-Man: Far from Home", "Chris McKenna, Erik Sommers, Stan Lee (based on the Marvel comic book by), Steve Ditko (based on the Marvel comic book by)" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461",
                columns: new[] { "Actors", "Country", "Director", "Genre", "Plot", "Poster", "Released", "Runtime", "Title", "Writer" },
                values: new object[] { "Elizabeth Debicki, Robert Pattinson, Aaron Taylor-Johnson, Kenneth Branagh", "USA, UK", "Christopher Nolan", "Action, Drama, Thriller", "An action epic revolving around international espionage, time travel, and evolution. Possibly about a man trying to prevent World War 3 through time travel and rebirth.", "https://m.media-amazon.com/images/M/MV5BNmMwYzFlNTEtYTc0NC00NGY4LTgzNzItZGFiYTViY2QzNzU1XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "17 Jul 2020", "N/A", "Tenet", "Christopher Nolan" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "31446c42-fa95-4f38-8b8a-c5830649ca32",
                columns: new[] { "Actors", "Country", "Director", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer" },
                values: new object[] { "Christina Milian, Adam Demos, Jeffrey Bowyer-Chapman, Anna Jullienne", "USA", "Roger Kumble", "Comedy, Romance", "When city girl Gabriela spontaneously enters a contest and wins a rustic New Zealand inn, she teams up with bighearted contractor Jake Taylor to fix and flip it.", "https://m.media-amazon.com/images/M/MV5BNWE1NmMzNjUtMDc3NS00ZjBlLTllMTktZTVkMWQzZGVlYzdhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "TV-PG", "29 Aug 2019", "98 min", "Falling Inn Love", "Elizabeth Hackett, Hilary Galanoy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "164ca3af-4b7f-454f-bd07-9b8d6c3736cc",
                columns: new[] { "Actors", "Country", "Director", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer" },
                values: new object[] { "Darcie Lincoln, Peter Cosgrove, Victor Toth, Georgia Wood", "UK", "Louisa Warren", "History", "Ingrid and her siblings are on the run from the Beserkers who have begun invading the villages, taking over, savagely using the residents on a game where they vs a Beserker, and if they win...", "https://m.media-amazon.com/images/M/MV5BYTAwNjg3ZDUtZWYxOS00MGVjLTkyYTYtYjJhOGRhNmQzODRkXkEyXkFqcGdeQXVyMjM4MTU4NjQ@._V1_SX300.jpg", "N/A", "05 Feb 2019", "103 min", "The Viking War", "Suzy Spade" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461",
                columns: new[] { "Actors", "Country", "Director", "Genre", "Plot", "Poster", "Released", "Runtime", "Title", "Writer" },
                values: new object[] { "Meng-Po Fu, Chia-Yen Ko", "Taiwan", "Andrew Chien", "Drama, Romance", "Set in 2007, the movie tells of a complicated three-way relationship between a young singer and two people who believe in him.", "https://m.media-amazon.com/images/M/MV5BMTkxZTAwYTctODY3OC00NzdkLTg3ZTUtNThmMjk5ZDAzYjRiXkEyXkFqcGdeQXVyMjk2NDAwMw@@._V1_SX300.jpg", "23 Aug 2020", "119 min", "Your Love Song", "N/A" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "31446c42-fa95-4f38-8b8a-c5830649ca32",
                columns: new[] { "Actors", "Country", "Director", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer" },
                values: new object[] { "Hrithik Roshan, Tiger Shroff, Vaani Kapoor, Ashutosh Rana", "India", "Siddharth Anand", "Action, Thriller", "An Indian soldier is assigned a mission to eliminate his former mentor, who has gone rogue.", "https://m.media-amazon.com/images/M/MV5BNTlmNDMzOWQtYzg4Ny00OWQ0LWFhN2MtNmQ2MDczZGZhNTU5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg", "Not Rated", "02 Oct 2019", "154 min", "War", "Siddharth Anand (screenplay), Siddharth Anand (story), Aditya Chopra (story), Shridhar Raghavan (screenplay), Abbas Tyrewala (dialogue)" });
        }
    }
}
