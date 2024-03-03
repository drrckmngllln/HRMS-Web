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
    public class AttendanceSetupController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public AttendanceSetupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IReadOnlyList<AttendanceSetup>> GetAttendanceSetupsAsync()
        {
            return await _unitOfWork.Repository<AttendanceSetup>().ListAllAsync();
        }

        [HttpPost("create")]
        public async Task<ActionResult<AttendanceSetup>> AddAsync(AttendanceSetup entity)
        {
            _unitOfWork.Repository<AttendanceSetup>().Add(entity);
            await _unitOfWork.Complete();
            return NoContent();
        }

        [HttpPut("update")]
        public async Task<ActionResult<AttendanceSetup>> UpdateAsync(AttendanceSetup entity)
        {
            _unitOfWork.Repository<AttendanceSetup>().Add(entity);
            await _unitOfWork.Complete();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AttendanceSetup>> DeleteAsync(AttendanceSetup entity)
        {
            _unitOfWork.Repository<AttendanceSetup>().Delete(entity);
            await _unitOfWork.Complete();
            return NoContent();
        }
    }
}