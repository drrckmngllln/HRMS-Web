using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities.Transactions.EmployeeEntity;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Transactions
{
    public class EmployeesController : BaseApiController
    {
        private readonly IEmployeeRepository _repo;
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeeRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<IReadOnlyList<EmployeeDto>>> GetEmployeesAsync()
        {
            var employees = await _repo.GetAllAsync();
            return Ok(_mapper.Map<IReadOnlyList<Employee>, IReadOnlyList<EmployeeDto>>(employees));
        }

        [HttpGet("search")]
        public async Task<ActionResult<IReadOnlyList<EmployeeDto>>> GetEmployeeBySearch([FromQuery] string value)
        {
            var employees = await _repo.GetAllAsync();
            var search = employees.Where(x => x.FullName.ToLower().Contains(value)).ToList();
            return Ok(_mapper.Map<IReadOnlyList<Employee>, IReadOnlyList<EmployeeDto>>(search));
        }
        
        [HttpPost("create")]
        public async Task<ActionResult<EmployeeDto>> AddAsync(Employee entity)
        {
            await _repo.AddAsync(entity);
            return Ok(_mapper.Map<Employee, EmployeeDto>(entity));
        }

        [HttpPut("update")]
        public async Task<ActionResult<EmployeeDto>> UpdateAsync(Employee entity)
        {
            await _repo.UpdateAsync(entity);
            return Ok(_mapper.Map<Employee, EmployeeDto>(entity));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
            return NoContent();
        }
    }
}