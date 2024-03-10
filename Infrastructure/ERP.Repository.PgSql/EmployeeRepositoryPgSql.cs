using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;


namespace ERP.Repository.PgSql
{
    public class EmployeeRepositoryPgSql : IEmployeeRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;

        public EmployeeRepositoryPgSql(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;
        }

        public Task AddEmployeeAsync(Employee employee)
        {
            using var _context = _factory.CreateDbContext();
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task EditEmployeeAsync(Employee std)
        {
            using var _context = _factory.CreateDbContext();
            var employee = _context.Employees.FirstOrDefault(x => x.EmployeeId == std.EmployeeId);

            if (employee != null)
            {
                employee.FirstName = std.FirstName;
                employee.LastName = std.LastName;
                employee.Email = std.Email;
                employee.Phone = std.Phone;
                employee.Address1 = std.Address1;
            }

            return Task.CompletedTask;
        }

        public async Task<bool> ExistAsync(Employee employee)
        {
            using var _context = _factory.CreateDbContext();
            return await Task.FromResult(_context.Employees.Any(x => x.EmployeeId == employee.EmployeeId));
        }


        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync(string name)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Employees.FirstOrDefaultAsync(x => x.EmployeeId == employeeId);

        }
    }


}
