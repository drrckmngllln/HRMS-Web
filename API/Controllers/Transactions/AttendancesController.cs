using API.Dtos;
using AutoMapper;
using Core.Entities.Transactions.AttendanceEntity;
using Core.Entities.Transactions.EmployeeEntity;
using Core.Interfaces;
using Core.Parameters;
using Core.Specifications;
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

            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttendanceIdentity>> GetByIdAsync(int id)
        {
            var spec = new AttendanceIdentitySpecifications(id);

            var attendanceIdentity = await _unitOfWork.Repository<AttendanceIdentity>().GetEntityWithSpec(spec);

            var data = _mapper.Map<AttendanceIdentity, AttendanceIdentityDto>(attendanceIdentity);

            return Ok(data);
        }

        [HttpPost("Enroll")]
        public async Task<ActionResult<AttendanceIdentityDto>> EnrollBiometricAsync(AttendanceIdentityDto attendanceIdentityDto)
        {

            var item = new AttendanceIdentity
            {
                EmployeeNumberId = await GetEmployeeAsync(attendanceIdentityDto.EmployeeNumber),
                Data = attendanceIdentityDto.Data
            };

            _unitOfWork.Repository<AttendanceIdentity>().Add(item);
            await _unitOfWork.Complete();
            return Ok("Biometric enrolled");
        }

        private async Task<int> GetEmployeeAsync(int employeeNumber)
        {
            var employee = await _unitOfWork.Repository<Employee>().ListAllAsync();

            var employeeId = employee.SingleOrDefault(x => x.EmployeeNumber == employeeNumber.ToString());

            return employeeId.Id;
        }
    }
}