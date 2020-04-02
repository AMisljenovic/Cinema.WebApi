﻿// <auto-generated />
using Cinema.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cinema.WebApi.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cinema.WebApi.Models.Movie", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Actors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Playing")
                        .HasColumnType("bit");

                    b.Property<string>("Plot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Poster")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Released")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Runtime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Writer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = "31446c42-fa95-4f38-8b8a-c5830649ca32",
                            Actors = "Hrithik Roshan, Tiger Shroff, Vaani Kapoor, Ashutosh Rana",
                            Country = "India",
                            Director = "Siddharth Anand",
                            Genre = "Action, Thriller",
                            Playing = true,
                            Plot = "An Indian soldier is assigned a mission to eliminate his former mentor, who has gone rogue.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNTlmNDMzOWQtYzg4Ny00OWQ0LWFhN2MtNmQ2MDczZGZhNTU5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_SX300.jpg",
                            Rated = "Not Rated",
                            Released = "02 Oct 2019",
                            Runtime = "154 min",
                            Title = "War",
                            Writer = "Siddharth Anand (screenplay), Siddharth Anand (story), Aditya Chopra (story), Shridhar Raghavan (screenplay), Abbas Tyrewala (dialogue)",
                            Year = "2019"
                        },
                        new
                        {
                            Id = "59c58d93-e15b-4d2c-94a2-03e82b82d7c2",
                            Actors = "Alban Lenoir, Olga Kurylenko, Sébastien Lalanne, David Murgia",
                            Country = "France, Belgium",
                            Director = "Fred Grivois",
                            Genre = "Action, Drama, History, War",
                            Playing = true,
                            Plot = "In February 1976 in Djibouti, a school bus was taken hostage at the Somali border. The GIGN is sent on the spot. After 30 hours of tension, a rescue operation is organized.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMDZiNDcxYzItN2JhNy00MjgxLTgyNjMtNzdiOWU1Y2MwODYxXkEyXkFqcGdeQXVyNzc0MTgzMzU@._V1_SX300.jpg",
                            Rated = "TV-14",
                            Released = "30 Jan 2019",
                            Runtime = "98 min",
                            Title = "15 Minutes of War",
                            Writer = "Ileana Epsztajn (collaboration), Fred Grivois (screenplay), Jérémie Guez (collaboration)",
                            Year = "2019"
                        },
                        new
                        {
                            Id = "164ca3af-4b7f-454f-bd07-9b8d6c3736cc",
                            Actors = "Darcie Lincoln, Peter Cosgrove, Victor Toth, Georgia Wood",
                            Country = "UK",
                            Director = "Louisa Warren",
                            Genre = "History",
                            Playing = true,
                            Plot = "Ingrid and her siblings are on the run from the Beserkers who have begun invading the villages, taking over, savagely using the residents on a game where they vs a Beserker, and if they win...",
                            Poster = "https://m.media-amazon.com/images/M/MV5BYTAwNjg3ZDUtZWYxOS00MGVjLTkyYTYtYjJhOGRhNmQzODRkXkEyXkFqcGdeQXVyMjM4MTU4NjQ@._V1_SX300.jpg",
                            Rated = "N/A",
                            Released = "05 Feb 2019",
                            Runtime = "103 min",
                            Title = "The Viking War",
                            Writer = "Suzy Spade",
                            Year = "2019"
                        },
                        new
                        {
                            Id = "13e6d16d-e8a9-4112-a3d0-fda72a846b17",
                            Actors = "Karra Elejalde, Eduard Fernández, Santi Prego, Luis Bermejo",
                            Country = "Spain, Argentina",
                            Director = "Alejandro Amenábar",
                            Genre = "Drama, History, War",
                            Playing = true,
                            Plot = "July 18, 1936. Salamanca, Castilla and León (center to Spain). The Spanish army declares in the city the state of war, hoping to extend it to the rest of Spain and improve the unstable ...",
                            Poster = "https://m.media-amazon.com/images/M/MV5BOGZjZDgxYTItMDQwYS00MWQ1LTk3ZGEtNjY1MmIwNDk5OWZjXkEyXkFqcGdeQXVyMTA0MjU0Ng@@._V1_SX300.jpg",
                            Rated = "N/A",
                            Released = "27 Sep 2019",
                            Runtime = "107 min",
                            Title = "While at War",
                            Writer = "Alejandro Amenábar, Alejandro Hernández",
                            Year = "2019"
                        },
                        new
                        {
                            Id = "1df1dac8-0b73-486e-b1a0-ded9d9d0849c",
                            Actors = "Michael Roark, Trace Adkins, Ali Afshar, Allison Paige",
                            Country = "USA",
                            Director = "Alex Ranarivelo",
                            Genre = "Sport",
                            Playing = true,
                            Plot = "After surviving an IED explosion in combat overseas, a young soldier with the Army Motorcycle Unit is medically discharged with a broken back and leg. Against all odds he trains to make an ...",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNzM0Zjc2OWMtY2NjNS00ZmE4LWEzZTItMWE3NjQ4NmM2YzE2XkEyXkFqcGdeQXVyOTk0Mjc1MDA@._V1_SX300.jpg",
                            Rated = "PG-13",
                            Released = "30 Aug 2019",
                            Runtime = "94 min",
                            Title = "Bennett's War",
                            Writer = "Alex Ranarivelo",
                            Year = "2019"
                        },
                        new
                        {
                            Id = "69e84aef-f2e8-436c-b235-7563ae1cffa2",
                            Actors = "Thomas W. Markle, Meghan Markle, Doria Ragland, Prince Harry",
                            Country = "UK",
                            Director = "David Modell",
                            Genre = "Documentary",
                            Playing = false,
                            Plot = "Thomas Markle details his journey from raising Meghan Markle on his own to his heart attack days before her wedding to Prince Harry, Duke of Sussex. Due to his sudden fame as the father of ...",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMzdiMTZmNzYtMGQ0Ni00MGUxLTg4ZWYtZDc4MjBiOTdmZTllXkEyXkFqcGdeQXVyMDkwNTkwNg@@._V1_SX300.jpg",
                            Rated = "N/A",
                            Released = "25 Aug 2020",
                            Runtime = "90 min",
                            Title = "Thomas Markle: My Story",
                            Writer = "N/A",
                            Year = "2020"
                        },
                        new
                        {
                            Id = "ee79a6c6-c7e6-4ff8-9668-03ebe5134767",
                            Actors = "Italia Ricci, Chad Michael Murray, Jack Turner, Aliyah O'Brien",
                            Country = "USA",
                            Director = "Pat Williams",
                            Genre = "Drama, Romance",
                            Playing = false,
                            Plot = "Ally, a final contestant on a dating show, must face her high school sweetheart when she is chosen for the Hometown Date.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BNGVhMTQ5YWYtMjYyOS00OGZiLTg1OGYtN2YyZDIwOGQwYmJiXkEyXkFqcGdeQXVyNjU0NTI0Nw@@._V1_SX300.jpg",
                            Rated = "TV-G",
                            Released = "30 Aug 2020",
                            Runtime = "83 min",
                            Title = "Love in Winterland",
                            Writer = "Neal H. Dobrofsky, Tippi Dobrofsky",
                            Year = "2020"
                        },
                        new
                        {
                            Id = "5480d3f9-0e58-45bd-927c-95fd06cd2753",
                            Actors = "Josh Gilmer, Amber Pauline Magdesyan, Tevy Poe, Kate Durocher",
                            Country = "USA",
                            Director = "Alex Magaña",
                            Genre = "Comedy, Drama, Romance",
                            Playing = false,
                            Plot = "Five interwoven love stories explore the ups and downs of finding love.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMTMxYTg4M2EtMDFjMy00MDI1LThjZGUtNjQwOGJlY2FhNjkwXkEyXkFqcGdeQXVyNDQ2MjQ2Mjk@._V1_SX300.jpg",
                            Rated = "N/A",
                            Released = "19 Aug 2020",
                            Runtime = "88 min",
                            Title = "What Love Looks Like",
                            Writer = "Alex Magaña",
                            Year = "2020"
                        },
                        new
                        {
                            Id = "251759f9-a3c5-43d3-9734-39a288f2a461",
                            Actors = "Meng-Po Fu, Chia-Yen Ko",
                            Country = "Taiwan",
                            Director = "Andrew Chien",
                            Genre = "Drama, Romance",
                            Playing = false,
                            Plot = "Set in 2007, the movie tells of a complicated three-way relationship between a young singer and two people who believe in him.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMTkxZTAwYTctODY3OC00NzdkLTg3ZTUtNThmMjk5ZDAzYjRiXkEyXkFqcGdeQXVyMjk2NDAwMw@@._V1_SX300.jpg",
                            Rated = "N/A",
                            Released = "23 Aug 2020",
                            Runtime = "119 min",
                            Title = "Your Love Song",
                            Writer = "N/A",
                            Year = "2020"
                        },
                        new
                        {
                            Id = "0fe4656a-4598-4f6f-9e7c-3f9347153a10",
                            Actors = "Manny Montana, Nora-Jane Noone, Chris Marquette, Mary Birdsong",
                            Country = "USA",
                            Director = "Dustin Cook",
                            Genre = "Comedy, Drama, Romance, Thriller",
                            Playing = false,
                            Plot = "After his wife's death, Claude struggles to appear normal while living with a Secret.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMTBmYWU0ZGYtNTRjNi00MmJkLTg0OGItNjI5M2Y2ZjY4MzhkXkEyXkFqcGdeQXVyMjM2NzM3Mjc@._V1_SX300.jpg",
                            Rated = "N/A",
                            Released = "15 Sep 2020",
                            Runtime = "103 min",
                            Title = "I Hate the Man in My Basement",
                            Writer = "Dustin Cook",
                            Year = "2020"
                        },
                        new
                        {
                            Id = "3a1a1424-20d5-469b-b39f-9012da50a71a",
                            Actors = "Anne Hathaway, Ben Affleck, Rosie Perez, Willem Dafoe",
                            Country = "USA",
                            Director = "Dee Rees",
                            Genre = "Crime, Drama, Mystery, Thriller",
                            Playing = false,
                            Plot = "A veteran D.C. journalist loses the thread of her own narrative when a guilt-propelled errand for her father thrusts her from byline to unwitting subject in the very story she's trying to break. Adapted from Joan Didion's namesake novel.",
                            Poster = "https://m.media-amazon.com/images/M/MV5BMWI3ODZlNjgtNWM4OC00MDFhLTg2MmYtYjk3M2I0OWJmZmE2XkEyXkFqcGdeQXVyODkzNTgxMDg@._V1_SX300.jpg",
                            Rated = "R",
                            Released = "8 Sep 2020",
                            Runtime = "115 min",
                            Title = "The Last Thing He Wanted",
                            Writer = "Marco Villalobos (screenplay by), Dee Rees (screenplay by), Joan Didion (based on the book by)",
                            Year = "2020"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
