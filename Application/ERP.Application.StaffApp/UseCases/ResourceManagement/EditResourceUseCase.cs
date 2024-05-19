using ERP.Application.StaffApp.Interfaces.ResourceManagement;
using ERP.Application.StaffApp.ReporsitoryInterface;
using ERP.Domain.Core.Entity;
using System;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.UseCases.ResourceManagement
{
    public class EditResourceUseCase : IEditResourceUseCase
    {
        private readonly IResourceRepository _resourceRepository;

        public EditResourceUseCase(IResourceRepository resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        public async Task ExecuteAsync(Resource editedResource)
        {
            await _resourceRepository.EditResourceAsync(editedResource);
        }
    }
}
