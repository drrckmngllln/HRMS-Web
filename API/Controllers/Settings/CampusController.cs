using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Settings;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Settings
{
    public class CampusController : BaseApiController
    {
        private readonly StoreContext _context;
        public CampusController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IReadOnlyList<Campus>> GetCampusesAsync()
        {
            return await _context.Campuses.ToListAsync();
        }

        [HttpPost("create")]
        public async Task<ActionResult<Campus>> CreateCampusAsync(Campus entity)
        {
            var campus = new Campus
            {
                Name = entity.Name,
                Description = entity.Description
            };
            await _context.Campuses.AddAsync(campus);
            await _context.SaveChangesAsync();

            return new Campus
            {
                Name = campus.Name,
                Description = campus.Description
            };
        }

        [HttpPut("update")]
        public async Task<ActionResult<Campus>> UpdateCampusAsync(Campus entity)
        {
            var campus = new Campus
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
            };

            if (campus != null)
            {
                _context.Campuses.Update(campus);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Campus>> DeleteCampusAsync(int id)
        {
            var campus = await _context.Campuses.FindAsync(id);
            if (campus != null)
            {
                _context.Campuses.Remove(campus);
                await _context.SaveChangesAsync();

                return new Campus
                {
                    Name = campus.Name,
                    Description = campus.Description
                };
            }

            return BadRequest();
        }
    }
}