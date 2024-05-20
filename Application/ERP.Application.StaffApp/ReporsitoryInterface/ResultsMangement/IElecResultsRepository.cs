using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.ReporsitoryInterface.ResultsMangement
{
    public interface IElecResultsRepository
    {
        Task AddElecResultsAsync(DeieResults elecresults);
        Task<IEnumerable<DeieResults>> GetAllElecResultsAsync(string name);

    }

}