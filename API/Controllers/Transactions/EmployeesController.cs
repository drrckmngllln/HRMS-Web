using API.Dtos;
using AutoMapper;
using Core.Entities.Settings;
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
        public EmployeesController(IUnitOfWork unitOfWork, IMapper mapper)
        {
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
        public async Task<ActionResult<EmployeeDto>> AddAsync(EmployeeDto entity)
        {
            var department = await _unitOfWork.Repository<Department>().ListAllAsync();
            var depId = department.FirstOrDefault(x => x.Name == entity.Department);
            var position = await _unitOfWork.Repository<Positions>().ListAllAsync();
            var posId = position.FirstOrDefault(x => x.Name == entity.Position);

            if (depId != null || posId != null)
            {
                var employee = new Employee
                {
                    EmployeeNumber = entity.EmployeeNumber,
                    LastName = entity.LastName,
                    FirstName = entity.FirstName,
                    MiddleName = entity.MiddleName,
                    FullName = entity.FullName,
                    DepartmentId = depId.Id,
                    PositionId = posId.Id,
                    ContractStart = entity.ContractStart,
                    ContractEnd = entity.ContractEnd,
                    Status = entity.Status
                };
            
                _unitOfWork.Repository<Employee>().Add(employee);
                await _unitOfWork.Complete();
                var data = _mapper.Map<Employee, EmployeeDto>(employee);
                return Ok(data);
            }

            return BadRequest();
        }

        [HttpPut("update")]
        public async Task<ActionResult<EmployeeDto>> UpdateAsync(EmployeeDto entity)
        {
            var department = await _unitOfWork.Repository<Department>().ListAllAsync();
            var depId = department.FirstOrDefault(x => x.Name == entity.Department);

            var positions = await _unitOfWork.Repository<Positions>().ListAllAsync();
            var posId = positions.FirstOrDefault(x => x.Name == entity.Position);

            if (depId != null || posId != null)
            {
                var employee = new Employee
                {
                    Id = entity.Id,
                    EmployeeNumber = entity.EmployeeNumber,
                    LastName = entity.LastName,
                    FirstName = entity.FirstName,
                    MiddleName = entity.MiddleName,
                    FullName = entity.FullName,
                    DepartmentId = depId.Id,
                    PositionId = posId.Id,
                    ContractStart = entity.ContractStart,
                    ContractEnd = entity.ContractEnd,
                    Status = entity.Status
                };
                
                _unitOfWork.Repository<Employee>().Update(employee);
                await _unitOfWork.Complete();
                return Ok(_mapper.Map<Employee, EmployeeDto>(employee));
            }

            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<EmployeeDto>> DeleteAsync(Employee entity)
        {
            _unitOfWork.Repository<Employee>().Delete(entity);
            await _unitOfWork.Complete();
            return Ok();
        }
    }
}