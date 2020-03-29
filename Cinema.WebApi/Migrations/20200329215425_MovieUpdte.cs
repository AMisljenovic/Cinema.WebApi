using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations
{
    public partial class MovieUpdte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "250e62ef-70f1-4457-8b6d-5cd1825f1a3f");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "7c3b2b57-b4fc-425c-ac5f-d069c420ac5c");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "8967fd39-d728-40ed-a167-2cb93782e629");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "91d36fb2-19fb-43f4-948c-4038685ee63a");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "97629fdc-c820-4712-a289-7be6aad65618");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "a5eb1b8d-8204-405d-b088-ff628d86a5e3");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "cefddc01-1483-46c8-9a03-1443355e7374");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "e930637e-3066-440b-8466-7315ef11174c");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer", "Year" },
                values: new object[,]
                {
                    { "31446c42-fa95-4f38-8b8a-c5830649ca32", "Hrithik Roshan, Tiger Shroff, Vaani Kapoor, Ashutosh Rana", "India", "Action, Thriller", "An Indian soldier is assigned a mission to eliminate his former mentor, who has gone rogue.", "https://m.media-amazon.com/images/M/MV5BNTlmNDMzOWQtYzg4Ny00OWQ0LWFhN2MtNmQ2MDczZGZhNTU5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg", "Not Rated", "02 Oct 2019", "154 min", "War", "Siddharth Anand (screenplay), Siddharth Anand (story), Aditya Chopra (story), Shridhar Raghavan (screenplay), Abbas Tyrewala (dialogue)", "2019" },
                    { "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "Alban Lenoir, Olga Kurylenko, Sébastien Lalanne, David Murgia", "France, Belgium", "Action, Drama, History, War", "In February 1976 in Djibouti, a school bus was taken hostage at the Somali border. The GIGN is sent on the spot. After 30 hours of tension, a rescue operation is organized.", "https://m.media-amazon.com/images/M/MV5BMDZiNDcxYzItN2JhNy00MjgxLTgyNjMtNzdiOWU1Y2MwODYxXkEyXkFqcGdeQXVyNzc0MTgzMzU@._V1_SX300.jpg", "TV-14", "30 Jan 2019", "98 min", "15 Minutes of War", "Ileana Epsztajn (collaboration), Fred Grivois (screenplay), Jérémie Guez (collaboration)", "2019" },
                    { "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "Darcie Lincoln, Peter Cosgrove, Victor Toth, Georgia Wood", "UK", "History", "Ingrid and her siblings are on the run from the Beserkers who have begun invading the villages, taking over, savagely using the residents on a game where they vs a Beserker, and if they win...", "https://m.media-amazon.com/images/M/MV5BYTAwNjg3ZDUtZWYxOS00MGVjLTkyYTYtYjJhOGRhNmQzODRkXkEyXkFqcGdeQXVyMjM4MTU4NjQ@._V1_SX300.jpg", "N/A", "05 Feb 2019", "103 min", "The Viking War", "Suzy Spade", "2019" },
                    { "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "Karra Elejalde, Eduard Fernández, Santi Prego, Luis Bermejo", "Spain, Argentina", "Drama, History, War", "July 18, 1936. Salamanca, Castilla and León (center to Spain). The Spanish army declares in the city the state of war, hoping to extend it to the rest of Spain and improve the unstable ...", "https://m.media-amazon.com/images/M/MV5BOGZjZDgxYTItMDQwYS00MWQ1LTk3ZGEtNjY1MmIwNDk5OWZjXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_SX300.jpg", "N/A", "27 Sep 2019", "107 min", "While at War", "Alejandro Amenábar, Alejandro Hernández", "2019" },
                    { "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "Michael Roark, Trace Adkins, Ali Afshar, Allison Paige", "USA", "Sport", "After surviving an IED explosion in combat overseas, a young soldier with the Army Motorcycle Unit is medically discharged with a broken back and leg. Against all odds he trains to make an ...", "https://m.media-amazon.com/images/M/MV5BNzM0Zjc2OWMtY2NjNS00ZmE4LWEzZTItMWE3NjQ4NmM2YzE2XkEyXkFqcGdeQXVyOTk0Mjc1MDA@._V1_SX300.jpg", "PG-13", "30 Aug 2019", "94 min", "Bennett's War", "Alex Ranarivelo", "2019" },
                    { "9f855797-11d1-4634-b489-1ae58211ee98", "Nia Vardalos, Mike Dopud, Chanelle Peloso, Genea Charpentier", "USA", "Drama", "Stacey Ruth Castor weathered the storm of her first husband's death and managed to find love again with her boss, David. But when David is discovered dead of an apparent suicide, the police...", "https://m.media-amazon.com/images/M/MV5BODA0ZDE1YTYtOTRjYS00OWQ0LWI5NzgtZjg1ZDY5YTc1MmY4XkEyXkFqcGdeQXVyNTM0MDc1ODE@._V1_SX300.jpg", "TV-14", "01 Feb 2020", "N/A", "Poisoned Love: The Stacey Castor Story", "Peter Hunziker, Cynthia Riddle, Michael Vickerman", "2020" },
                    { "22469aab-0419-475e-a64a-ecfc335c7321", "Sven Schelker, Charlotte Heinimann, Daniel Ludwig, Matthew Crowley", "Switzerland, Austria", "Drama", "1984: Searching for an experience that goes deeper than the superficiality of modern civilization, Bruno Manser travels into the jungles of Borneo and finds it with the nomadic Penan tribe....", "https://m.media-amazon.com/images/M/MV5BZWM1NzEyNDAtZDFhNi00NzBhLTg3MWEtN2Y1YjI5YTYzZTM5XkEyXkFqcGdeQXVyNDkzNTM2ODg@._V1_SX300.jpg", "N/A", "26 Sep 2019", "142 min", "Paradise War: The Story of Bruno Manser", "David Clemens, Niklaus Hilber, Patrick Tönz", "2019" },
                    { "26ba6b32-be90-443f-8ba2-890f14551457", "Christina Milian, Adam Demos, Jeffrey Bowyer-Chapman, Anna Jullienne", "USA", "Comedy, Romance", "When city girl Gabriela spontaneously enters a contest and wins a rustic New Zealand inn, she teams up with bighearted contractor Jake Taylor to fix and flip it.", "https://m.media-amazon.com/images/M/MV5BNWE1NmMzNjUtMDc3NS00ZjBlLTllMTktZTVkMWQzZGVlYzdhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "TV-PG", "29 Aug 2019", "98 min", "Falling Inn Love", "Elizabeth Hackett, Hilary Galanoy", "2019" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "13e6d16d-e8a9-4112-a3d0-fda72a846b17");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "164ca3af-4b7f-454f-bd07-9b8d6c3736cc");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "1df1dac8-0b73-486e-b1a0-ded9d9d0849c");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "22469aab-0419-475e-a64a-ecfc335c7321");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "26ba6b32-be90-443f-8ba2-890f14551457");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "31446c42-fa95-4f38-8b8a-c5830649ca32");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "59c58d93-e15b-4d2c-94a2-03e82b82d7c2");

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: "9f855797-11d1-4634-b489-1ae58211ee98");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer", "Year" },
                values: new object[,]
                {
                    { "7c3b2b57-b4fc-425c-ac5f-d069c420ac5c", "Hrithik Roshan, Tiger Shroff, Vaani Kapoor, Ashutosh Rana", "India", "Action, Thriller", "An Indian soldier is assigned a mission to eliminate his former mentor, who has gone rogue.", "https://m.media-amazon.com/images/M/MV5BNTlmNDMzOWQtYzg4Ny00OWQ0LWFhN2MtNmQ2MDczZGZhNTU5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg", "Not Rated", "02 Oct 2019", "154 min", "War", "Siddharth Anand (screenplay), Siddharth Anand (story), Aditya Chopra (story), Shridhar Raghavan (screenplay), Abbas Tyrewala (dialogue)", "2019" },
                    { "8967fd39-d728-40ed-a167-2cb93782e629", "Alban Lenoir, Olga Kurylenko, Sébastien Lalanne, David Murgia", "France, Belgium", "Action, Drama, History, War", "In February 1976 in Djibouti, a school bus was taken hostage at the Somali border. The GIGN is sent on the spot. After 30 hours of tension, a rescue operation is organized.", "https://m.media-amazon.com/images/M/MV5BMDZiNDcxYzItN2JhNy00MjgxLTgyNjMtNzdiOWU1Y2MwODYxXkEyXkFqcGdeQXVyNzc0MTgzMzU@._V1_SX300.jpg", "TV-14", "30 Jan 2019", "98 min", "15 Minutes of War", "Ileana Epsztajn (collaboration), Fred Grivois (screenplay), Jérémie Guez (collaboration)", "2019" },
                    { "e930637e-3066-440b-8466-7315ef11174c", "Darcie Lincoln, Peter Cosgrove, Victor Toth, Georgia Wood", "UK", "History", "Ingrid and her siblings are on the run from the Beserkers who have begun invading the villages, taking over, savagely using the residents on a game where they vs a Beserker, and if they win...", "https://m.media-amazon.com/images/M/MV5BYTAwNjg3ZDUtZWYxOS00MGVjLTkyYTYtYjJhOGRhNmQzODRkXkEyXkFqcGdeQXVyMjM4MTU4NjQ@._V1_SX300.jpg", "N/A", "05 Feb 2019", "103 min", "The Viking War", "Suzy Spade", "2019" },
                    { "97629fdc-c820-4712-a289-7be6aad65618", "Karra Elejalde, Eduard Fernández, Santi Prego, Luis Bermejo", "Spain, Argentina", "Drama, History, War", "July 18, 1936. Salamanca, Castilla and León (center to Spain). The Spanish army declares in the city the state of war, hoping to extend it to the rest of Spain and improve the unstable ...", "https://m.media-amazon.com/images/M/MV5BOGZjZDgxYTItMDQwYS00MWQ1LTk3ZGEtNjY1MmIwNDk5OWZjXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_SX300.jpg", "N/A", "27 Sep 2019", "107 min", "While at War", "Alejandro Amenábar, Alejandro Hernández", "2019" },
                    { "250e62ef-70f1-4457-8b6d-5cd1825f1a3f", "Michael Roark, Trace Adkins, Ali Afshar, Allison Paige", "USA", "Sport", "After surviving an IED explosion in combat overseas, a young soldier with the Army Motorcycle Unit is medically discharged with a broken back and leg. Against all odds he trains to make an ...", "https://m.media-amazon.com/images/M/MV5BNzM0Zjc2OWMtY2NjNS00ZmE4LWEzZTItMWE3NjQ4NmM2YzE2XkEyXkFqcGdeQXVyOTk0Mjc1MDA@._V1_SX300.jpg", "PG-13", "30 Aug 2019", "94 min", "Bennett's War", "Alex Ranarivelo", "2019" },
                    { "cefddc01-1483-46c8-9a03-1443355e7374", "Robert De Niro, Uma Thurman, Christopher Walken, Jane Seymour", "USA", "Comedy, Family", "Upset that he has to share the room he loves with his grandfather, Peter decides to declare war in an attempt to get it back.", "https://m.media-amazon.com/images/M/MV5BZjU0MDRmMjAtZGU2Ny00ODkxLThiMDUtMmI1MDJhNDc5YTZkXkEyXkFqcGdeQXVyMzgxOTMzOTA@._V1_SX300.jpg", "PG", "27 Dec 2018", "141 min", "The War with Grandpa", "Tom J. Astle (screenplay by), Matt Ember (screenplay by), Robert Kimmel Smith (based on the book by)", "2019" },
                    { "91d36fb2-19fb-43f4-948c-4038685ee63a", "Sven Schelker, Charlotte Heinimann, Daniel Ludwig, Matthew Crowley", "Switzerland, Austria", "Drama", "1984: Searching for an experience that goes deeper than the superficiality of modern civilization, Bruno Manser travels into the jungles of Borneo and finds it with the nomadic Penan tribe....", "https://m.media-amazon.com/images/M/MV5BZWM1NzEyNDAtZDFhNi00NzBhLTg3MWEtN2Y1YjI5YTYzZTM5XkEyXkFqcGdeQXVyNDkzNTM2ODg@._V1_SX300.jpg", "N/A", "26 Sep 2019", "142 min", "Paradise War: The Story of Bruno Manser", "David Clemens, Niklaus Hilber, Patrick Tönz", "2019" },
                    { "a5eb1b8d-8204-405d-b088-ff628d86a5e3", "Christina Milian, Adam Demos, Jeffrey Bowyer-Chapman, Anna Jullienne", "USA", "Comedy, Romance", "When city girl Gabriela spontaneously enters a contest and wins a rustic New Zealand inn, she teams up with bighearted contractor Jake Taylor to fix and flip it.", "https://m.media-amazon.com/images/M/MV5BNWE1NmMzNjUtMDc3NS00ZjBlLTllMTktZTVkMWQzZGVlYzdhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "TV-PG", "29 Aug 2019", "98 min", "Falling Inn Love", "Elizabeth Hackett, Hilary Galanoy", "2019" }
                });
        }
    }
}
