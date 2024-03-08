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
    public class ViewTeacherByNameUseCase : IViewTeacherByNameUseCase
    {
        private readonly ITeacherRepository teacherRepository;

        public ViewTeacherByNameUseCase(ITeacherRepository teacherRepository)
        {
            this.teacherRepository = teacherRepository;
        }
        public async Task<IEnumerable<Teacher>> 
            ExecuteAsync(string name = "")
        {
            return await teacherRepository.GetAllTeachersAsync(name);
        }
    }
}
