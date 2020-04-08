using Cinema.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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

        public async Task Add(List<Ticket> entities)
        {
            foreach (var entity in entities)
            {
                entity.Id = Guid.NewGuid().ToString();

                _ticketContext.Tickets.Add(entity);
            }
     
            await _ticketContext.SaveChangesAsync();
        }

        public async Task Delete(string repertoryId)
        {
            var ticket = await _ticketContext.Tickets.FirstOrDefaultAsync(t => t.RepertoryId == repertoryId);
            if (ticket != null)
            {
                _ticketContext.Tickets.Remove(ticket);
                await _ticketContext.SaveChangesAsync();
            }

        }

        public async Task<string> GetByRepertory(string repertoryId)
        {
            var tickets = await _ticketContext.Tickets.Where(t => t.RepertoryId == repertoryId).ToListAsync();
            int[,] seats = new int[Constants.HallRows, Constants.HallColumns];

            foreach (var ticket in tickets)
            {
                seats[ticket.SeatRow, ticket.SeatColumn] = 1;
            }

            return JsonConvert.SerializeObject(seats);
        }

        public async Task<string> GetByRepertoryAndUser(string repertoryId, string userId)
        {
            var tickets = await _ticketContext.Tickets.Where(t => t.RepertoryId == repertoryId && t.UserId == userId).ToListAsync();
            int[,] seats = new int[Constants.HallRows, Constants.HallColumns];

            foreach (var ticket in tickets)
            {
                seats[ticket.SeatRow, ticket.SeatColumn] = 1;
            }

            return JsonConvert.SerializeObject(seats);
        }

        public async Task<IEnumerable<Ticket>> GetByUser(string userId)
        {
            return await _ticketContext.Tickets.Where(t => t.UserId == userId).ToListAsync();
        }

        public async Task Update(Ticket entity)
        {
            var ticket = await _ticketContext.Tickets.FirstOrDefaultAsync(t => t.Id == entity.Id);
            if (ticket != null)
            {
                ticket.RepertoryId = entity.RepertoryId;
                ticket.SeatRow = entity.SeatRow;
                ticket.SeatColumn = entity.SeatColumn;
                ticket.UserId = entity.UserId;

                _ticketContext.Tickets.Update(ticket);
                await _ticketContext.SaveChangesAsync();
            }
        }
    }
}
