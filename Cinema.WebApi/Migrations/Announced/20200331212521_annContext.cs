using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Announced
{
    public partial class annContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "13e6d16d-e8a9-4112-a3d0-fda72a846b17");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "164ca3af-4b7f-454f-bd07-9b8d6c3736cc");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "1df1dac8-0b73-486e-b1a0-ded9d9d0849c");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "31446c42-fa95-4f38-8b8a-c5830649ca32");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "59c58d93-e15b-4d2c-94a2-03e82b82d7c2");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "9f855797-11d1-4634-b489-1ae58211ee98");

            migrationBuilder.InsertData(
                table: "AnnouncedMovies",
                columns: new[] { "Id", "Actors", "Country", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer", "Year" },
                values: new object[,]
                {
                    { "69e84aef-f2e8-436c-b235-7563ae1cffa2", "Thomas W. Markle, Meghan Markle, Doria Ragland, Prince Harry", "UK", "Documentary", "Thomas Markle details his journey from raising Meghan Markle on his own to his heart attack days before her wedding to Prince Harry, Duke of Sussex. Due to his sudden fame as the father of ...", "https://m.media-amazon.com/images/M/MV5BMzdiMTZmNzYtMGQ0Ni00MGUxLTg4ZWYtZDc4MjBiOTdmZTllXkEyXkFqcGdeQXVyMDkwNTkwNg@@._V1_SX300.jpg", "N/A", "25 Aug 2020", "90 min", "Thomas Markle: My Story", "N/A", "2020" },
                    { "ee79a6c6-c7e6-4ff8-9668-03ebe5134767", "Italia Ricci, Chad Michael Murray, Jack Turner, Aliyah O'Brien", "USA", "Drama, Romance", "Ally, a final contestant on a dating show, must face her high school sweetheart when she is chosen for the Hometown Date.", "https://m.media-amazon.com/images/M/MV5BNGVhMTQ5YWYtMjYyOS00OGZiLTg1OGYtN2YyZDIwOGQwYmJiXkEyXkFqcGdeQXVyNjU0NTI0Nw@@._V1_SX300.jpg", "TV-G", "30 Aug 2020", "83 min", "Love in Winterland", "Neal H. Dobrofsky, Tippi Dobrofsky", "2020" },
                    { "5480d3f9-0e58-45bd-927c-95fd06cd2753", "Josh Gilmer, Amber Pauline Magdesyan, Tevy Poe, Kate Durocher", "USA", "Comedy, Drama, Romance", "Five interwoven love stories explore the ups and downs of finding love.", "https://m.media-amazon.com/images/M/MV5BMTMxYTg4M2EtMDFjMy00MDI1LThjZGUtNjQwOGJlY2FhNjkwXkEyXkFqcGdeQXVyNDQ2MjQ2Mjk@._V1_SX300.jpg", "N/A", "19 Aug 2020", "88 min", "What Love Looks Like", "Alex Magaña", "2020" },
                    { "251759f9-a3c5-43d3-9734-39a288f2a461", "Meng-Po Fu, Chia-Yen Ko", "Taiwan", "Drama, Romance", "Set in 2007, the movie tells of a complicated three-way relationship between a young singer and two people who believe in him.", "https://m.media-amazon.com/images/M/MV5BMTkxZTAwYTctODY3OC00NzdkLTg3ZTUtNThmMjk5ZDAzYjRiXkEyXkFqcGdeQXVyMjk2NDAwMw@@._V1_SX300.jpg", "N/A", "23 Aug 2020", "119 min", "Your Love Song", "N/A", "2020" },
                    { "0fe4656a-4598-4f6f-9e7c-3f9347153a10", "Manny Montana, Nora-Jane Noone, Chris Marquette, Mary Birdsong", "USA", "Comedy, Drama, Romance, Thriller", "After his wife's death, Claude struggles to appear normal while living with a Secret.", "https://m.media-amazon.com/images/M/MV5BMTBmYWU0ZGYtNTRjNi00MmJkLTg0OGItNjI5M2Y2ZjY4MzhkXkEyXkFqcGdeQXVyMjM2NzM3Mjc@._V1_SX300.jpg", "N/A", "15 Sep 2020", "103 min", "I Hate the Man in My Basement", "Dustin Cook", "2020" },
                    { "3a1a1424-20d5-469b-b39f-9012da50a71a", "Anne Hathaway, Ben Affleck, Rosie Perez, Willem Dafoe", "USA", "Crime, Drama, Mystery, Thriller", "A veteran D.C. journalist loses the thread of her own narrative when a guilt-propelled errand for her father thrusts her from byline to unwitting subject in the very story she's trying to break. Adapted from Joan Didion's namesake novel.", "https://m.media-amazon.com/images/M/MV5BMWI3ODZlNjgtNWM4OC00MDFhLTg2MmYtYjk3M2I0OWJmZmE2XkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_SX300.jpg", "R", "8 Sep 2020", "115 min", "The Last Thing He Wanted", "Marco Villalobos (screenplay by), Dee Rees (screenplay by), Joan Didion (based on the book by)", "2020" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "0fe4656a-4598-4f6f-9e7c-3f9347153a10");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "251759f9-a3c5-43d3-9734-39a288f2a461");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "3a1a1424-20d5-469b-b39f-9012da50a71a");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "5480d3f9-0e58-45bd-927c-95fd06cd2753");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "69e84aef-f2e8-436c-b235-7563ae1cffa2");

            migrationBuilder.DeleteData(
                table: "AnnouncedMovies",
                keyColumn: "Id",
                keyValue: "ee79a6c6-c7e6-4ff8-9668-03ebe5134767");

            migrationBuilder.InsertData(
                table: "AnnouncedMovies",
                columns: new[] { "Id", "Actors", "Country", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer", "Year" },
                values: new object[,]
                {
                    { "31446c42-fa95-4f38-8b8a-c5830649ca32", "Thomas W. Markle, Meghan Markle, Doria Ragland, Prince Harry", "UK", "Documentary", "Thomas Markle details his journey from raising Meghan Markle on his own to his heart attack days before her wedding to Prince Harry, Duke of Sussex. Due to his sudden fame as the father of ...", "https://m.media-amazon.com/images/M/MV5BMzdiMTZmNzYtMGQ0Ni00MGUxLTg4ZWYtZDc4MjBiOTdmZTllXkEyXkFqcGdeQXVyMDkwNTkwNg@@._V1_SX300.jpg", "N/A", "25 Aug 2020", "90 min", "Thomas Markle: My Story", "N/A", "2020" },
                    { "59c58d93-e15b-4d2c-94a2-03e82b82d7c2", "Italia Ricci, Chad Michael Murray, Jack Turner, Aliyah O'Brien", "USA", "Drama, Romance", "Ally, a final contestant on a dating show, must face her high school sweetheart when she is chosen for the Hometown Date.", "https://m.media-amazon.com/images/M/MV5BNGVhMTQ5YWYtMjYyOS00OGZiLTg1OGYtN2YyZDIwOGQwYmJiXkEyXkFqcGdeQXVyNjU0NTI0Nw@@._V1_SX300.jpg", "TV-G", "30 Aug 2020", "83 min", "Love in Winterland", "Neal H. Dobrofsky, Tippi Dobrofsky", "2020" },
                    { "164ca3af-4b7f-454f-bd07-9b8d6c3736cc", "Josh Gilmer, Amber Pauline Magdesyan, Tevy Poe, Kate Durocher", "USA", "Comedy, Drama, Romance", "Five interwoven love stories explore the ups and downs of finding love.", "https://m.media-amazon.com/images/M/MV5BMTMxYTg4M2EtMDFjMy00MDI1LThjZGUtNjQwOGJlY2FhNjkwXkEyXkFqcGdeQXVyNDQ2MjQ2Mjk@._V1_SX300.jpg", "N/A", "19 Aug 2020", "88 min", "What Love Looks Like", "Alex Magaña", "2020" },
                    { "13e6d16d-e8a9-4112-a3d0-fda72a846b17", "Meng-Po Fu, Chia-Yen Ko", "Taiwan", "Drama, Romance", "Set in 2007, the movie tells of a complicated three-way relationship between a young singer and two people who believe in him.", "https://m.media-amazon.com/images/M/MV5BMTkxZTAwYTctODY3OC00NzdkLTg3ZTUtNThmMjk5ZDAzYjRiXkEyXkFqcGdeQXVyMjk2NDAwMw@@._V1_SX300.jpg", "N/A", "23 Aug 2020", "119 min", "Your Love Song", "N/A", "2020" },
                    { "1df1dac8-0b73-486e-b1a0-ded9d9d0849c", "Manny Montana, Nora-Jane Noone, Chris Marquette, Mary Birdsong", "USA", "Comedy, Drama, Romance, Thriller", "After his wife's death, Claude struggles to appear normal while living with a Secret.", "https://m.media-amazon.com/images/M/MV5BMTBmYWU0ZGYtNTRjNi00MmJkLTg0OGItNjI5M2Y2ZjY4MzhkXkEyXkFqcGdeQXVyMjM2NzM3Mjc@._V1_SX300.jpg", "N/A", "15 Sep 2020", "103 min", "I Hate the Man in My Basement", "Dustin Cook", "2020" },
                    { "9f855797-11d1-4634-b489-1ae58211ee98", "Anne Hathaway, Ben Affleck, Rosie Perez, Willem Dafoe", "USA", "Crime, Drama, Mystery, Thriller", "A veteran D.C. journalist loses the thread of her own narrative when a guilt-propelled errand for her father thrusts her from byline to unwitting subject in the very story she's trying to break. Adapted from Joan Didion's namesake novel.", "https://m.media-amazon.com/images/M/MV5BMWI3ODZlNjgtNWM4OC00MDFhLTg2MmYtYjk3M2I0OWJmZmE2XkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_SX300.jpg", "R", "8 Sep 2020", "115 min", "The Last Thing He Wanted", "Marco Villalobos (screenplay by), Dee Rees (screenplay by), Joan Didion (based on the book by)", "2020" }
                });
        }
    }
}
