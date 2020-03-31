﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public class CinemaManager : IDataRepository<PlayingMovie>
    {
        private readonly PlayingMovieContext _movieContext;

        public CinemaManager(PlayingMovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task Add(PlayingMovie entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _movieContext.PlayingMovies.Add(entity);

           await _movieContext.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var dbEntity = _movieContext.PlayingMovies.FirstOrDefault(movie => movie.Id == id);
            if (dbEntity != null)
            {
                _movieContext.PlayingMovies.Remove(dbEntity);
            }

            await _movieContext.SaveChangesAsync();
        }

        public async Task<PlayingMovie> Get(string id)
        {
            return await _movieContext.PlayingMovies.FirstOrDefaultAsync(movie => movie.Id == id);
        }

        public async Task<IEnumerable<PlayingMovie>> GetAll()
        {
            return await _movieContext.PlayingMovies.ToListAsync();
        }

        public async Task Update(PlayingMovie entity)
        {
            var dbEntity = _movieContext.PlayingMovies.FirstOrDefault(movie => movie.Id == entity.Id);
            
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

                _movieContext.PlayingMovies.Update(dbEntity);
                await _movieContext.SaveChangesAsync();
            }
        }
    }
}
