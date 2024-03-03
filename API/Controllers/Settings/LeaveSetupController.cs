using Core.Entities.Settings;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Settings
{
    public class LeaveSetupController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        public LeaveSetupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<LeaveSetup>>> GetLeaveSetupsAsync([FromQuery] string search)
        {
            var spec = new LeaveSetupSpecifications(search);
            var leaveSetup = await _unitOfWork.Repository<LeaveSetup>().ListAsync(spec);
            return Ok(leaveSetup);
        }

        [HttpPost("create")]
        public async Task<ActionResult<LeaveSetup>> AddLeaveAsync(LeaveSetup leaveSetup)
        {
            _unitOfWork.Repository<LeaveSetup>().Add(leaveSetup);
            await _unitOfWork.Complete();
            return Ok();
        }

        [HttpPut("update")]
        public async Task<ActionResult<LeaveSetup>> UpdateLeaveAsync(LeaveSetup entity)
        {
            _unitOfWork.Repository<LeaveSetup>().Update(entity);
            await _unitOfWork.Complete();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<LeaveSetup>> DeleteAsync(LeaveSetup leaveSetup)
        {
            _unitOfWork.Repository<LeaveSetup>().Delete(leaveSetup);
            await _unitOfWork.Complete();
            return Ok();
        }
    }
}