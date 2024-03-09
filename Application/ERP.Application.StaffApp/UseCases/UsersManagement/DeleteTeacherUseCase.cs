using ERP.Application.StaffApp.Interfaces.UsersManagement;
using ERP.Application.StaffApp.ReporsitoryInterface.UsersManagement;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.UseCases.UsersManagement
{
    public class DeleteTeacherUseCase : IDeleteTeacherUseCase
    {
        private readonly ITeacherRepository _teacherRepository;

        public DeleteTeacherUseCase(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }

        public async Task ExecuteAsync(Teacher teacher)
        {
            await _teacherRepository.DeleteTeacherAsync(teacher);
        }
    }
}
