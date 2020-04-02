using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations
{
    public partial class movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Year = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Rated = table.Column<string>(nullable: true),
                    Released = table.Column<string>(nullable: true),
                    Runtime = table.Column<string>(nullable: true),
                    Genre = table.Column<string>(nullable: true),
                    Writer = table.Column<string>(nullable: true),
                    Actors = table.Column<string>(nullable: true),
                    Plot = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Poster = table.Column<string>(nullable: true),
                    Playing = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Country", "Genre", "Playing", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer", "Year" },
                values: new object[,]
                {
                    { "31446c42-fa95-4f38-8b8a-c5830649ca32", "Hrithik Roshan, Tiger Shroff, Vaani Kapoor, Ashutosh Rana", "India", "Action, Thriller", true, "An Indian soldier is assigned a mission to eliminate his former mentor, who has gone rogue.", "https://m.media-amazon.com/images/M/MV5BNTlmNDMzOWQtYzg4Ny00OWQ0LWFhN2MtNmQ2MDczZGZhNTU5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg", "Not Rated", "02 Oct 2019", "154 min", "War", "Siddharth Anand (screenplay), Siddharth Anand (story), Aditya Chopra (story), Shridhar Raghavan (screenplay), Abbas Tyrewala (dialogue)", "2019" },
                    { "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "Alban Lenoir, Olga Kurylenko, Sébastien Lalanne, David Murgia", "France, Belgium", "Action, Drama, History, War", true, "In February 1976 in Djibouti, a school bus was taken hostage at the Somali border. The GIGN is sent on the spot. After 30 hours of tension, a rescue operation is organized.", "https://m.media-amazon.com/images/M/MV5BMDZiNDcxYzItN2JhNy00MjgxLTgyNjMtNzdiOWU1Y2MwODYxXkEyXkFqcGdeQXVyNzc0MTgzMzU@._V1_SX300.jpg", "TV-14", "30 Jan 2019", "98 min", "15 Minutes of War", "Ileana Epsztajn (collaboration), Fred Grivois (screenplay), Jérémie Guez (collaboration)", "2019" },
                    { "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "Darcie Lincoln, Peter Cosgrove, Victor Toth, Georgia Wood", "UK", "History", true, "Ingrid and her siblings are on the run from the Beserkers who have begun invading the villages, taking over, savagely using the residents on a game where they vs a Beserker, and if they win...", "https://m.media-amazon.com/images/M/MV5BYTAwNjg3ZDUtZWYxOS00MGVjLTkyYTYtYjJhOGRhNmQzODRkXkEyXkFqcGdeQXVyMjM4MTU4NjQ@._V1_SX300.jpg", "N/A", "05 Feb 2019", "103 min", "The Viking War", "Suzy Spade", "2019" },
                    { "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "Karra Elejalde, Eduard Fernández, Santi Prego, Luis Bermejo", "Spain, Argentina", "Drama, History, War", true, "July 18, 1936. Salamanca, Castilla and León (center to Spain). The Spanish army declares in the city the state of war, hoping to extend it to the rest of Spain and improve the unstable ...", "https://m.media-amazon.com/images/M/MV5BOGZjZDgxYTItMDQwYS00MWQ1LTk3ZGEtNjY1MmIwNDk5OWZjXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_SX300.jpg", "N/A", "27 Sep 2019", "107 min", "While at War", "Alejandro Amenábar, Alejandro Hernández", "2019" },
                    { "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "Michael Roark, Trace Adkins, Ali Afshar, Allison Paige", "USA", "Sport", true, "After surviving an IED explosion in combat overseas, a young soldier with the Army Motorcycle Unit is medically discharged with a broken back and leg. Against all odds he trains to make an ...", "https://m.media-amazon.com/images/M/MV5BNzM0Zjc2OWMtY2NjNS00ZmE4LWEzZTItMWE3NjQ4NmM2YzE2XkEyXkFqcGdeQXVyOTk0Mjc1MDA@._V1_SX300.jpg", "PG-13", "30 Aug 2019", "94 min", "Bennett's War", "Alex Ranarivelo", "2019" },
                    { "69e84aef-f2e8-436c-b235-7563ae1cffa2", "Thomas W. Markle, Meghan Markle, Doria Ragland, Prince Harry", "UK", "Documentary", false, "Thomas Markle details his journey from raising Meghan Markle on his own to his heart attack days before her wedding to Prince Harry, Duke of Sussex. Due to his sudden fame as the father of ...", "https://m.media-amazon.com/images/M/MV5BMzdiMTZmNzYtMGQ0Ni00MGUxLTg4ZWYtZDc4MjBiOTdmZTllXkEyXkFqcGdeQXVyMDkwNTkwNg@@._V1_SX300.jpg", "N/A", "25 Aug 2020", "90 min", "Thomas Markle: My Story", "N/A", "2020" },
                    { "ee79a6c6-c7e6-4ff8-9668-03ebe5134767", "Italia Ricci, Chad Michael Murray, Jack Turner, Aliyah O'Brien", "USA", "Drama, Romance", false, "Ally, a final contestant on a dating show, must face her high school sweetheart when she is chosen for the Hometown Date.", "https://m.media-amazon.com/images/M/MV5BNGVhMTQ5YWYtMjYyOS00OGZiLTg1OGYtN2YyZDIwOGQwYmJiXkEyXkFqcGdeQXVyNjU0NTI0Nw@@._V1_SX300.jpg", "TV-G", "30 Aug 2020", "83 min", "Love in Winterland", "Neal H. Dobrofsky, Tippi Dobrofsky", "2020" },
                    { "5480d3f9-0e58-45bd-927c-95fd06cd2753", "Josh Gilmer, Amber Pauline Magdesyan, Tevy Poe, Kate Durocher", "USA", "Comedy, Drama, Romance", false, "Five interwoven love stories explore the ups and downs of finding love.", "https://m.media-amazon.com/images/M/MV5BMTMxYTg4M2EtMDFjMy00MDI1LThjZGUtNjQwOGJlY2FhNjkwXkEyXkFqcGdeQXVyNDQ2MjQ2Mjk@._V1_SX300.jpg", "N/A", "19 Aug 2020", "88 min", "What Love Looks Like", "Alex Magaña", "2020" },
                    { "251759f9-a3c5-43d3-9734-39a288f2a461", "Meng-Po Fu, Chia-Yen Ko", "Taiwan", "Drama, Romance", false, "Set in 2007, the movie tells of a complicated three-way relationship between a young singer and two people who believe in him.", "https://m.media-amazon.com/images/M/MV5BMTkxZTAwYTctODY3OC00NzdkLTg3ZTUtNThmMjk5ZDAzYjRiXkEyXkFqcGdeQXVyMjk2NDAwMw@@._V1_SX300.jpg", "N/A", "23 Aug 2020", "119 min", "Your Love Song", "N/A", "2020" },
                    { "0fe4656a-4598-4f6f-9e7c-3f9347153a10", "Manny Montana, Nora-Jane Noone, Chris Marquette, Mary Birdsong", "USA", "Comedy, Drama, Romance, Thriller", false, "After his wife's death, Claude struggles to appear normal while living with a Secret.", "https://m.media-amazon.com/images/M/MV5BMTBmYWU0ZGYtNTRjNi00MmJkLTg0OGItNjI5M2Y2ZjY4MzhkXkEyXkFqcGdeQXVyMjM2NzM3Mjc@._V1_SX300.jpg", "N/A", "15 Sep 2020", "103 min", "I Hate the Man in My Basement", "Dustin Cook", "2020" },
                    { "3a1a1424-20d5-469b-b39f-9012da50a71a", "Anne Hathaway, Ben Affleck, Rosie Perez, Willem Dafoe", "USA", "Crime, Drama, Mystery, Thriller", false, "A veteran D.C. journalist loses the thread of her own narrative when a guilt-propelled errand for her father thrusts her from byline to unwitting subject in the very story she's trying to break. Adapted from Joan Didion's namesake novel.", "https://m.media-amazon.com/images/M/MV5BMWI3ODZlNjgtNWM4OC00MDFhLTg2MmYtYjk3M2I0OWJmZmE2XkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_SX300.jpg", "R", "8 Sep 2020", "115 min", "The Last Thing He Wanted", "Marco Villalobos (screenplay by), Dee Rees (screenplay by), Joan Didion (based on the book by)", "2020" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.CreateTable(
                name: "PlayingMovies",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Actors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Released = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Runtime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Writer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayingMovies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PlayingMovies",
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
    }
}
