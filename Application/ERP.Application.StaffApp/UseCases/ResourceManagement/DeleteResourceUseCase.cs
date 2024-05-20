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
    public class DeleteResourceUseCase : IDeleteResourceUseCase
    {
        private readonly IResourceRepository _resourceRepository;

        public DeleteResourceUseCase(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        public async Task ExecuteAsync(Resource resource)
        {
            await _resourceRepository.DeleteResourceAsync(resource);
        }
    }
}
