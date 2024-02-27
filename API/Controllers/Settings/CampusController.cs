using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Settings;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Settings
{
    public class CampusController : BaseApiController
    {
        private readonly ISettingsService<Campus> _campusRepo;
        public CampusController(ISettingsService<Campus> campusRepo)
        {
            _campusRepo = campusRepo;
            
        }

        [HttpGet]
        public async Task<IReadOnlyList<Campus>> GetCampusesAsync()
        {
            return await _campusRepo.GetAllAsync();
        }

        [HttpGet("search")]
        public async Task<IReadOnlyList<Campus>> GetCampusesBySearchAsync([FromQuery]string value)
        {
            var entities = await _campusRepo.GetAllAsync();
            var search = entities.Where(x => x.Name.ToLower().Contains(value) || x.Description.ToLower().Contains(value)).ToList();
            return search;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Campus>> CreateCampusAsync(Campus entity)
        {
            var campus = new Campus
            {
                Name = entity.Name,
                Description = entity.Description
            };
            await _campusRepo.AddAsync(campus);

            return Ok(campus);
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
                await _campusRepo.UpdateAsync(campus);
                return Ok(campus);
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Campus>> DeleteCampusAsync(Campus campus)
        {
            var item = new Campus
            {
                Id = campus.Id
            };
            if (item != null)
            {
                await _campusRepo.DeleteAsync(item.Id);
                return Ok(item);
            }

            return BadRequest();
        }
    }
}