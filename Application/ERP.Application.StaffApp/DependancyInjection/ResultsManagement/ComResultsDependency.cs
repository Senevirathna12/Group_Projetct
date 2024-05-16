
using ERP.Application.StaffApp.Interfaces.ResultsMnagement;
using ERP.Application.StaffApp.UseCases.ResultMnagement;
using Microsoft.Extensions.DependencyInjection;

namespace ERP.Application.StaffApp.DependancyInjection.ResultsManagement
{
    public static class ComResultsDependency
    {
        public static IServiceCollection AddTeacherServices(
          this IServiceCollection services)
        {
            services.AddScoped<IAddComResultsUseCase, AddComResultsUseCase>();
            services.AddScoped<IViewComResultsByNameUseCase, ViewComResultsByNameUseCase>();
           
            return services;
        }
    }
}
