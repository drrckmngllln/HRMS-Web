using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Settings;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers.Settings
{
    public class DepartmentsController : BaseApiController
    {
        private readonly StoreContext _context;
        public DepartmentsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Department>> GetDepartmentsAsync()
        {
            return await _context.Departments.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Department> GetDepartmentAsync(int id)
        {
            return await _context.Departments.FindAsync(id);
        }

        [HttpPost]
        public async Task AddDepartmentAsync(Department entity)
        {
            await _context.Departments.AddAsync(entity);
            await _context.SaveChangesAsync();
        }


    }
}