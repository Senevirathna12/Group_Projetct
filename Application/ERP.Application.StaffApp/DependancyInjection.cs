using ERP.Application.StaffApp.Employees.Interfaces;
using ERP.Application.StaffApp.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class EmployeeServiceCollection
    {


        public static IServiceCollection AddEmployeeServices(
             this IServiceCollection services)
        {
            //services.AddScoped<IViewEmployeesByNameUseCase, ViewEmployeesByNameUseCase>();
           // services.AddScoped<IAddEmployeeUseCase, AddEmployeeUseCase>();
            //services.AddScoped<IViewEmployeeById, ViewEmployeeById>();
            //services.AddScoped<IEditEmployeeUseCase, EditEmployeeUseCase>();

            return services;
        }
    }
}
