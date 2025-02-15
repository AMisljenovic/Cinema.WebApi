﻿using Cinema.WebApi.Contexts;
using Cinema.WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repositories
{
    public class RepertoryManager : IRepertoryRepository<Repertory>
    {
        private readonly RepertoryContext _repertoryContext;

        public RepertoryManager(RepertoryContext ticketContext)
        {
            _repertoryContext = ticketContext;
        }

        public async Task<Repertory> Get(string movieId, string hallId)
        {
            return await _repertoryContext.Repertoires.FirstOrDefaultAsync(t => t.MovieId == movieId && t.HallId == hallId);
        }

        public async Task<IEnumerable<Repertory>> GetAll()
        {
            return await _repertoryContext.Repertoires.ToListAsync();
        }

        public async Task Add(Repertory entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _repertoryContext.Repertoires.Add(entity);

           await _repertoryContext.SaveChangesAsync();
        }
      

        public async Task<IEnumerable<Repertory>> GetByMovie(string movieId)
        {
            var reperoitres = await _repertoryContext.Repertoires.Where(t => t.MovieId == movieId).ToListAsync();

            for (int i = 0; i < reperoitres.Count; i++)
            {
                while (DateTime.Parse(reperoitres[i].Date) < DateTime.Now.Date)
                {
                    reperoitres[i].Date = DateTime.Parse(reperoitres[i].Date).Date.AddDays(7).ToShortDateString();
                }
            }

            _repertoryContext.Repertoires.UpdateRange(reperoitres);
            await _repertoryContext.SaveChangesAsync();

            return reperoitres;
        }

        public async Task<Repertory> GetById(string id)
        {
            return await _repertoryContext.Repertoires.FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task Update(Repertory entity)
        {
            var dbEntity = _repertoryContext.Repertoires.FirstOrDefault(ticket => ticket.MovieId == entity.MovieId&& ticket.HallId == entity.HallId);

            if (dbEntity != null)
            {
                dbEntity.HallId = entity.HallId;
                dbEntity.MovieId = entity.MovieId;
                dbEntity.PlayTime = entity.PlayTime;
                dbEntity.Day = entity.Day;

                _repertoryContext.Repertoires.Update(dbEntity);
                await _repertoryContext.SaveChangesAsync();
            }
        }

        public async Task Delete(string movieId, string hallId)
        {
            var ticket = _repertoryContext.Repertoires.FirstOrDefault(t => t.MovieId == movieId && t.HallId == hallId);
            if (ticket != null)
            {
                _repertoryContext.Repertoires.Remove(ticket);
            }

            await _repertoryContext.SaveChangesAsync();
        }
    }
}
