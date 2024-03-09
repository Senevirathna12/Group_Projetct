using ERP.Application.StaffApp.Interfaces.UsersManagement;
using ERP.Application.StaffApp.UseCases.UsersManagement;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.DependancyInjection.UsersManagement
{
    public static class TeacherDependancy
    {
        public static IServiceCollection AddTeacherServices(
            this IServiceCollection services)
        {
            services.AddScoped<IAddTeacherUseCase, AddTeacherUseCase>();
            services.AddScoped<IViewTeacherByNameUseCase, ViewTeacherByNameUseCase>();
            services.AddScoped<IDeleteTeacherUseCase, DeleteTeacherUseCase>();

            return services;
        }
    }
}
