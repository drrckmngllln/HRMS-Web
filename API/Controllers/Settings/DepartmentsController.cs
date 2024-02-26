using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Settings;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Settings
{
    public class DepartmentsController : BaseApiController
    {
        private readonly ISettingsService<Department> _departmentRepo;

        public DepartmentsController(ISettingsService<Department> departmentRepo)
        {
            _departmentRepo = departmentRepo;

        }

        [HttpGet]
        public async Task<IReadOnlyList<Department>> GetDepartmentsAsync()
        {
            return await _departmentRepo.GetAllAsync();
        }

        [HttpGet("search")]
        public async Task<ActionResult<IReadOnlyList<Department>>> SearchDepartmentsAsync([FromQuery] string value)
        {
            var searchItem = await _departmentRepo.GetAllAsync();
            var item = searchItem.Where(x => x.Name.ToLower().Contains(value)).ToList();
            return Ok(item);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Department>> CreateDepartmentsAsync(Department department)
        {
            var departments = await _departmentRepo.GetAllAsync();
            var dep = new Department
            {
                Name = department.Name
            };
            if (dep != null)
            {
                await _departmentRepo.AddAsync(dep);
                return Ok(dep);
            }

            return BadRequest();
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult<Department>> UpdateAsync(Department department)
        {
            var dep = new Department
            {
                Id = department.Id,
                Name = department.Name
            };
            await _departmentRepo.UpdateAsync(dep);
            return Ok(dep);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> DeleteAsync(int id)
        {
            await _departmentRepo.DeleteAsync(id);
            return Ok(id);
        }
    }
}