using ERP.Application.StaffApp.Interfaces;
using ERP.Application.StaffApp.ReporsitoryInterface;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.UseCases
{
    public class AddTeacherUseCase : IAddTeacherUseCase
    {
        private readonly ITeacherRepository _teacherRepository;
        public AddTeacherUseCase(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;

        }

        public async Task ExecuteAsync(Teacher newTeacher)
        {
            await _teacherRepository.AddTeacherAsync(newTeacher);
        }
    }
}
