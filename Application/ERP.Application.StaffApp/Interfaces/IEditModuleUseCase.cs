using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.Interfaces
{
    public interface IEditModuleUseCase
    {
        Task ExecuteAsync(NewModule newmodule);
    }
}