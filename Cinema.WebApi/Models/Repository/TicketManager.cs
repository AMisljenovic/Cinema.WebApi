using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public class TicketManager : ITicketRepository<Ticket>
    {
        private readonly TicketContext _ticketContext;

        public TicketManager(TicketContext ticketContext)
        {
            _ticketContext = ticketContext;
        }

        public async Task Add(Ticket entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _ticketContext.Tickets.Add(entity);

           await _ticketContext.SaveChangesAsync();
        }

        public async Task Delete(string movieId, string hallId)
        {
            var ticket = _ticketContext.Tickets.FirstOrDefault(t => t.MoveId == movieId && t.HallId == hallId);
            if (ticket != null)
            {
                _ticketContext.Tickets.Remove(ticket);
            }

            await _ticketContext.SaveChangesAsync();
        }

        public async Task<Ticket> Get(string movieId, string hallId)
        {
            return await _ticketContext.Tickets.FirstOrDefaultAsync(t => t.MoveId == movieId && t.HallId == hallId);
        }

        public async Task<IEnumerable<Ticket>> GetAll()
        {
           return await _ticketContext.Tickets.ToListAsync();
        }

        public async Task Update(Ticket entity)
        {
            var dbEntity = _ticketContext.Tickets.FirstOrDefault(ticket => ticket.MoveId == entity.MoveId&& ticket.HallId == entity.HallId);

            if (dbEntity != null)
            {
                dbEntity.HallId = entity.HallId;
                dbEntity.MoveId = entity.MoveId;
                dbEntity.PlayTime = entity.PlayTime;
                dbEntity.Day = entity.Day;

                _ticketContext.Tickets.Update(dbEntity);
                await _ticketContext.SaveChangesAsync();
            }
        }
    }
}
