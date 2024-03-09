using ERP.Domain.Core.Entity;


namespace ERP.Application.StaffApp.Interfaces.UsersManagement
{
    public interface IDeleteTeacherUseCase
    {
        Task ExecuteAsync(Teacher teacher);
    }
}
