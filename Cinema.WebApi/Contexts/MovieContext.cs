﻿using Cinema.WebApi.Configuration;
using Cinema.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Cinema.WebApi.Contexts
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var movies = new List<Movie>(10);
            var movie =  "{\r\n  \"Title\": \"Falling Inn Love\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"TV-PG\",\r\n  \"Released\": \"29 Aug 2019\",\r\n  \"Runtime\": \"98 min\",\r\n  \"Genre\": \"Comedy, Romance\",\r\n  \"Director\": \"Roger Kumble\",\r\n  \"Actors\": \"Christina Milian, Adam Demos, Jeffrey Bowyer-Chapman, Anna Jullienne\",\r\n  \"Plot\": \"When city girl Gabriela spontaneously enters a contest and wins a rustic New Zealand inn, she teams up with bighearted contractor Jake Taylor to fix and flip it.\",\r\n }";
            var movie1 = "{\r\n  \"Title\": \"15 Minutes of War\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"TV-14\",\r\n  \"Released\": \"30 Jan 2019\",\r\n  \"Runtime\": \"98 min\",\r\n  \"Genre\": \"Action, Drama, History, War\",\r\n  \"Director\": \"Fred Grivois\",\r\n  \"Actors\": \"Alban Lenoir, Olga Kurylenko, S\u00E9bastien Lalanne, David Murgia\",\r\n  \"Plot\": \"In February 1976 in Djibouti, a school bus was taken hostage at the Somali border. The GIGN is sent on the spot. After 30 hours of tension, a rescue operation is organized.\",\r\n}";
            var movie2 = "{\r\n  \"Title\": \"Spider-Man: Far from Home\",\r\n    \"Year\": \"2019\",\r\n    \"Rated\": \"PG-13\",\r\n    \"Released\": \"02 Jul 2019\",\r\n    \"Runtime\": \"129 min\",\r\n    \"Genre\": \"Action, Adventure, Sci-Fi\",\r\n    \"Director\": \"Jon Watts\",\r\n    \"Actors\": \"Tom Holland, Samuel L. Jackson, Jake Gyllenhaal, Marisa Tomei\",\r\n    \"Plot\": \"Following the events of Avengers: Endgame (2019), Spider-Man must step up to take on new threats in a world that has changed forever.\",\r\n}";
            var movie3 = "{\r\n  \"Title\": \"While at War\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"PG-13\",\r\n  \"Released\": \"27 Sep 2019\",\r\n  \"Runtime\": \"107 min\",\r\n  \"Genre\": \"Drama, History, War\",\r\n  \"Director\": \"Alejandro Amen\u00E1bar\",\r\n  \"Actors\": \"Karra Elejalde, Eduard Fern\u00E1ndez, Santi Prego, Luis Bermejo\",\r\n  \"Plot\": \"July 18, 1936. Salamanca, Castilla and Le\u00F3n (center to Spain). The Spanish army declares in the city the state of war, hoping to extend it to the rest of Spain and improve the unstable ...\",\r\n}";
            var movie4 = "{\r\n  \"Title\": \"Bennett's War\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"PG-13\",\r\n  \"Released\": \"30 Aug 2019\",\r\n  \"Runtime\": \"94 min\",\r\n  \"Genre\": \"Sport\",\r\n  \"Director\": \"Alex Ranarivelo\",\r\n  \"Actors\": \"Michael Roark, Trace Adkins, Ali Afshar, Allison Paige\",\r\n  \"Plot\": \"After surviving an IED explosion in combat overseas, a young soldier with the Army Motorcycle Unit is medically discharged with a broken back and leg. Against all odds he trains to make an ...\",\r\n}";
            
            var announcedMovie = "{\r\n    \"Title\": \"Thomas Markle: My Story\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"PG-13\",\r\n    \"Released\": \"25 Aug 2020\",\r\n    \"Runtime\": \"90 min\",\r\n    \"Genre\": \"Documentary\",\r\n    \"Director\": \"David Modell\",\r\n    \"Actors\": \"Thomas W. Markle, Meghan Markle, Doria Ragland, Prince Harry\",\r\n    \"Plot\": \"Thomas Markle details his journey from raising Meghan Markle on his own to his heart attack days before her wedding to Prince Harry, Duke of Sussex. Due to his sudden fame as the father of ...\",\r\n }";
            var announcedMovie1 = "{\r\n    \"Title\": \"The Last Thing He Wanted\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"R\",\r\n    \"Released\": \"8 Sep 2020\",\r\n    \"Runtime\": \"115 min\",\r\n    \"Genre\": \"Crime, Drama, Mystery, Thriller\",\r\n    \"Director\": \"Dee Rees\",\r\n    \"Actors\": \"Anne Hathaway, Ben Affleck, Rosie Perez, Willem Dafoe\",\r\n    \"Plot\": \"A veteran D.C. journalist loses the thread of her own narrative when a guilt-propelled errand for her father thrusts her from byline to unwitting subject in the very story she's trying to break. Adapted from Joan Didion's namesake novel.\",\r\n }";
            var announcedMovie2 = "{\r\n    \"Title\": \"What Love Looks Like\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"PG-13\",\r\n    \"Released\": \"19 Aug 2020\",\r\n    \"Runtime\": \"88 min\",\r\n    \"Genre\": \"Comedy, Drama, Romance\",\r\n    \"Director\": \"Alex Maga\u00F1a\",\r\n    \"Actors\": \"Josh Gilmer, Amber Pauline Magdesyan, Tevy Poe, Kate Durocher\",\r\n    \"Plot\": \"Five interwoven love stories explore the ups and downs of finding love.\",\r\n}";
            var announcedMovie3 = "{\r\n    \"Title\": \"Tenet\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"R\",\r\n    \"Released\": \"17 Jul 2020\",\r\n    \"Runtime\": \"125 min\",\r\n    \"Genre\": \"Action, Drama, Thriller\",\r\n    \"Director\": \"Christopher Nolan\",\r\n    \"Actors\": \"Elizabeth Debicki, Robert Pattinson, Aaron Taylor-Johnson, Kenneth Branagh\",\r\n    \"Plot\": \"An action epic revolving around international espionage, time travel, and evolution.\",\r\n}";
            var announcedMovie4 = "{\r\n    \"Title\": \"I Hate the Man in My Basement\",\r\n    \"Year\": \"2020\",\r\n    \"Rated\": \"PG-13\",\r\n    \"Released\": \"15 Sep 2020\",\r\n    \"Runtime\": \"103 min\",\r\n    \"Genre\": \"Comedy, Drama, Romance, Thriller\",\r\n    \"Director\": \"Dustin Cook\",\r\n    \"Actors\": \"Manny Montana, Nora-Jane Noone, Chris Marquette, Mary Birdsong\",\r\n    \"Plot\": \"After his wife's death, Claude struggles to appear normal while living with a Secret.\",\r\n}";

            var jsonMovies = new string[] { movie, movie1, movie2, movie3, movie4, 
                announcedMovie, announcedMovie1, announcedMovie2, announcedMovie3, announcedMovie4 };

            for (int i = 0; i < jsonMovies.Length; i++)
            {
                var converted = JsonConvert.DeserializeObject<Movie>(jsonMovies[i]);
                converted.Id = Constants.PlayingMovieIds[i];
                converted.Playing = i <= 4;
                movies.Add(converted);
            }

            modelBuilder.Entity<Movie>().HasData(movies);
        }
    }
}
