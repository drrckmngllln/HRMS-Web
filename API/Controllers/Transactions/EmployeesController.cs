using API.Dtos;
using AutoMapper;
using Core.Entities.Transactions.EmployeeEntity;
using Core.Interfaces;
using Core.Parameters;
using Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Transactions
{
    public class EmployeesController : BaseApiController
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<Employee> _empRepo;
        public EmployeesController(IUnitOfWork unitOfWork, IMapper mapper, IGenericRepository<Employee> empRepo)
        {
            _empRepo = empRepo;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<EmployeeDto>>> GetEmployeesAsync([FromQuery] EmployeeSpecParameters empParams)
        {
            var spec = new EmployeesWithRelationshipSpecifications(empParams);
            var employees = await _unitOfWork.Repository<Employee>().ListAsync(spec);
            var data = _mapper.Map<IReadOnlyList<Employee>, IReadOnlyList<EmployeeDto>>(employees);

            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> GetByIdAsync(int id)
        {
            var spec = new EmployeesWithRelationshipSpecifications(id);
            var employee = await _unitOfWork.Repository<Employee>().GetEntityWithSpec(spec);
            return Ok(_mapper.Map<EmployeeDto>(employee));
        }

        [HttpPost("create")]
        public async Task<ActionResult<EmployeeDto>> AddAsync(Employee entity)
        {
            _unitOfWork.Repository<Employee>().Add(entity);
            await _unitOfWork.Complete();
            var data = _mapper.Map<EmployeeDto>(entity);
            return Ok(data);
        }
    }
}