using ERP.Application.StaffApp.Interfaces;
using ERP.Application.StaffApp.UseCases;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.DependancyInjection
{
    public static class ModuleDependancy
    {
        public static IServiceCollection AddModuleServices(
            this IServiceCollection services)
        {
            services.AddScoped<IAddModuleUseCase,AddModuleUseCase>();
            services.AddScoped<IEditModuleUseCase, EditModuleUseCase>();
            services.AddScoped<IViewModuleByNameUseCase, ViewModuleByNameUseCase>();
            services.AddScoped<IDeleteModuleUseCase, DeleteModuleUseCase>();
			
            return services;
        }
    }
}