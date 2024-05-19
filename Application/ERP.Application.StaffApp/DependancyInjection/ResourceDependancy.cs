using ERP.Application.StaffApp.Interfaces.ResourceManagement;
using ERP.Application.StaffApp.UseCases.ResourceManagement;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;


namespace ERP.Application.StaffApp.DependancyInjection

{
    public static class ResourceDependency
    {
        public static IServiceCollection AddResourceServices(this IServiceCollection services)
        {
            services.AddScoped<IAddResourceUseCase, AddResourceUseCase>();
            services.AddScoped<IDeleteResourceUseCase, DeleteResourceUseCase>();
            services.AddScoped<IViewResourceByNameUseCase, ViewResourceByNameUseCase>();
            services.AddScoped<IEditResourceUseCase, EditResourceUseCase>();

            return services;
        }
    }
}
