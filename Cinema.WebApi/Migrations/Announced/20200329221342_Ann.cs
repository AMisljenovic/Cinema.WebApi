﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.WebApi.Migrations.Announced
{
    public partial class Ann : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnnouncedMovies",
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
                    Poster = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncedMovies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AnnouncedMovies",
                columns: new[] { "Id", "Actors", "Country", "Genre", "Plot", "Poster", "Rated", "Released", "Runtime", "Title", "Writer", "Year" },
                values: new object[,]
                {
                    { "b477a88d-7b36-48b2-a572-e44bbdbf1f07", "Thomas W. Markle, Meghan Markle, Doria Ragland, Prince Harry", "UK", "Documentary", "Thomas Markle details his journey from raising Meghan Markle on his own to his heart attack days before her wedding to Prince Harry, Duke of Sussex. Due to his sudden fame as the father of ...", "https://m.media-amazon.com/images/M/MV5BMzdiMTZmNzYtMGQ0Ni00MGUxLTg4ZWYtZDc4MjBiOTdmZTllXkEyXkFqcGdeQXVyMDkwNTkwNg@@._V1_SX300.jpg", "N/A", "25 Aug 2020", "90 min", "Thomas Markle: My Story", "N/A", "2020" },
                    { "d5286ae8-f353-4329-bfaf-cce694ca2821", "Italia Ricci, Chad Michael Murray, Jack Turner, Aliyah O'Brien", "USA", "Drama, Romance", "Ally, a final contestant on a dating show, must face her high school sweetheart when she is chosen for the Hometown Date.", "https://m.media-amazon.com/images/M/MV5BNGVhMTQ5YWYtMjYyOS00OGZiLTg1OGYtN2YyZDIwOGQwYmJiXkEyXkFqcGdeQXVyNjU0NTI0Nw@@._V1_SX300.jpg", "TV-G", "30 Aug 2020", "83 min", "Love in Winterland", "Neal H. Dobrofsky, Tippi Dobrofsky", "2020" },
                    { "f9fcde61-9b73-4219-a2d4-04c3a1351555", "Josh Gilmer, Amber Pauline Magdesyan, Tevy Poe, Kate Durocher", "USA", "Comedy, Drama, Romance", "Five interwoven love stories explore the ups and downs of finding love.", "https://m.media-amazon.com/images/M/MV5BMTMxYTg4M2EtMDFjMy00MDI1LThjZGUtNjQwOGJlY2FhNjkwXkEyXkFqcGdeQXVyNDQ2MjQ2Mjk@._V1_SX300.jpg", "N/A", "19 Aug 2020", "88 min", "What Love Looks Like", "Alex Magaña", "2020" },
                    { "af96153a-76ea-418a-b18a-2b3125aee33d", "Meng-Po Fu, Chia-Yen Ko", "Taiwan", "Drama, Romance", "Set in 2007, the movie tells of a complicated three-way relationship between a young singer and two people who believe in him.", "https://m.media-amazon.com/images/M/MV5BMTkxZTAwYTctODY3OC00NzdkLTg3ZTUtNThmMjk5ZDAzYjRiXkEyXkFqcGdeQXVyMjk2NDAwMw@@._V1_SX300.jpg", "N/A", "23 Aug 2020", "119 min", "Your Love Song", "N/A", "2020" },
                    { "e72edfb2-929e-4849-8624-1dc6bec4cd10", "Manny Montana, Nora-Jane Noone, Chris Marquette, Mary Birdsong", "USA", "Comedy, Drama, Romance, Thriller", "After his wife's death, Claude struggles to appear normal while living with a Secret.", "https://m.media-amazon.com/images/M/MV5BMTBmYWU0ZGYtNTRjNi00MmJkLTg0OGItNjI5M2Y2ZjY4MzhkXkEyXkFqcGdeQXVyMjM2NzM3Mjc@._V1_SX300.jpg", "N/A", "15 Sep 2020", "103 min", "I Hate the Man in My Basement", "Dustin Cook", "2020" },
                    { "f0207c2e-4ad5-40b1-a92e-780a9dacfbae", "Anne Hathaway, Ben Affleck, Rosie Perez, Willem Dafoe", "USA", "Crime, Drama, Mystery, Thriller", "A veteran D.C. journalist loses the thread of her own narrative when a guilt-propelled errand for her father thrusts her from byline to unwitting subject in the very story she's trying to break. Adapted from Joan Didion's namesake novel.", "https://m.media-amazon.com/images/M/MV5BMWI3ODZlNjgtNWM4OC00MDFhLTg2MmYtYjk3M2I0OWJmZmE2XkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_SX300.jpg", "R", "8 Sep 2020", "115 min", "The Last Thing He Wanted", "Marco Villalobos (screenplay by), Dee Rees (screenplay by), Joan Didion (based on the book by)", "2020" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnnouncedMovies");
        }
    }
}
