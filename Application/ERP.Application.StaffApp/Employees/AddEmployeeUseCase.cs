using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.StaffApp.Interfaces;
using ERP.Domain.Core.Entity;
using ERP.Application.StaffApp.Employees.Interfaces;

namespace ERP.Application.StaffApp.Employees
{
    public class AddEmployeeUseCase : IAddEmployeeUseCase
    {
        private readonly IEmployeeRepository _studentRepository;
        private IEmployeeRepository _employeeRepository;

        public AddEmployeeUseCase(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task ExecuteAsync(Employee employee)
        {
            await _employeeRepository.AddEmployeeAsync(employee);
        }
    }
}
