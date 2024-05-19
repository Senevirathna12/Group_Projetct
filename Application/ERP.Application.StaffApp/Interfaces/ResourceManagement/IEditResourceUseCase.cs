using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.Interfaces.ResourceManagement
{
    public interface IEditResourceUseCase
    {
        Task ExecuteAsync(Resource resource);

    }
}
