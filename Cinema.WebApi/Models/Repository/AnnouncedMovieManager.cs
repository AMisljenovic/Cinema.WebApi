using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public class AnnouncedMovieManager : IDataRepository<AnnouncedMovie>
    {
        private readonly AnnouncedContext _movieContext;

        public AnnouncedMovieManager(AnnouncedContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Add(AnnouncedMovie entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _movieContext.AnnouncedMovies.Add(entity);

            await _movieContext.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var dbEntity = _movieContext.AnnouncedMovies.FirstOrDefault(movie => movie.Id == id);
            if (dbEntity != null)
            {
                _movieContext.AnnouncedMovies.Remove(dbEntity);
            }

            await _movieContext.SaveChangesAsync();
        }

        public async Task<AnnouncedMovie> Get(string id)
        {
            return await _movieContext.AnnouncedMovies.FirstOrDefaultAsync(movie => movie.Id == id);
        }

        public async Task<IEnumerable<AnnouncedMovie>> GetAll()
        {
            return await _movieContext.AnnouncedMovies.ToListAsync();
        }

        public async Task Update(AnnouncedMovie entity)
        {
            var dbEntity = _movieContext.AnnouncedMovies.FirstOrDefault(movie => movie.Id == entity.Id);

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

                _movieContext.AnnouncedMovies.Update(dbEntity);
                await _movieContext.SaveChangesAsync();
            }
        }
    }
}
