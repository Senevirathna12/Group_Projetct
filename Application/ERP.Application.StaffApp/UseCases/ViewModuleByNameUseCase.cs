using System.Runtime.InteropServices;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.StaffApp.ReporsitoryInterface;
using ERP.Application.StaffApp.Interfaces;

namespace ERP.Application.StaffApp.UseCases
{
    public class ViewModuleByNameUseCase : IViewModuleByNameUseCase
    {
        private readonly IModuleRepository moduleRepository;

        public ViewModuleByNameUseCase(IModuleRepository moduleRepository)
        {
            this.moduleRepository = moduleRepository;
        }

        public async Task<IEnumerable<NewModule>>
            
            ExecuteAsync(string name = "")
        {
            return await moduleRepository.GetAllModulesAsync(name);
        }

    }
}