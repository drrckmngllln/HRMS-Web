using API.Dtos;
using AutoMapper;
using Core.Entities.Transactions.AttendanceEntity;
using Core.Interfaces;
using Core.Parameters;
using Core.Specifications.Transactions;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Transactions
{
    public class AttendancesController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AttendancesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AttendanceIdentity>>>
            GetAttendanceIdentityAsync([FromQuery] AttendanceIdentitySpecParameters parameters)
        {
            var spec = new AttendanceIdentitySpecifications(parameters);

            var attendanceIdentity = await _unitOfWork.Repository<AttendanceIdentity>().ListAsync(spec);

            var data = _mapper.Map<IReadOnlyList<AttendanceIdentity>, IReadOnlyList<AttendanceIdentityDto>>(attendanceIdentity);

            return Ok(attendanceIdentity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttendanceIdentity>> GetByIdAsync(int id)
        {
            var spec = new AttendanceIdentitySpecifications(id);

            var attendanceIdentity = await _unitOfWork.Repository<AttendanceIdentity>().GetEntityWithSpec(spec);

            return Ok(attendanceIdentity);
        }

        [HttpPost("Enroll")]
        public async Task<ActionResult> EnrollBiometricAsync(AttendanceIdentity attendanceIdentity)
        {
            _unitOfWork.Repository<AttendanceIdentity>().Add(attendanceIdentity);
            await _unitOfWork.Complete();
            return Ok("Employee biometric enrolled");
        }
    }
}