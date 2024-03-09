using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Domain.Core.Entity;

namespace ERP.Application.StaffApp.Interfaces.UsersManagement
{
    public interface IAddTeacherUseCase
    {
        Task ExecuteAsync(Teacher teacher);
    }
}