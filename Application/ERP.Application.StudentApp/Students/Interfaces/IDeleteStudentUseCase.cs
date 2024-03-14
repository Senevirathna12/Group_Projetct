using System.Threading.Tasks;
using ERP.Domain.Core.Entity;


namespace ERP.Application.StudentApp.Students.Interfaces
{
    public interface IDeleteStudentUseCase
    {
        Task ExecuteAsync(Student student);

    }
}