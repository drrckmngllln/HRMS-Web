using Core.Entities.Settings;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Settings
{
    public class PositionsController : BaseApiController
    {
        private readonly StoreContext _context;
        public PositionsController(StoreContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<IReadOnlyList<Positions>> GetPositionsAsync()
        {
            return await _context.Positions.ToListAsync();
        }

        [HttpPost("create")]
        public async Task<List<Positions>> AddPositionAsync(Positions positions)
        {
            var position = new Positions
            {
                Name = positions.Name
            };
            await _context.Positions.AddAsync(position);
            await _context.SaveChangesAsync();
            return await _context.Positions.ToListAsync();
        }

        [HttpPut("update")]
        public async Task<List<Positions>> UpdatePositionsAsync(Positions positions)
        {
            var position = new Positions
            {
                Id = positions.Id,
                Name = positions.Name
            };
            if (position != null)
            {
                _context.Positions.Update(position);
                await _context.SaveChangesAsync();
                return await _context.Positions.ToListAsync();
            }
            return null;
        }

        [HttpDelete("{id}")]
        public async Task<List<Positions>> DeletePositionAsync(int id)
        {
            var positionId = await _context.Positions.FindAsync(id);
            _context.Positions.Remove(positionId);
            await _context.SaveChangesAsync();

            return await _context.Positions.ToListAsync();
        }
    }
}