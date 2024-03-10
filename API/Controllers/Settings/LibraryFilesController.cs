using System.Formats.Asn1;
using Core.Entities;
using Core.Entities.Settings;
using Core.Interfaces;
using Core.Specifications;
using Core.Specifications.Settings;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Settings
{
    public class LibraryFilesController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public LibraryFilesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("Campuses")]
        public async Task<ActionResult<IReadOnlyList<Campus>>> GetCampusesAsync([FromQuery] string search)
        {
            var spec = new CampusesSpecifications(search);

            return Ok(await _unitOfWork.Repository<Campus>().ListAsync(spec));
        }

        [HttpGet("Campuses/{id}")]
        public async Task<ActionResult<Campus>> GetCampusByIdAsync(int id)
        {
            var spec = new CampusesSpecifications(id);

            return Ok(await _unitOfWork.Repository<Campus>().GetEntityWithSpec(spec));
        }

        [HttpGet("Departments")]
        public async Task<ActionResult<IReadOnlyList<Department>>> GetDepartmentsAsync([FromQuery] string search)
        {
            var spec = new DepartmentsSpecifications(search);

            return Ok(await _unitOfWork.Repository<Department>().ListAsync(spec));
        }

        [HttpGet("Departments/{id}")]
        public async Task<ActionResult<Department>> GetDepartmentAsync(int id)
        {
            var spec = new DepartmentsSpecifications(id);

            return Ok(await _unitOfWork.Repository<Department>().GetEntityWithSpec(spec));
        }

        [HttpGet("Positions")]
        public async Task<ActionResult<IReadOnlyList<Positions>>> GetPositionsAsync([FromQuery] string search)
        {
            var spec = new PositionsSpecifications(search);

            return Ok(await _unitOfWork.Repository<Positions>().ListAsync(spec));
        }
        
        [HttpGet("Positions/{id}")]
        public async Task<ActionResult<Positions>> GetPositionAsync(int id)
        {
            var spec = new PositionsSpecifications(id);

            return Ok(await _unitOfWork.Repository<Positions>().GetEntityWithSpec(spec));
        }

        [HttpGet("LeaveSetups")]
        public async Task<ActionResult<IReadOnlyList<LeaveSetup>>> GetLeaveSetupsAsync([FromQuery] string search)
        {
            var spec = new LeaveSetupSpecifications(search);

            return Ok(await _unitOfWork.Repository<LeaveSetup>().ListAsync(spec));
        }

        [HttpGet("LeaveSetups/{id}")]
        public async Task<ActionResult<LeaveSetup>> GetLeaveSetupAsync(int id)
        {
            var spec = new LeaveSetupSpecifications(id);

            return Ok(await _unitOfWork.Repository<LeaveSetup>().GetEntityWithSpec(spec));
        }

        [HttpGet("AttendanceSetups")]
        public async Task<ActionResult<IReadOnlyList<AttendanceSetup>>> GetAttendanceSetupsAsync([FromQuery] string search)
        {
            return Ok(await _unitOfWork.Repository<AttendanceSetup>().ListAllAsync());
        }

        [HttpGet("AttendanceSetups/{id}")]
        public async Task<ActionResult<AttendanceSetup>> GetAttendanceSetupAsync(int id)
        {
            var spec = new AttendanceSetupSpecification(id);

            return Ok(await _unitOfWork.Repository<AttendanceSetup>().GetEntityWithSpec(spec));
        }

        private async Task AddAsync<T>(T entity) where T : BaseEntity
        {
            _unitOfWork.Repository<T>().Add(entity);
            await _unitOfWork.Complete();
        }

        private async Task UpdateAsync<T>(T entity) where T : BaseEntity
        {
            _unitOfWork.Repository<T>().Update(entity);
            await _unitOfWork.Complete();
        }
        private async Task DeleteAsync<T>(T entity) where T : BaseEntity
        {
            _unitOfWork.Repository<T>().Delete(entity);
            await _unitOfWork.Complete();
        }

        [HttpPost("Campuses/create")]
        public async Task<ActionResult<Campus>> AddCampusesAsync(Campus campus)
        {
            await AddAsync(campus);
            return Ok("Campus saved");
        }

        [HttpPost("Departments/create")]
        public async Task<ActionResult<Department>> AddDepartmentsAsync(Department department)
        {
            await AddAsync(department);
            return Ok("Department saved");
        }

        [HttpPost("LeaveSetups/create")]
        public async Task<ActionResult<LeaveSetup>> AddLeaveSetupsAsync(LeaveSetup leaveSetup)
        {
            await AddAsync(leaveSetup);
            return Ok("Leave setup saved");
        }

        [HttpPost("AttendanceSetups/create")]
        public async Task<ActionResult<AttendanceSetup>> AddAttendanceSetupAsync(AttendanceSetup attendanceSetup)
        {
            await AddAsync(attendanceSetup);
            return Ok("Attendance setup saved");
        }

        [HttpPut("Campuses/update")]
        public async Task<ActionResult<Campus>> UpdateCampusAsync(Campus campus)
        {
            await UpdateAsync(campus);
            return Ok("Campus updated");
        }

        [HttpPut("Departments/update")]
        public async Task<ActionResult<Department>> UpdateDepartmentAsync(Department department)
        {
            await UpdateAsync(department);
            return Ok("Department updated");
        }

        [HttpPut("LeaveSetups/update")]
        public async Task<ActionResult<LeaveSetup>> UpdateLeaveSetupAsync(LeaveSetup leaveSetup)
        {
            await UpdateAsync(leaveSetup);
            return Ok("Leave setup updated");
        }

        [HttpPut("AttendanceSetups/update")]
        public async Task<ActionResult<AttendanceSetup>> UpdateAttendanceSetupAsync(AttendanceSetup attendanceSetup)
        {
            await UpdateAsync(attendanceSetup);
            return Ok("Attendance setup updated");
        }

        [HttpDelete("Campuses/{id}")]
        public async Task<ActionResult<Campus>> DeleteCampusAsync(Campus campus)
        {
            await DeleteAsync(campus);
            return Ok("Campus Deleted");
        }

        [HttpDelete("Departments/{id}")]
        public async Task<ActionResult<Department>> DeleteDepartmentAsync(Department department)
        {
            await DeleteAsync(department);
            return Ok("Department Deleted");
        }

        [HttpDelete("LeaveSetups/{id}")]
        public async Task<ActionResult<LeaveSetup>> DeleteLeaveSetupAsync(LeaveSetup leaveSetup)
        {
            await DeleteAsync(leaveSetup);
            return Ok("Leave setup Deleted");
        }

        [HttpDelete("AttendanceSetups/{id}")]
        public async Task<ActionResult<AttendanceSetup>> DeleteAttendanceSetupAsync(AttendanceSetup attendanceSetup)
        {
            await DeleteAsync(attendanceSetup);
            return Ok("Attendance setup Deleted");
        }
    }
}