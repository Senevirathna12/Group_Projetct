using ERP.Application.StaffApp.Interfaces.ResultsMnagement;
using ERP.Application.StaffApp.UseCases.ResultMnagement;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.Application.StaffApp.DependancyInjection.ResultsManagement
{
    public static class ElecResultsDependency
    {
        public static IServiceCollection AddTeacherServices(
            this IServiceCollection services)
        {
            services.AddScoped<IAddElecResultsUseCase, AddElecResultsUseCase>();
            services.AddScoped<IViewElecResultsByNameUseCase, ViewElecResultsByNameUseCase>();
           
            return services;

        }
    }
}