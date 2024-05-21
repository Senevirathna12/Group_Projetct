using System.Threading.Tasks;
using ERP.Domain.Core.Entity;



namespace ERP.Application.StaffApp.Interfaces
{
    public interface IDeleteModuleUseCase
    {
        Task ExecuteAsync(NewModule newmodule);

    }
}