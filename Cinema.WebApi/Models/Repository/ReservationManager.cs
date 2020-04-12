using Cinema.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public class ReservationManager : IReservationRepository<Reservation>
    {
        private readonly ReservationContext _reservationContext;

        public ReservationManager(ReservationContext ticketContext)
        {
            _reservationContext = ticketContext;
        }

        public async Task Add(List<Reservation> entities)
        {
            foreach (var entity in entities)
            {
                entity.Id = Guid.NewGuid().ToString();

                _reservationContext.Reservations.Add(entity);
            }
     
            await _reservationContext.SaveChangesAsync();
        }

        public async Task Delete(string repertoryId)
        {
            var ticket = await _reservationContext.Reservations.FirstOrDefaultAsync(t => t.RepertoryId == repertoryId);
            if (ticket != null)
            {
                _reservationContext.Reservations.Remove(ticket);
                await _reservationContext.SaveChangesAsync();
            }

        }

        public async Task<string> GetByRepertory(string repertoryId)
        {
            var tickets = await _reservationContext.Reservations.Where(t => t.RepertoryId == repertoryId).ToListAsync();
            int[,] seats = new int[Constants.HallRows, Constants.HallColumns];

            foreach (var ticket in tickets)
            {
                seats[ticket.SeatRow, ticket.SeatColumn] = 1;
            }

            return JsonConvert.SerializeObject(seats);
        }

        public async Task<string> GetByRepertoryAndUser(string repertoryId, string userId)
        {
            var tickets = await _reservationContext.Reservations.Where(t => t.RepertoryId == repertoryId && t.UserId == userId).ToListAsync();
            int[,] seats = new int[Constants.HallRows, Constants.HallColumns];

            foreach (var ticket in tickets)
            {
                seats[ticket.SeatRow, ticket.SeatColumn] = 1;
            }

            return JsonConvert.SerializeObject(seats);
        }

        public async Task<IEnumerable<Reservation>> GetByUser(string userId)
        {
            return await _reservationContext.Reservations.Where(t => t.UserId == userId).ToListAsync();
        }

        public async Task Update(Reservation entity)
        {
            var ticket = await _reservationContext.Reservations.FirstOrDefaultAsync(t => t.Id == entity.Id);
            if (ticket != null)
            {
                ticket.RepertoryId = entity.RepertoryId;
                ticket.SeatRow = entity.SeatRow;
                ticket.SeatColumn = entity.SeatColumn;
                ticket.UserId = entity.UserId;

                _reservationContext.Reservations.Update(ticket);
                await _reservationContext.SaveChangesAsync();
            }
        }
    }
}
