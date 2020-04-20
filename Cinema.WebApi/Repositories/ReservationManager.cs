using Cinema.WebApi.Configuration;
using Cinema.WebApi.Contexts;
using Cinema.WebApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repositories
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
            var dateNow = DateTime.UtcNow;
            var reservations = new List<Reservation>();

           await _reservationContext.Reservations
                .ForEachAsync(res =>
                {
                    var reservationDate = DateTime.Parse(res.Date);
                    if (res.RepertoryId == repertoryId && (dateNow.Date <= reservationDate.Date))
                    {
                        reservations.Add(res);
                    }
                });

            int[,] seats = new int[Constants.HallRows, Constants.HallColumns];

            foreach (var reservation in reservations)
            {
                seats[reservation.SeatRow, reservation.SeatColumn] = 1;
            }

            return JsonConvert.SerializeObject(seats);
        }

        public async Task<string> GetByRepertoryAndUser(string repertoryId, string userId)
        {
            var dateNow = DateTime.UtcNow;
            var reservations = new List<Reservation>();

            await _reservationContext.Reservations
                 .ForEachAsync(res =>
                 {
                     var reservationDate = DateTime.Parse(res.Date);
                     if (res.RepertoryId == repertoryId && res.UserId == userId && (dateNow.Date <= reservationDate.Date))
                     {
                         reservations.Add(res);
                     }
                 });

            int[,] seats = new int[Constants.HallRows, Constants.HallColumns];

            foreach (var reservation in reservations)
            {
                seats[reservation.SeatRow, reservation.SeatColumn] = 1;
            }

            return JsonConvert.SerializeObject(seats);
        }

        public async Task<IEnumerable<Reservation>> GetByUser(string userId)
        {
            var dateNow = DateTime.UtcNow;
            var reservations = new List<Reservation>();

            await _reservationContext.Reservations
                 .ForEachAsync(res =>
                 {
                     var reservationDate = DateTime.Parse(res.Date);
                     if (res.UserId == userId && (dateNow.Date <= reservationDate.Date))
                     {
                         reservations.Add(res);
                     }
                 });

            return reservations;
        }

        public async Task Update(Reservation entity)
        {
            var reservation = await _reservationContext.Reservations.FirstOrDefaultAsync(t => t.Id == entity.Id);
            if (reservation != null)
            {
                reservation.RepertoryId = entity.RepertoryId;
                reservation.SeatRow = entity.SeatRow;
                reservation.SeatColumn = entity.SeatColumn;
                reservation.UserId = entity.UserId;

                _reservationContext.Reservations.Update(reservation);
                await _reservationContext.SaveChangesAsync();
            }
        }
    }
}
