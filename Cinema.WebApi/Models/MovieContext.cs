using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cinema.WebApi.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var movies = new List<Movie>(8);
            var movie = "{\r\n  \"Title\": \"War\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"Not Rated\",\r\n  \"Released\": \"02 Oct 2019\",\r\n  \"Runtime\": \"154 min\",\r\n  \"Genre\": \"Action, Thriller\",\r\n  \"Director\": \"Siddharth Anand\",\r\n  \"Writer\": \"Siddharth Anand (screenplay), Siddharth Anand (story), Aditya Chopra (story), Shridhar Raghavan (screenplay), Abbas Tyrewala (dialogue)\",\r\n  \"Actors\": \"Hrithik Roshan, Tiger Shroff, Vaani Kapoor, Ashutosh Rana\",\r\n  \"Plot\": \"An Indian soldier is assigned a mission to eliminate his former mentor, who has gone rogue.\",\r\n  \"Country\": \"India\",\r\n  \"Poster\": \"https://m.media-amazon.com/images/M/MV5BNTlmNDMzOWQtYzg4Ny00OWQ0LWFhN2MtNmQ2MDczZGZhNTU5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg\"\r\n}";
            var movie1 = "{\r\n  \"Title\": \"15 Minutes of War\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"TV-14\",\r\n  \"Released\": \"30 Jan 2019\",\r\n  \"Runtime\": \"98 min\",\r\n  \"Genre\": \"Action, Drama, History, War\",\r\n  \"Director\": \"Fred Grivois\",\r\n  \"Writer\": \"Ileana Epsztajn (collaboration), Fred Grivois (screenplay), J\u00E9r\u00E9mie Guez (collaboration)\",\r\n  \"Actors\": \"Alban Lenoir, Olga Kurylenko, S\u00E9bastien Lalanne, David Murgia\",\r\n  \"Plot\": \"In February 1976 in Djibouti, a school bus was taken hostage at the Somali border. The GIGN is sent on the spot. After 30 hours of tension, a rescue operation is organized.\",\r\n  \"Language\": \"French, English\",\r\n  \"Country\": \"France, Belgium\",\r\n  \"Poster\": \"https://m.media-amazon.com/images/M/MV5BMDZiNDcxYzItN2JhNy00MjgxLTgyNjMtNzdiOWU1Y2MwODYxXkEyXkFqcGdeQXVyNzc0MTgzMzU@._V1_SX300.jpg\",\r\n}";
            var movie2 = "{\r\n  \"Title\": \"The Viking War\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"N/A\",\r\n  \"Released\": \"05 Feb 2019\",\r\n  \"Runtime\": \"103 min\",\r\n  \"Genre\": \"History\",\r\n  \"Director\": \"Louisa Warren\",\r\n  \"Writer\": \"Suzy Spade\",\r\n  \"Actors\": \"Darcie Lincoln, Peter Cosgrove, Victor Toth, Georgia Wood\",\r\n  \"Plot\": \"Ingrid and her siblings are on the run from the Beserkers who have begun invading the villages, taking over, savagely using the residents on a game where they vs a Beserker, and if they win...\",\r\n  \"Country\": \"UK\",\r\n  \"Poster\": \"https://m.media-amazon.com/images/M/MV5BYTAwNjg3ZDUtZWYxOS00MGVjLTkyYTYtYjJhOGRhNmQzODRkXkEyXkFqcGdeQXVyMjM4MTU4NjQ@._V1_SX300.jpg\"\r\n}";
            var movie3 = "{\r\n  \"Title\": \"While at War\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"N/A\",\r\n  \"Released\": \"27 Sep 2019\",\r\n  \"Runtime\": \"107 min\",\r\n  \"Genre\": \"Drama, History, War\",\r\n  \"Director\": \"Alejandro Amen\u00E1bar\",\r\n  \"Writer\": \"Alejandro Amen\u00E1bar, Alejandro Hern\u00E1ndez\",\r\n  \"Actors\": \"Karra Elejalde, Eduard Fern\u00E1ndez, Santi Prego, Luis Bermejo\",\r\n  \"Plot\": \"July 18, 1936. Salamanca, Castilla and Le\u00F3n (center to Spain). The Spanish army declares in the city the state of war, hoping to extend it to the rest of Spain and improve the unstable ...\",\r\n  \"Country\": \"Spain, Argentina\",\r\n  \"Poster\": \"https://m.media-amazon.com/images/M/MV5BOGZjZDgxYTItMDQwYS00MWQ1LTk3ZGEtNjY1MmIwNDk5OWZjXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_SX300.jpg\"\r\n}";
            var movie4 = "{\r\n  \"Title\": \"Bennett's War\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"PG-13\",\r\n  \"Released\": \"30 Aug 2019\",\r\n  \"Runtime\": \"94 min\",\r\n  \"Genre\": \"Sport\",\r\n  \"Director\": \"Alex Ranarivelo\",\r\n  \"Writer\": \"Alex Ranarivelo\",\r\n  \"Actors\": \"Michael Roark, Trace Adkins, Ali Afshar, Allison Paige\",\r\n  \"Plot\": \"After surviving an IED explosion in combat overseas, a young soldier with the Army Motorcycle Unit is medically discharged with a broken back and leg. Against all odds he trains to make an ...\",\r\n  \"Country\": \"USA\",\r\n  \"Poster\": \"https://m.media-amazon.com/images/M/MV5BNzM0Zjc2OWMtY2NjNS00ZmE4LWEzZTItMWE3NjQ4NmM2YzE2XkEyXkFqcGdeQXVyOTk0Mjc1MDA@._V1_SX300.jpg\"\r\n}";
            var movie5 = "{\r\n  \"Title\": \"The War with Grandpa\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"PG\",\r\n  \"Released\": \"27 Dec 2018\",\r\n  \"Runtime\": \"141 min\",\r\n  \"Genre\": \"Comedy, Family\",\r\n  \"Director\": \"Tim Hill\",\r\n  \"Writer\": \"Tom J. Astle (screenplay by), Matt Ember (screenplay by), Robert Kimmel Smith (based on the book by)\",\r\n  \"Actors\": \"Robert De Niro, Uma Thurman, Christopher Walken, Jane Seymour\",\r\n  \"Plot\": \"Upset that he has to share the room he loves with his grandfather, Peter decides to declare war in an attempt to get it back.\",\r\n  \"Country\": \"USA\",\r\n  \"Poster\": \"https://m.media-amazon.com/images/M/MV5BZjU0MDRmMjAtZGU2Ny00ODkxLThiMDUtMmI1MDJhNDc5YTZkXkEyXkFqcGdeQXVyMzgxOTMzOTA@._V1_SX300.jpg\"\r\n}";
            var movie6 = "{\r\n  \"Title\": \"Paradise War: The Story of Bruno Manser\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"N/A\",\r\n  \"Released\": \"26 Sep 2019\",\r\n  \"Runtime\": \"142 min\",\r\n  \"Genre\": \"Drama\",\r\n  \"Director\": \"Niklaus Hilber\",\r\n  \"Writer\": \"David Clemens, Niklaus Hilber, Patrick T\u00F6nz\",\r\n  \"Actors\": \"Sven Schelker, Charlotte Heinimann, Daniel Ludwig, Matthew Crowley\",\r\n  \"Plot\": \"1984: Searching for an experience that goes deeper than the superficiality of modern civilization, Bruno Manser travels into the jungles of Borneo and finds it with the nomadic Penan tribe....\",\r\n  \"Country\": \"Switzerland, Austria\",\r\n  \"Poster\": \"https://m.media-amazon.com/images/M/MV5BZWM1NzEyNDAtZDFhNi00NzBhLTg3MWEtN2Y1YjI5YTYzZTM5XkEyXkFqcGdeQXVyNDkzNTM2ODg@._V1_SX300.jpg\"\r\n}";
            var movie7 = "{\r\n  \"Title\": \"Falling Inn Love\",\r\n  \"Year\": \"2019\",\r\n  \"Rated\": \"TV-PG\",\r\n  \"Released\": \"29 Aug 2019\",\r\n  \"Runtime\": \"98 min\",\r\n  \"Genre\": \"Comedy, Romance\",\r\n  \"Director\": \"Roger Kumble\",\r\n  \"Writer\": \"Elizabeth Hackett, Hilary Galanoy\",\r\n  \"Actors\": \"Christina Milian, Adam Demos, Jeffrey Bowyer-Chapman, Anna Jullienne\",\r\n  \"Plot\": \"When city girl Gabriela spontaneously enters a contest and wins a rustic New Zealand inn, she teams up with bighearted contractor Jake Taylor to fix and flip it.\",\r\n  \"Country\": \"USA\",\r\n  \"Poster\": \"https://m.media-amazon.com/images/M/MV5BNWE1NmMzNjUtMDc3NS00ZjBlLTllMTktZTVkMWQzZGVlYzdhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_SX300.jpg\"\r\n}";
            var jsonMovies = new string[] { movie, movie1, movie2, movie3, movie4, movie5, movie6, movie7 };

            foreach (var item in jsonMovies)
            {
                var converted = JsonConvert.DeserializeObject<Movie>(item);
                converted.Id = Guid.NewGuid().ToString();
                movies.Add(converted);
            }

            modelBuilder.Entity<Movie>().HasData(movies);
        }
    }
}
