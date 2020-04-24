using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Movie
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
                    Year = table.Column<string>(maxLength: 4, nullable: false),
                    Title = table.Column<string>(maxLength: 30, nullable: false),
                    Rated = table.Column<string>(maxLength: 10, nullable: false),
                    Released = table.Column<string>(maxLength: 20, nullable: false),
                    Runtime = table.Column<string>(maxLength: 10, nullable: false),
                    Genre = table.Column<string>(maxLength: 40, nullable: false),
                    Director = table.Column<string>(maxLength: 600, nullable: false),
                    Actors = table.Column<string>(maxLength: 600, nullable: false),
                    Plot = table.Column<string>(maxLength: 600, nullable: false),
                    Poster = table.Column<string>(maxLength: 600, nullable: false),
                    Playing = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Director", "Genre", "Playing", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Year" },
                values: new object[,]
                {
                    { "31446c42-fa95-4f38-8b8a-c5830649ca32", "Christina Milian, Adam Demos, Jeffrey Bowyer-Chapman, Anna Jullienne", "Roger Kumble", "Comedy, Romance", true, "When city girl Gabriela spontaneously enters a contest and wins a rustic New Zealand inn, she teams up with bighearted contractor Jake Taylor to fix and flip it.", "https://m.media-amazon.com/images/M/MV5BNWE1NmMzNjUtMDc3NS00ZjBlLTllMTktZTVkMWQzZGVlYzdhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "TV-PG", "29 Aug 2019", "98 min", "Falling Inn Love", "2019" },
                    { "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "Alban Lenoir, Olga Kurylenko, Sébastien Lalanne, David Murgia", "Fred Grivois", "Action, Drama, History, War", true, "In February 1976 in Djibouti, a school bus was taken hostage at the Somali border. The GIGN is sent on the spot. After 30 hours of tension, a rescue operation is organized.", "https://m.media-amazon.com/images/M/MV5BMDZiNDcxYzItN2JhNy00MjgxLTgyNjMtNzdiOWU1Y2MwODYxXkEyXkFqcGdeQXVyNzc0MTgzMzU@._V1_SX300.jpg", "TV-14", "30 Jan 2019", "98 min", "15 Minutes of War", "2019" },
                    { "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "Tom Holland, Samuel L. Jackson, Jake Gyllenhaal, Marisa Tomei", "Jon Watts", "Action, Adventure, Sci-Fi", true, "Following the events of Avengers: Endgame (2019), Spider-Man must step up to take on new threats in a world that has changed forever.", "https://m.media-amazon.com/images/M/MV5BMGZlNTY1ZWUtYTMzNC00ZjUyLWE0MjQtMTMxN2E3ODYxMWVmXkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_SX300.jpg", "PG-13", "02 Jul 2019", "129 min", "Spider-Man: Far from Home", "2019" },
                    { "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "Karra Elejalde, Eduard Fernández, Santi Prego, Luis Bermejo", "Alejandro Amenábar", "Drama, History, War", true, "July 18, 1936. Salamanca, Castilla and León (center to Spain). The Spanish army declares in the city the state of war, hoping to extend it to the rest of Spain and improve the unstable ...", "https://m.media-amazon.com/images/M/MV5BOGZjZDgxYTItMDQwYS00MWQ1LTk3ZGEtNjY1MmIwNDk5OWZjXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_SX300.jpg", "PG-13", "27 Sep 2019", "107 min", "While at War", "2019" },
                    { "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "Michael Roark, Trace Adkins, Ali Afshar, Allison Paige", "Alex Ranarivelo", "Sport", true, "After surviving an IED explosion in combat overseas, a young soldier with the Army Motorcycle Unit is medically discharged with a broken back and leg. Against all odds he trains to make an ...", "https://m.media-amazon.com/images/M/MV5BNzM0Zjc2OWMtY2NjNS00ZmE4LWEzZTItMWE3NjQ4NmM2YzE2XkEyXkFqcGdeQXVyOTk0Mjc1MDA@._V1_SX300.jpg", "PG-13", "30 Aug 2019", "94 min", "Bennett's War", "2019" },
                    { "69e84aef-f2e8-436c-b235-7563ae1cffa2", "Thomas W. Markle, Meghan Markle, Doria Ragland, Prince Harry", "David Modell", "Documentary", false, "Thomas Markle details his journey from raising Meghan Markle on his own to his heart attack days before her wedding to Prince Harry, Duke of Sussex. Due to his sudden fame as the father of ...", "https://m.media-amazon.com/images/M/MV5BMzdiMTZmNzYtMGQ0Ni00MGUxLTg4ZWYtZDc4MjBiOTdmZTllXkEyXkFqcGdeQXVyMDkwNTkwNg@@._V1_SX300.jpg", "PG-13", "25 Aug 2020", "90 min", "Thomas Markle: My Story", "2020" },
                    { "ee79a6c6-c7e6-4ff8-9668-03ebe5134767", "Italia Ricci, Chad Michael Murray, Jack Turner, Aliyah O'Brien", "Pat Williams", "Drama, Romance", false, "Ally, a final contestant on a dating show, must face her high school sweetheart when she is chosen for the Hometown Date.", "https://m.media-amazon.com/images/M/MV5BNGVhMTQ5YWYtMjYyOS00OGZiLTg1OGYtN2YyZDIwOGQwYmJiXkEyXkFqcGdeQXVyNjU0NTI0Nw@@._V1_SX300.jpg", "TV-G", "30 Aug 2020", "83 min", "Love in Winterland", "2020" },
                    { "5480d3f9-0e58-45bd-927c-95fd06cd2753", "Josh Gilmer, Amber Pauline Magdesyan, Tevy Poe, Kate Durocher", "Alex Magaña", "Comedy, Drama, Romance", false, "Five interwoven love stories explore the ups and downs of finding love.", "https://m.media-amazon.com/images/M/MV5BMTMxYTg4M2EtMDFjMy00MDI1LThjZGUtNjQwOGJlY2FhNjkwXkEyXkFqcGdeQXVyNDQ2MjQ2Mjk@._V1_SX300.jpg", "PG-13", "19 Aug 2020", "88 min", "What Love Looks Like", "2020" },
                    { "251759f9-a3c5-43d3-9734-39a288f2a461", "Elizabeth Debicki, Robert Pattinson, Aaron Taylor-Johnson, Kenneth Branagh", "Christopher Nolan", "Action, Drama, Thriller", false, "An action epic revolving around international espionage, time travel, and evolution.", "https://m.media-amazon.com/images/M/MV5BNmMwYzFlNTEtYTc0NC00NGY4LTgzNzItZGFiYTViY2QzNzU1XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg", "R", "17 Jul 2020", "125 min", "Tenet", "2020" },
                    { "0fe4656a-4598-4f6f-9e7c-3f9347153a10", "Manny Montana, Nora-Jane Noone, Chris Marquette, Mary Birdsong", "Dustin Cook", "Comedy, Drama, Romance, Thriller", false, "After his wife's death, Claude struggles to appear normal while living with a Secret.", "https://m.media-amazon.com/images/M/MV5BMTBmYWU0ZGYtNTRjNi00MmJkLTg0OGItNjI5M2Y2ZjY4MzhkXkEyXkFqcGdeQXVyMjM2NzM3Mjc@._V1_SX300.jpg", "PG-13", "15 Sep 2020", "103 min", "I Hate the Man in My Basement", "2020" },
                    { "3a1a1424-20d5-469b-b39f-9012da50a71a", "Anne Hathaway, Ben Affleck, Rosie Perez, Willem Dafoe", "Dee Rees", "Crime, Drama, Mystery, Thriller", false, "A veteran D.C. journalist loses the thread of her own narrative when a guilt-propelled errand for her father thrusts her from byline to unwitting subject in the very story she's trying to break. Adapted from Joan Didion's namesake novel.", "https://m.media-amazon.com/images/M/MV5BMWI3ODZlNjgtNWM4OC00MDFhLTg2MmYtYjk3M2I0OWJmZmE2XkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_SX300.jpg", "R", "8 Sep 2020", "115 min", "The Last Thing He Wanted", "2020" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
