using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Domain.Core.Entity;

namespace ERP.Application.StaffApp.Interfaces.ResultsMnagement
{
    public  interface IAddComResultsUseCase
    {
        Task ExecuteAsync(ComResults comresults);
    }
}
