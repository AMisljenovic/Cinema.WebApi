using Cinema.WebApi.Contexts;
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
            return await _repertoryContext.Repertoires.FirstOrDefaultAsync(t => t.MoveId == movieId && t.HallId == hallId);
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
            return await _repertoryContext.Repertoires.Where(t => t.MoveId == movieId).ToListAsync();
        }

        public async Task<Repertory> GetById(string id)
        {
            var repertory = await _repertoryContext.Repertoires.FirstOrDefaultAsync(t => t.Id == id);
            if (repertory != null && (DateTime.Parse(repertory.Date) < DateTime.Now.Date))
            {
                repertory.Date = DateTime.Parse(repertory.Date).AddDays(7).ToShortDateString();
                _repertoryContext.Repertoires.Update(repertory);

                await _repertoryContext.SaveChangesAsync();
            }

            return repertory;
        }

        public async Task Update(Repertory entity)
        {
            var dbEntity = _repertoryContext.Repertoires.FirstOrDefault(ticket => ticket.MoveId == entity.MoveId&& ticket.HallId == entity.HallId);

            if (dbEntity != null)
            {
                dbEntity.HallId = entity.HallId;
                dbEntity.MoveId = entity.MoveId;
                dbEntity.PlayTime = entity.PlayTime;
                dbEntity.Day = entity.Day;

                _repertoryContext.Repertoires.Update(dbEntity);
                await _repertoryContext.SaveChangesAsync();
            }
        }

        public async Task Delete(string movieId, string hallId)
        {
            var ticket = _repertoryContext.Repertoires.FirstOrDefault(t => t.MoveId == movieId && t.HallId == hallId);
            if (ticket != null)
            {
                _repertoryContext.Repertoires.Remove(ticket);
            }

            await _repertoryContext.SaveChangesAsync();
        }
    }
}
