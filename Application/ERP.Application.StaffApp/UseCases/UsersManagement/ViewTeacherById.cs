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
    public class ViewTeacherById : IViewTeacherById
    {
        private readonly ITeacherRepository teacherRepository;

        public ViewTeacherById(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }

        public async Task<Teacher>
        ExecuteAsync(int teacherId)
        {
            return await teacherRepository.GetTeacherById(teacherId);
        }

    }
}
