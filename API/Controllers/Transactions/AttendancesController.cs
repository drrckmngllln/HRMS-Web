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

#region Attendance Functionality
        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<AttendanceIdentityDto>>>
            GetAttendanceIdentityAsync([FromQuery] AttendanceIdentitySpecParameters parameters)
        {
            var spec = new AttendanceIdentitySpecifications(parameters);

            var attendanceIdentity = await _unitOfWork.Repository<AttendanceIdentity>().ListAsync(spec);

            var data = _mapper.Map<IReadOnlyList<AttendanceIdentity>, IReadOnlyList<AttendanceIdentityDto>>(attendanceIdentity);

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


        [HttpGet("{id}")]
        public async Task<ActionResult<AttendanceIdentity>> GetByIdAsync(int id)
        {
            var spec = new AttendanceIdentitySpecifications(id);

            var attendanceIdentity = await _unitOfWork.Repository<AttendanceIdentity>().GetEntityWithSpec(spec);

            var data = _mapper.Map<AttendanceIdentity, AttendanceIdentityDto>(attendanceIdentity);

            return Ok(data);
        }

#endregion

        [HttpGet("EmployeeAttendance")]
        public async Task<ActionResult<IReadOnlyList<AttendanceDto>>> 
            GetEmployeesAttendanceAsync([FromQuery] AttendanceSpecParameters attendanceSpecParameters)
        {
            var spec = new AttendanceWithEmployeeSpecifications(attendanceSpecParameters);

            var attendances = await _unitOfWork.Repository<Attendance>().ListAsync(spec);

            var data = _mapper.Map<IReadOnlyList<Attendance>, IReadOnlyList<AttendanceDto>>(attendances);

            return Ok(data);
        }


        [HttpPost("EmployeeAttendance/create")]
        public async Task<ActionResult<AttendanceDto>> TimeInAsync(AttendanceDto attendanceDto)
        {
            if (!await CheckTimeInExisting(attendanceDto.Date.ToUniversalTime()))
            {
                var item = new Attendance
                {
                    Date = attendanceDto.Date.ToUniversalTime(),
                    TimeIn = attendanceDto.TimeIn,
                    TimeInRemarks = attendanceDto.TimeInRemarks,
                    EmployeeId = await GetEmployeeAsync(attendanceDto.Employee)
                };
                _unitOfWork.Repository<Attendance>().Add(item);
                await _unitOfWork.Complete();
                return Ok("Time in success!");
            }

            return BadRequest("Time in failed");
        } 

        [HttpPut("EmployeeAttendance/update")]
        public async Task<ActionResult<AttendanceDto>> TimeOutAsync(AttendanceDto attendanceDto)
        {
            var item = new Attendance
            {
                Id = attendanceDto.Id,
                Date = attendanceDto.Date.ToUniversalTime(),
                TimeOut = attendanceDto.TimeOut,
                TimeOutRemarks = attendanceDto.TimeOutRemarks,
                EmployeeId = await GetEmployeeAsync(attendanceDto.Employee)
            };
            _unitOfWork.Repository<Attendance>().Update(item);
            await _unitOfWork.Complete();
            return Ok("Time out success");
        }

        private async Task<bool> CheckTimeInExisting(DateTime date)
        {
            var timeIn = await _unitOfWork.Repository<Attendance>().ListAllAsync();
            if (timeIn.Any(x => x.Date == date))
            {
                return true;
            }
            return false;
        }
    }
}