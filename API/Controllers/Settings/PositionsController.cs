using Core.Entities.Settings;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Settings
{
    public class PositionsController : BaseApiController
    {
        private readonly ISettingsService<Positions> _positionRepo;
        public PositionsController(ISettingsService<Positions> positionRepo)
        {
            _positionRepo = positionRepo;
            
        }
        
        [HttpGet]
        public async Task<IReadOnlyList<Positions>> GetPositionsAsync()
        {
            return await _positionRepo.GetAllAsync();
        }

        [HttpGet("search")]
        public async Task<IReadOnlyList<Positions>> GetPositionsBySearch([FromQuery]string value)
        {
            var positions = await _positionRepo.GetAllAsync();
            var item = positions.Where(x => x.Name.ToLower().Contains(value)).ToList();
            return item;
        }


        [HttpPost("create")]
        public async Task<ActionResult<Positions>> AddPositionAsync(Positions positions)
        {
            var position = new Positions
            {
                Name = positions.Name
            };
            await _positionRepo.AddAsync(position);
            return Ok(position);
        }

        [HttpPut("update")]
        public async Task<ActionResult<Positions>> UpdatePositionsAsync(Positions positions)
        {
            var position = new Positions
            {
                Id = positions.Id,
                Name = positions.Name
            };
            if (position != null)
            {
                await _positionRepo.UpdateAsync(position);

                return Ok(position);
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Positions>> DeletePositionAsync(int id, Positions position)
        {
            var item = new Positions
            {
                Id = position.Id
            };
            if (item != null)
            {
                await _positionRepo.DeleteAsync(id);
                return NoContent();
            }

            return BadRequest();
        }
    }
}