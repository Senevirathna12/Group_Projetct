using ERP.Domain.Core.Entity;

namespace ERP.Application.StaffApp.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeessAsync(string name);
        Task<bool> ExistAsync(Employee employee);
        Task AddEmployeeAsync(Employee employee);
        Task EditEmployeeAsync(Employee employee);
        Task<Employee> GetStudentById(int EmployeeId);
        
    }
}
