using API.Dtos;
using AutoMapper;
using Core.Entities.Transactions.EmployeeEntity;
using Core.Interfaces;
using Core.Specifications;
using Infrastructure.Data;
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
            // var spec = new EmployeesWithRelationshipSpecifications(empParams);
            // var employees = await _unitOfWork.Repository<Employee>().ListAsync(spec);
            // var data = _mapper.Map<IReadOnlyList<Employee>, IReadOnlyList<EmployeeDto>>(employees);
            var data = await _unitOfWork.Repository<Employee>().ListAllAsync();

            return Ok(data);
        }
    }
}