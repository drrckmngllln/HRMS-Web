using AutoMapper;
using Core.Entities.Settings;
using Core.Interfaces;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Settings
{
    public class DepartmentsController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentsController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IReadOnlyList<Department>> GetDepartmentsAsync([FromQuery] string search)
        {
            var spec = new DepartmentsSpecifications(search);
            var data = await _unitOfWork.Repository<Department>().ListAsync(spec);
            return data;
        }

        [HttpPost("create")]
        public async Task<ActionResult<Department>> CreateDepartmentsAsync(Department department)
        {
            _unitOfWork.Repository<Department>().Add(department);
            await _unitOfWork.Complete();
            return NoContent();
        }

        [HttpPut("update")]
        public async Task<ActionResult<Department>> UpdateAsync(Department department)
        {
            _unitOfWork.Repository<Department>().Update(department);
            await _unitOfWork.Complete();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> DeleteAsync(Department department)
        {
            _unitOfWork.Repository<Department>().Delete(department);
            await _unitOfWork.Complete();
            return NoContent();
        }
    }
}