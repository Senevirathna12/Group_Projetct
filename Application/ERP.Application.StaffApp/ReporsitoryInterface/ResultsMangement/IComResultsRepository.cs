using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.ReporsitoryInterface.ResultsMangement
{
    public interface IComResultsRepository
    {
        Task AddComResultsAsync(ComResults comresults);
        Task<IEnumerable<ComResults>> GetAllComResultsAsync(string name);
    }

}
