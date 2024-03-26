using AutoMapper;
using Core.Entities.Transactions.EmployeeEntity;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public EmployeeRepository(StoreContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task AddAsync(Employee entity)
        {
            var employee = await _context.Employees.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var delete = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(delete);
            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<Employee>> GetAllAsync()
        {
            return await _context.Employees
                .Include(x => x.Department)
                .Include(x => x.Position)
                .ToListAsync();
        }

        public async Task<Employee> GetByIdAsync(int id)
        {
            var entity = await _context.Employees.FindAsync(id);
            return entity;
        }

        public async Task UpdateAsync(Employee entity)
        {
            _context.Employees.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}