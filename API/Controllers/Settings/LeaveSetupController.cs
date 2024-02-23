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
    public class LeaveSetupController : BaseApiController
    {
        private readonly StoreContext _context;
        public LeaveSetupController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IReadOnlyList<LeaveSetup>> GetLeaveSetupsAsync()
        {
            return await _context.LeaveSetups.ToListAsync();
        }

        [HttpPost("create")]
        public async Task<ActionResult<LeaveSetup>> AddLeaveAsync(LeaveSetup leaveSetup)
        {
            var leave = new LeaveSetup
            {
                Type = leaveSetup.Type,
                Credits = leaveSetup.Credits
            };
            await _context.LeaveSetups.AddAsync(leave);
            await _context.SaveChangesAsync();

            return new LeaveSetup
            {
                Type = leave.Type,
                Credits = leave.Credits
            };
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
                _context.LeaveSetups.Update(leave);
                await _context.SaveChangesAsync();
                return new LeaveSetup
                {
                    Id = leave.Id,
                    Type = leave.Type,
                    Credits = leave.Credits
                };
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<LeaveSetup>> DeleteAsync(int id)
        {
            var leave = await _context.LeaveSetups.FindAsync(id);
            if (leave != null)
            {
                _context.LeaveSetups.Remove(leave);
                await _context.SaveChangesAsync();

                return new LeaveSetup
                {
                    Type = leave.Type,
                    Credits = leave.Credits
                };
            }

            return BadRequest();
        }
    }
}