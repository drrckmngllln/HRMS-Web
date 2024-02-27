using Core.Entities.Settings;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Settings
{
    public class LeaveSetupController : BaseApiController
    {
        private readonly ISettingsService<LeaveSetup> _leaveSetupRepo;
        public LeaveSetupController(ISettingsService<LeaveSetup> leaveSetupRepo)
        {
            _leaveSetupRepo = leaveSetupRepo;
        }
        [HttpGet]
        public async Task<IReadOnlyList<LeaveSetup>> GetLeaveSetupsAsync()
        {
            return await _leaveSetupRepo.GetAllAsync();
        }

        [HttpGet("search")]
        public async Task<IReadOnlyList<LeaveSetup>> GetLeaveSetupsBySearchAsync([FromQuery] string value)
        {
            var entities = await _leaveSetupRepo.GetAllAsync();
            var search = entities.Where(x => x.Type.ToLower().Contains(value)).ToList();

            return search;
        }

        [HttpPost("create")]
        public async Task<ActionResult<LeaveSetup>> AddLeaveAsync(LeaveSetup leaveSetup)
        {
            var leave = new LeaveSetup
            {
                Type = leaveSetup.Type,
                Credits = leaveSetup.Credits
            };
            await _leaveSetupRepo.AddAsync(leave);

            return Ok(leave);
        }

        [HttpPut("update")]
        public async Task<ActionResult<LeaveSetup>> UpdateLeaveAsync(LeaveSetup entity)
        {
            var leave = new LeaveSetup
            {
                Id = entity.Id,
                Type = entity.Type,
                Credits = entity.Credits
            };
            if (leave != null)
            {
                await _leaveSetupRepo.UpdateAsync(leave);
                return Ok(leave);
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<LeaveSetup>> DeleteAsync(LeaveSetup leaveSetup)
        {
            var leave = new LeaveSetup{ Id = leaveSetup.Id };        
            if (leave != null)
            {
                await _leaveSetupRepo.DeleteAsync(leave.Id);
                return Ok(leave);
            }

            return BadRequest();
        }
    }
}