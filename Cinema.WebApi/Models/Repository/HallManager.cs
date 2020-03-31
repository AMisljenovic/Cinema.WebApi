using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.WebApi.Models.Repository
{
    public class HallManager : IDataRepository<Hall>
    {
        private readonly HallContext _hallContext;

        public HallManager(HallContext hallContext)
        {
            _hallContext = hallContext;
        }

        public async Task Add(Hall entity)
        {
            entity.Id = Guid.NewGuid().ToString();
            _hallContext.Halls.Add(entity);

            await _hallContext.SaveChangesAsync();
        }

        public async Task Delete(string id)
        {
            var hall = _hallContext.Halls.FirstOrDefault(h => h.Id == id);

            if (hall != null)
            {
                _hallContext.Halls.Remove(hall);
            }

            await _hallContext.SaveChangesAsync();
        }

        public async Task<Hall> Get(string id)
        {
            return await _hallContext.Halls.FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<IEnumerable<Hall>> GetAll()
        {
            return await _hallContext.Halls.ToListAsync();
        }

        public async Task Update(Hall entity)
        {
            var hall = _hallContext.Halls.FirstOrDefault(h => h.Id == entity.Id);

            if (hall != null)
            {
                hall.Name = entity.Name;
                hall.Rows = entity.Rows;
                hall.Columns = entity.Columns;

                _hallContext.Halls.Update(hall);
                await _hallContext.SaveChangesAsync();
            }
        }
    }
}
