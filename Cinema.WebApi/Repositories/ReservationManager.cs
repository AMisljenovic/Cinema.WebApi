using Cinema.WebApi.Configuration;
using Cinema.WebApi.Contexts;
using Cinema.WebApi.Interfaces;
using Cinema.WebApi.Models.Response;
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
        private readonly RepertoryContext _repertoryContext;
        private readonly MovieContext _movieContext;

        public ReservationManager(ReservationContext ticketContext, 
            RepertoryContext repertoryContext, 
            MovieContext movieContext)
        {
            _reservationContext = ticketContext;
            _repertoryContext = repertoryContext;
            _movieContext = movieContext;
        }

        public IEnumerable<ChartDataResponse> GetChartData()
        {
            var response = new List<ChartDataResponse>();

            var dateNow = DateTime.Now;
            for (int i = 0; i < 7; i++)
            {
                var date = dateNow.Date.AddDays(-i);
                var totalReservations = 0;

                foreach (var reservation in _reservationContext.Reservations)
                {
                    if (date == DateTime.Parse(reservation.Date))
                    {
                        totalReservations++;
                    }
                }

                response.Add(new ChartDataResponse
                {
                    Date = date.ToShortDateString(),
                    ReservationsMade = totalReservations
                });
            }

            return response;
        }

        public async Task<string> GetByRepertory(string repertoryId)
        {
            var dateNow = DateTime.Now;
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
            var dateNow = DateTime.Now;
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

        public async Task<IEnumerable<UserReservationResponse>> GetByUser(string userId)
        {
            var dateNow = DateTime.Now;
            var reservations = new List<UserReservationResponse>();

            await _reservationContext.Reservations
                 .ForEachAsync(res =>
                 {
                     var reservationDate = DateTime.Parse(res.Date);
                     if (res.UserId == userId && (dateNow.Date <= reservationDate.Date))
                     {
                         var repertory = _repertoryContext.Repertoires.First(rep => rep.Id == res.RepertoryId);
                         var movie = _movieContext.Movies.First(m => m.Id == repertory.MovieId);

                         reservations.Add(new UserReservationResponse
                         {
                             ReservationId = res.Id,
                             MovieTitle = movie.Title,
                             DateTime = $"{res.Date} {repertory.PlayTime}",
                             Row = res.SeatRow,
                             Column = res.SeatColumn,
                             Price = repertory.Price
                         });
                     }
                 });

            return reservations;
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

        public async Task Delete(string repertoryId)
        {
            var reservation = await _reservationContext.Reservations.FirstOrDefaultAsync(t => t.RepertoryId == repertoryId);
            if (reservation != null)
            {
                _reservationContext.Reservations.Remove(reservation);
                await _reservationContext.SaveChangesAsync();
            }

        }

        public async Task DeleteByIds(string[] reservationsIds)
        {
            foreach (var reservationId in reservationsIds)
            {
                var reservation = await _reservationContext.Reservations.FirstOrDefaultAsync(t => t.Id == reservationId);
                if (reservation != null)
                {
                    _reservationContext.Reservations.Remove(reservation);
                }
            }

            await _reservationContext.SaveChangesAsync();
        }
    }
}
