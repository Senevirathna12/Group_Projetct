using ERP.Application.StaffApp.Interfaces;
using ERP.Application.StaffApp.ReporsitoryInterface;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.UseCases
{
    public class EditModuleUseCase : IEditModuleUseCase
    {
        private readonly IModuleRepository _moduleRepository;

        public EditModuleUseCase(IModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;

        }
        public async Task ExecuteAsync(NewModule editModule)
        {
            await _moduleRepository.EditModuleAsync(editModule);
        }
    }
}