using System.Formats.Asn1;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Entities.Settings;
using Core.Interfaces;
using Core.Parameters.SettingsParams;
using Core.Specifications;
using Core.Specifications.Settings;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Settings
{
    public class LibraryFilesController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LibraryFilesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
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
        public async Task<ActionResult<IReadOnlyList<AttendanceSetupDto>>> GetAttendanceSetupsAsync([FromQuery] AttendanceSetupSpecParams parameter)
        {
            var spec = new AttendanceSetupSpecification(parameter);

            var attendanceSetup = await _unitOfWork.Repository<AttendanceSetup>().ListAsync(spec);

            var data = _mapper.Map<IReadOnlyList<AttendanceSetup>, IReadOnlyList<AttendanceSetupDto>>(attendanceSetup);
            
            return Ok(data);
        }

        [HttpGet("AttendanceSetups/{id}")]
        public async Task<ActionResult<AttendanceSetup>> GetAttendanceSetupAsync(int id)
        {
            var spec = new AttendanceSetupSpecification(id);

            return Ok(await _unitOfWork.Repository<AttendanceSetup>().GetEntityWithSpec(spec));
        }

        [HttpGet("AttendanceCategory")]
        public async Task<ActionResult<IReadOnlyList<AttendanceSetupCategory>>> GetAttendanceCategoryAsync([FromQuery] string search)
        {
            var spec = new AttendanceCategorySpecifications(search);

            var attendanceCategory = await _unitOfWork.Repository<AttendanceSetupCategory>().ListAsync(spec);

            return Ok(attendanceCategory);
        }

        [HttpGet("AttendanceCategory/{id}")]
        public async Task<ActionResult<AttendanceSetupCategory>> GetByIdAsync(int id)
        {
            var spec = new AttendanceCategorySpecifications(id);

            var attendanceCategory = await _unitOfWork.Repository<AttendanceSetupCategory>().GetEntityWithSpec(spec);

            return Ok(attendanceCategory);
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
            var checkExisting = await _unitOfWork.Repository<Campus>().ListAllAsync();
            if (checkExisting.Any(x => x.Name == campus.Name))
            {
                return BadRequest("Campus Already Exist");
            }
            await AddAsync(campus);
            return Ok("Campus saved");
        }

        [HttpPost("Departments/create")]
        public async Task<ActionResult<Department>> AddDepartmentsAsync(Department department)
        {
            var checkExisting = await _unitOfWork.Repository<Department>().ListAllAsync();
            if (checkExisting.Any(x => x.Name == department.Name))
            {
                return BadRequest("Department already exist");
            }
            await AddAsync(department);
            return Ok("Department saved");
        }

        [HttpPost("Positions/create")]
        public async Task<ActionResult<Positions>> AddPositionsAsync(Positions positions)
        {
            var checkExisting = await _unitOfWork.Repository<Department>().ListAllAsync();
            if (checkExisting.Any(x => x.Name == positions.Name))
            {
                return BadRequest("Position already exists");
            }
            await AddAsync(positions);
            return Ok("Position Saved");
        }

        [HttpPost("LeaveSetups/create")]
        public async Task<ActionResult<LeaveSetup>> AddLeaveSetupsAsync(LeaveSetup leaveSetup)
        {
            var checkExisting = await _unitOfWork.Repository<LeaveSetup>().ListAllAsync();
            if (checkExisting.Any(x => x.Type == leaveSetup.Type))
            {
                return BadRequest("Leave setup already exist");
            }
            await AddAsync(leaveSetup);
            return Ok("Leave setup saved");
        }

        [HttpPost("AttendanceSetups/create")]
        public async Task<ActionResult<AttendanceSetup>> AddAttendanceSetupAsync(AttendanceSetupDto attendanceSetupDto)
        {
            var checkExisting = await _unitOfWork.Repository<AttendanceSetup>().ListAllAsync();
            if (checkExisting.Any(x => x.CategoryId == Convert.ToInt32(attendanceSetupDto.Category)))
            {
                return BadRequest("Attendance setup already exists");
            }
            var item = new AttendanceSetup
            {
                CategoryId = Convert.ToInt32(attendanceSetupDto.Category),
                TimeIn = attendanceSetupDto.TimeIn.ToUniversalTime(),
                TimeOut = attendanceSetupDto.TimeOut.ToUniversalTime(),
                GracePeriod = attendanceSetupDto.GracePeriod
            };
            await AddAsync(item);
            return Ok("Attendance setup saved");
        }

        private async Task<int> GetCategoryAsync(string category)
        {
            var categories = await _unitOfWork.Repository<AttendanceSetup>().ListAllAsync();
            var categoryId = categories.SingleOrDefault(x => x.CategoryId == Convert.ToInt32(category));
            return categoryId.Id;
        }

        [HttpPost("AttendanceCategory/create")]
        public async Task<ActionResult<AttendanceSetupCategory>> AddAttendanceSetupCategoryAsync(AttendanceSetupCategory attendanceSetupCategory)
        {
            var checkExisting = await _unitOfWork.Repository<AttendanceSetupCategory>().ListAllAsync();
            if (checkExisting.Any(x => x.Name == attendanceSetupCategory.Name))
            {
                return BadRequest("Category already exist");
            }

            await AddAsync(attendanceSetupCategory);
            return Ok("Attendance setup category saved");
        }

        [HttpPut("Campuses/update")]
        public async Task<ActionResult<Campus>> UpdateCampusAsync(Campus campus)
        {
            await UpdateAsync(campus);
            return Ok("Campus updated");
        }

        [HttpPut("AttendanceCategory/update")]
        public async Task<ActionResult<AttendanceSetupCategory>> UpdateAttendanceSetupCategoryAsync(AttendanceSetupCategory attendanceSetupCategory)
        {
            await UpdateAsync(attendanceSetupCategory);
            return Ok("Attendance setup category updated");
        }

        [HttpPut("Departments/update")]
        public async Task<ActionResult<Department>> UpdateDepartmentAsync(Department department)
        {
            await UpdateAsync(department);
            return Ok("Department updated");
        }

        [HttpPut("Positions/update")]
        public async Task<ActionResult<Positions>> UpdatePositionAsync(Positions positions)
        {
            await UpdateAsync(positions);
            return Ok("Position Updated");
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

        [HttpDelete("AttendanceCategory/{id}")]
        public async Task<ActionResult<AttendanceSetupCategory>> DeleteAttendanceCategoryAsync(AttendanceSetupCategory attendanceSetupCategory)
        {
            await DeleteAsync(attendanceSetupCategory);
            return Ok("attendance category deleted");
        }

        [HttpDelete("Campuses/{id}")]
        public async Task<ActionResult<Campus>> DeleteCampusAsync(Campus campus)
        {
            await DeleteAsync(campus);
            return Ok("Campus Deleted");
        }

        [HttpDelete("Positions/{id}")]
        public async Task<ActionResult<Positions>> DeletePositionsAsync(Positions positions)
        {
            await DeleteAsync(positions);
            return Ok("Position Deleted");
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