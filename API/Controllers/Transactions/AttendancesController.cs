using System.Net.Mail;
using API.Dtos;
using AutoMapper;
using Core.Entities.Transactions.AttendanceEntity;
using Core.Entities.Transactions.EmployeeEntity;
using Core.Interfaces;
using Core.Parameters;
using Core.Specifications;
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
        public async Task<ActionResult<IReadOnlyList<AttendanceDto>>> GetAttendanceAsync([FromQuery] AttendanceSpecParameters specParams)
        {
            var spec = new AttendanceWithEmployeeSpecifications(specParams);

            var attendances = await _unitOfWork.Repository<Attendance>().ListAsync(spec);
            var lists = await _unitOfWork.Repository<Attendance>().ListAllAsync();

            var data = _mapper.Map<IReadOnlyList<AttendanceDto>>(attendances);

            return Ok(lists);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AttendanceDto>> GetByIdAsync(int id)
        {
            var spec = new AttendanceWithEmployeeSpecifications(id);
            var attendances = await _unitOfWork.Repository<Attendance>().ListAsync(spec);
            return Ok(attendances);
        }

        [HttpPost("create")]
        public async Task<ActionResult<AttendanceDto>> CreateAsync(Attendance attendance, int empId)
        {
            var empSpec = new EmployeesWithRelationshipSpecifications(empId);
            var employee = await _unitOfWork.Repository<Employee>().GetEntityWithSpec(empSpec);

            var attendanceNew = new Attendance
            {
                TimeIn = attendance.TimeIn,
                TimeInRemarks = attendance.TimeInRemarks,
                TimeOut = attendance.TimeOut,
                TimeOutRemarks = attendance.TimeOutRemarks,
                EmployeeId = employee.Id
            };

            _unitOfWork.Repository<Attendance>().Add(attendanceNew);
            await _unitOfWork.Complete();

            return Ok(attendanceNew);

        }
    }
}