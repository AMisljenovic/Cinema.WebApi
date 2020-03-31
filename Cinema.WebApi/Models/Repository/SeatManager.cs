using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public class SeatManager : ISeatRepository<Seat>
    {
        private readonly HallContext _hallContext;

        public SeatManager(HallContext hallContext)
        {
            _hallContext = hallContext;
        }

        public async Task Add(Seat entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _hallContext.Seats.Add(entity);

            await _hallContext.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var seat = _hallContext.Seats.FirstOrDefault(s => s.HallId == id);
            if (seat != null)
            {
                _hallContext.Seats.Remove(seat);
            }

            await _hallContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Seat>> Get(string id)
        {
            return await _hallContext.Seats.Where(s => s.HallId == id).ToListAsync();
        }

        public async Task<IEnumerable<Seat>> GetAll()
        {
            return await _hallContext.Seats.ToListAsync();
        }

        public async Task Update(Seat entity)
        {
            var seat = _hallContext.Seats.FirstOrDefault(s => s.HallId == entity.HallId);
            if (seat != null)
            {
                seat.Reserved = entity.Reserved;

                _hallContext.Seats.Update(seat);
                await _hallContext.SaveChangesAsync();
            }
        }
    }
}
