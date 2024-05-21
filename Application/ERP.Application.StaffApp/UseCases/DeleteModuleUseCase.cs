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
    public class DeleteModuleUseCase : IDeleteModuleUseCase
    {
        private readonly IModuleRepository _moduleRepository;

        public DeleteModuleUseCase(IModuleRepository moduleRepository)
        {
            _moduleRepository = moduleRepository;
        }

        public async Task ExecuteAsync(NewModule newmodule)
        {
            await _moduleRepository.DeleteModuleAsync(newmodule);
        }


    }
}