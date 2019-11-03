using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public class CinemaManager : IDataRepository<Movie>
    {
        private readonly MovieContext _movieContext;

        public CinemaManager(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Add(Movie entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _movieContext.Movies.Add(entity);

           await _movieContext.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var dbEntity = _movieContext.Movies.First(movie => movie.Id == id);
            _movieContext.Movies.Remove(dbEntity);

            await _movieContext.SaveChangesAsync();
        }

        public Movie Get(string id)
        {
            return _movieContext.Movies.FirstOrDefault(movie => movie.Id == id);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _movieContext.Movies;
        }

        public async Task Update(Movie entity)
        {
            var dbEntity = _movieContext.Movies.FirstOrDefault(movie => movie.Id == entity.Id);
            
            if (dbEntity != null)
            {
                dbEntity.Plot = entity.Plot;
                dbEntity.Poster = entity.Poster;
                dbEntity.Rated = entity.Rated;
                dbEntity.Released = entity.Released;
                dbEntity.Runtime = entity.Runtime;
                dbEntity.Title = entity.Title;
                dbEntity.Writer = entity.Writer;
                dbEntity.Year = entity.Year;
                dbEntity.Actors = entity.Actors;
                dbEntity.Genre = entity.Genre;

                _movieContext.Movies.Update(dbEntity);
                await _movieContext.SaveChangesAsync();
            }
        }
    }
}
