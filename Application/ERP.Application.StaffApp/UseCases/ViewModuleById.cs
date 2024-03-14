using ERP.Domain.Core.Entity;
using ERP.Application.StaffApp.Interfaces;
using ERP.Application.StaffApp.ReporsitoryInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ERP.Application.StaffApp.UseCases
{
    public class ViewModuleById : IViewModuleById
    {
        private readonly IModuleRepository moduleRepository;

        public ViewModuleById(IModuleRepository moduleRepository)
        {
            this.moduleRepository = moduleRepository;
        }

        public async Task<NewModule>
            ExecuteAsync(int moduleId)
        {
            return await moduleRepository.GetModulesById(moduleId);
        }


    }
}