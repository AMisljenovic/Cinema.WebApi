﻿using Cinema.WebApi.Contexts;
using Cinema.WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repositories
{
    public class MovieManager : IDataRepository<Movie>
    {
        private readonly MovieContext _movieContext;

        public MovieManager(MovieContext movieContext)
        {
            _movieContext = movieContext;
        }

        public async Task<Movie> Get(string id)
        {
            return await _movieContext.Movies.FirstOrDefaultAsync(movie => movie.Id == id);
        }

        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _movieContext.Movies.ToListAsync();
        }

        public async Task Add(Movie entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _movieContext.Movies.Add(entity);

           await _movieContext.SaveChangesAsync();
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
                dbEntity.Director = entity.Director;
                dbEntity.Year = entity.Year;
                dbEntity.Actors = entity.Actors;
                dbEntity.Genre = entity.Genre;
                dbEntity.Playing = entity.Playing;

                _movieContext.Movies.Update(dbEntity);
                await _movieContext.SaveChangesAsync();
            }
        }

        public async Task Delete(string id)
        {
            var dbEntity = _movieContext.Movies.FirstOrDefault(movie => movie.Id == id);
            if (dbEntity != null)
            {
                _movieContext.Movies.Remove(dbEntity);
            }

            await _movieContext.SaveChangesAsync();
        }
    }
}
