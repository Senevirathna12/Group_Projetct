using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.ReporsitoryInterface
{
    public interface IResourceRepository
    {
        Task AddResourceAsync(Resource resource);
        Task DeleteResourceAsync(Resource resource);
        Task EditResourceAsync(Resource resource);
        Task<IEnumerable<Resource>> GetAllResourcesAsync(string name);
    }
}
