using ERP.Application.StaffApp.Interfaces.ResourceManagement;
using ERP.Application.StaffApp.ReporsitoryInterface;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.UseCases.ResourceManagement
{
    public class ViewResourceByNameUseCase : IViewResourceByNameUseCase
    {
        private readonly IResourceRepository resourceRepository;

        public ViewResourceByNameUseCase(IResourceRepository resourceRepository)
        {
            this.resourceRepository = resourceRepository;
        }

        public async Task<IEnumerable<Resource>> ExecuteAsync(string name = "")
        {
            return await resourceRepository.GetAllResourcesAsync(name);
        }
    }
}
