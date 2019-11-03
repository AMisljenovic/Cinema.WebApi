using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations
{
    public partial class CinemaWebApiModelsMovieContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer", "Year" },
                values: new object[,]
                {
                    { "9b227d7b-c427-4dc5-9f82-77c307f69ac0", "Hrithik Roshan, Tiger Shroff, Vaani Kapoor, Ashutosh Rana", "India", "Action, Thriller", "An Indian soldier is assigned a mission to eliminate his former mentor, who has gone rogue.", "https://m.media-amazon.com/images/M/MV5BNTlmNDMzOWQtYzg4Ny00OWQ0LWFhN2MtNmQ2MDczZGZhNTU5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg", "Not Rated", "02 Oct 2019", "154 min", "War", "Siddharth Anand (screenplay), Siddharth Anand (story), Aditya Chopra (story), Shridhar Raghavan (screenplay), Abbas Tyrewala (dialogue)", "2019" },
                    { "ee2fddbe-ac9b-4e9a-84e4-0c390fa7c3e9", "Alban Lenoir, Olga Kurylenko, Sébastien Lalanne, David Murgia", "France, Belgium", "Action, Drama, History, War", "In February 1976 in Djibouti, a school bus was taken hostage at the Somali border. The GIGN is sent on the spot. After 30 hours of tension, a rescue operation is organized.", "https://m.media-amazon.com/images/M/MV5BMDZiNDcxYzItN2JhNy00MjgxLTgyNjMtNzdiOWU1Y2MwODYxXkEyXkFqcGdeQXVyNzc0MTgzMzU@._V1_SX300.jpg", "TV-14", "30 Jan 2019", "98 min", "15 Minutes of War", "Ileana Epsztajn (collaboration), Fred Grivois (screenplay), Jérémie Guez (collaboration)", "2019" },
                    { "c75c376c-5fa3-4eff-9b4d-f8281f3a81e7", "Darcie Lincoln, Peter Cosgrove, Victor Toth, Georgia Wood", "UK", "History", "Ingrid and her siblings are on the run from the Beserkers who have begun invading the villages, taking over, savagely using the residents on a game where they vs a Beserker, and if they win...", "https://m.media-amazon.com/images/M/MV5BYTAwNjg3ZDUtZWYxOS00MGVjLTkyYTYtYjJhOGRhNmQzODRkXkEyXkFqcGdeQXVyMjM4MTU4NjQ@._V1_SX300.jpg", "N/A", "05 Feb 2019", "103 min", "The Viking War", "Suzy Spade", "2019" },
                    { "36100801-5f5b-4795-806e-a5df0b434493", "Karra Elejalde, Eduard Fernández, Santi Prego, Luis Bermejo", "Spain, Argentina", "Drama, History, War", "July 18, 1936. Salamanca, Castilla and León (center to Spain). The Spanish army declares in the city the state of war, hoping to extend it to the rest of Spain and improve the unstable ...", "https://m.media-amazon.com/images/M/MV5BOGZjZDgxYTItMDQwYS00MWQ1LTk3ZGEtNjY1MmIwNDk5OWZjXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_SX300.jpg", "N/A", "27 Sep 2019", "107 min", "While at War", "Alejandro Amenábar, Alejandro Hernández", "2019" },
                    { "d6575425-bb05-417c-9c90-a42baffb2a31", "Michael Roark, Trace Adkins, Ali Afshar, Allison Paige", "USA", "Sport", "After surviving an IED explosion in combat overseas, a young soldier with the Army Motorcycle Unit is medically discharged with a broken back and leg. Against all odds he trains to make an ...", "https://m.media-amazon.com/images/M/MV5BNzM0Zjc2OWMtY2NjNS00ZmE4LWEzZTItMWE3NjQ4NmM2YzE2XkEyXkFqcGdeQXVyOTk0Mjc1MDA@._V1_SX300.jpg", "PG-13", "30 Aug 2019", "94 min", "Bennett's War", "Alex Ranarivelo", "2019" },
                    { "1e699e33-eaca-449d-b5b0-7174f50ec5d6", "Robert De Niro, Uma Thurman, Christopher Walken, Jane Seymour", "USA", "Comedy, Family", "Upset that he has to share the room he loves with his grandfather, Peter decides to declare war in an attempt to get it back.", "https://m.media-amazon.com/images/M/MV5BZjU0MDRmMjAtZGU2Ny00ODkxLThiMDUtMmI1MDJhNDc5YTZkXkEyXkFqcGdeQXVyMzgxOTMzOTA@._V1_SX300.jpg", "PG", "27 Dec 2018", "141 min", "The War with Grandpa", "Tom J. Astle (screenplay by), Matt Ember (screenplay by), Robert Kimmel Smith (based on the book by)", "2019" },
                    { "086729d4-a5a5-46ad-ae7f-7439e6f724cb", "Sven Schelker, Charlotte Heinimann, Daniel Ludwig, Matthew Crowley", "Switzerland, Austria", "Drama", "1984: Searching for an experience that goes deeper than the superficiality of modern civilization, Bruno Manser travels into the jungles of Borneo and finds it with the nomadic Penan tribe....", "https://m.media-amazon.com/images/M/MV5BZWM1NzEyNDAtZDFhNi00NzBhLTg3MWEtN2Y1YjI5YTYzZTM5XkEyXkFqcGdeQXVyNDkzNTM2ODg@._V1_SX300.jpg", "N/A", "26 Sep 2019", "142 min", "Paradise War: The Story of Bruno Manser", "David Clemens, Niklaus Hilber, Patrick Tönz", "2019" },
                    { "155727bb-39c1-4734-ab48-a05d74756906", "Christina Milian, Adam Demos, Jeffrey Bowyer-Chapman, Anna Jullienne", "USA", "Comedy, Romance", "When city girl Gabriela spontaneously enters a contest and wins a rustic New Zealand inn, she teams up with bighearted contractor Jake Taylor to fix and flip it.", "https://m.media-amazon.com/images/M/MV5BNWE1NmMzNjUtMDc3NS00ZjBlLTllMTktZTVkMWQzZGVlYzdhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "TV-PG", "29 Aug 2019", "98 min", "Falling Inn Love", "Elizabeth Hackett, Hilary Galanoy", "2019" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "086729d4-a5a5-46ad-ae7f-7439e6f724cb");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "155727bb-39c1-4734-ab48-a05d74756906");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "1e699e33-eaca-449d-b5b0-7174f50ec5d6");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "36100801-5f5b-4795-806e-a5df0b434493");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9b227d7b-c427-4dc5-9f82-77c307f69ac0");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "c75c376c-5fa3-4eff-9b4d-f8281f3a81e7");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "d6575425-bb05-417c-9c90-a42baffb2a31");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "ee2fddbe-ac9b-4e9a-84e4-0c390fa7c3e9");
        }
    }
}
