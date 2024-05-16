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
    public class EditTeacherUseCase : IEditTeacherUseCase 
    {
        private readonly ITeacherRepository teacherRepository;

        public EditTeacherUseCase(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        public async Task ExecuteAsync(Teacher tea)
        {
            await teacherRepository.EditTeacherAsync(tea);
        }
    }
}
