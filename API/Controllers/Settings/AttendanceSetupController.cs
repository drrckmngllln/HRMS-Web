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
    public class AttendanceSetupController : BaseApiController
    {
        private readonly StoreContext _context;
        public AttendanceSetupController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IReadOnlyList<AttendanceSetup>> GetAttendanceSetupsAsync()
        {
            return await _context.AttendanceSetups.ToListAsync();
        }

        [HttpPost("create")]
        public async Task<ActionResult<AttendanceSetup>> AddAsync(AttendanceSetup entity)
        {
            var attendance = new AttendanceSetup
            {
                TimeIn = entity.TimeIn,
                TimeOut = entity.TimeOut,
                GracePeriod = entity.GracePeriod
            };
            await _context.AttendanceSetups.AddAsync(attendance);
            await _context.SaveChangesAsync();

            return new AttendanceSetup
            {
                Id = attendance.Id,
                TimeIn = attendance.TimeIn,
                TimeOut = attendance.TimeOut,
                GracePeriod = attendance.GracePeriod
            };
        }

        [HttpPut("update")]
        public async Task<ActionResult<AttendanceSetup>> UpdateAsync(AttendanceSetup entity)
        {
            var attendance = new AttendanceSetup
            {
                Id = entity.Id,
                TimeIn = entity.TimeIn,
                TimeOut = entity.TimeOut,
                GracePeriod = entity.GracePeriod
            };
            
            if (attendance != null)
            {
                _context.AttendanceSetups.Update(attendance);
                await _context.SaveChangesAsync();

                return new AttendanceSetup
                {
                    Id = attendance.Id,
                    TimeIn = attendance.TimeIn,
                    TimeOut = attendance.TimeOut,
                    GracePeriod = attendance.GracePeriod
                };
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AttendanceSetup>> DeleteAsync(int id)
        {
            var attendance = await _context.AttendanceSetups.FindAsync(id);
            if (attendance != null)
            {
                _context.AttendanceSetups.Remove(attendance);
                await _context.SaveChangesAsync();

                return new AttendanceSetup
                {
                    Id = attendance.Id,
                    TimeIn = attendance.TimeIn,
                    TimeOut = attendance.TimeOut,
                    GracePeriod = attendance.GracePeriod
                };
            }

            return BadRequest();
        }
    }
}