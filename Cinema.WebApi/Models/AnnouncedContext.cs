using Cinema.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Cinema.WebApi.Models
{
    public class AnnouncedContext : DbContext
    {
        public AnnouncedContext(DbContextOptions<AnnouncedContext> options)
            : base(options)
        {
        }

        public DbSet<AnnouncedMovie> AnnouncedMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var announcedMovies = new List<AnnouncedMovie>(8);
            var movie =  "{\r\n    \"Title\": \"Thomas Markle: My Story\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"N/A\",\r\n    \"Released\": \"25 Aug 2020\",\r\n    \"Runtime\": \"90 min\",\r\n    \"Genre\": \"Documentary\",\r\n    \"Director\": \"David Modell\",\r\n    \"Writer\": \"N/A\",\r\n    \"Actors\": \"Thomas W. Markle, Meghan Markle, Doria Ragland, Prince Harry\",\r\n    \"Plot\": \"Thomas Markle details his journey from raising Meghan Markle on his own to his heart attack days before her wedding to Prince Harry, Duke of Sussex. Due to his sudden fame as the father of ...\",\r\n    \"Country\": \"UK\",\r\n    \"Poster\": \"https://m.media-amazon.com/images/M/MV5BMzdiMTZmNzYtMGQ0Ni00MGUxLTg4ZWYtZDc4MjBiOTdmZTllXkEyXkFqcGdeQXVyMDkwNTkwNg@@._V1_SX300.jpg\"\r\n}";
            var movie1 = "{\r\n    \"Title\": \"Love in Winterland\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"TV-G\",\r\n    \"Released\": \"30 Aug 2020\",\r\n    \"Runtime\": \"83 min\",\r\n    \"Genre\": \"Drama, Romance\",\r\n    \"Director\": \"Pat Williams\",\r\n    \"Writer\": \"Neal H. Dobrofsky, Tippi Dobrofsky\",\r\n    \"Actors\": \"Italia Ricci, Chad Michael Murray, Jack Turner, Aliyah O'Brien\",\r\n    \"Plot\": \"Ally, a final contestant on a dating show, must face her high school sweetheart when she is chosen for the Hometown Date.\",\r\n    \"Country\": \"USA\",\r\n    \"Poster\": \"https://m.media-amazon.com/images/M/MV5BNGVhMTQ5YWYtMjYyOS00OGZiLTg1OGYtN2YyZDIwOGQwYmJiXkEyXkFqcGdeQXVyNjU0NTI0Nw@@._V1_SX300.jpg\"\r\n}";
            var movie2 = "{\r\n    \"Title\": \"What Love Looks Like\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"N/A\",\r\n    \"Released\": \"19 Aug 2020\",\r\n    \"Runtime\": \"88 min\",\r\n    \"Genre\": \"Comedy, Drama, Romance\",\r\n    \"Director\": \"Alex Maga\u00F1a\",\r\n    \"Writer\": \"Alex Maga\u00F1a\",\r\n    \"Actors\": \"Josh Gilmer, Amber Pauline Magdesyan, Tevy Poe, Kate Durocher\",\r\n    \"Plot\": \"Five interwoven love stories explore the ups and downs of finding love.\",\r\n    \"Country\": \"USA\",\r\n    \"Poster\": \"https://m.media-amazon.com/images/M/MV5BMTMxYTg4M2EtMDFjMy00MDI1LThjZGUtNjQwOGJlY2FhNjkwXkEyXkFqcGdeQXVyNDQ2MjQ2Mjk@._V1_SX300.jpg\"\r\n}";
            var movie3 = "{\r\n    \"Title\": \"Your Love Song\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"N/A\",\r\n    \"Released\": \"23 Aug 2020\",\r\n    \"Runtime\": \"119 min\",\r\n    \"Genre\": \"Drama, Romance\",\r\n    \"Director\": \"Andrew Chien\",\r\n    \"Writer\": \"N/A\",\r\n    \"Actors\": \"Meng-Po Fu, Chia-Yen Ko\",\r\n    \"Plot\": \"Set in 2007, the movie tells of a complicated three-way relationship between a young singer and two people who believe in him.\",\r\n    \"Country\": \"Taiwan\",\r\n    \"Poster\": \"https://m.media-amazon.com/images/M/MV5BMTkxZTAwYTctODY3OC00NzdkLTg3ZTUtNThmMjk5ZDAzYjRiXkEyXkFqcGdeQXVyMjk2NDAwMw@@._V1_SX300.jpg\"\r\n}";
            var movie4 = "{\r\n    \"Title\": \"I Hate the Man in My Basement\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"N/A\",\r\n    \"Released\": \"15 Sep 2020\",\r\n    \"Runtime\": \"103 min\",\r\n    \"Genre\": \"Comedy, Drama, Romance, Thriller\",\r\n    \"Director\": \"Dustin Cook\",\r\n    \"Writer\": \"Dustin Cook\",\r\n    \"Actors\": \"Manny Montana, Nora-Jane Noone, Chris Marquette, Mary Birdsong\",\r\n    \"Plot\": \"After his wife's death, Claude struggles to appear normal while living with a Secret.\",\r\n    \"Country\": \"USA\",\r\n    \"Poster\": \"https://m.media-amazon.com/images/M/MV5BMTBmYWU0ZGYtNTRjNi00MmJkLTg0OGItNjI5M2Y2ZjY4MzhkXkEyXkFqcGdeQXVyMjM2NzM3Mjc@._V1_SX300.jpg\"\r\n}";
            var movie5 = "{\r\n    \"Title\": \"The Last Thing He Wanted\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"R\",\r\n    \"Released\": \"8 Sep 2020\",\r\n    \"Runtime\": \"115 min\",\r\n    \"Genre\": \"Crime, Drama, Mystery, Thriller\",\r\n    \"Director\": \"Dee Rees\",\r\n    \"Writer\": \"Marco Villalobos (screenplay by), Dee Rees (screenplay by), Joan Didion (based on the book by)\",\r\n    \"Actors\": \"Anne Hathaway, Ben Affleck, Rosie Perez, Willem Dafoe\",\r\n    \"Plot\": \"A veteran D.C. journalist loses the thread of her own narrative when a guilt-propelled errand for her father thrusts her from byline to unwitting subject in the very story she's trying to break. Adapted from Joan Didion's namesake novel.\",\r\n    \"Country\": \"USA\",\r\n    \"Poster\": \"https://m.media-amazon.com/images/M/MV5BMWI3ODZlNjgtNWM4OC00MDFhLTg2MmYtYjk3M2I0OWJmZmE2XkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_SX300.jpg\"\r\n }";
            var jsonMovies = new string[] { movie, movie1, movie2, movie3, movie4, movie5 };

            for (int i = 0; i < jsonMovies.Length; i++)
            {
                var converted = JsonConvert.DeserializeObject<AnnouncedMovie>(jsonMovies[i]);
                converted.Id = Constants.PlayingMovieIds[i].ToString();
                announcedMovies.Add(converted);
            }

            modelBuilder.Entity<AnnouncedMovie>().HasData(announcedMovies);
        }
    }
}
