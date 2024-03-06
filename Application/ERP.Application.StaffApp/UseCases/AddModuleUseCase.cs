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
	public class AddModuleUseCase : IAddModuleUseCase
	{
		private readonly IModuleRepository _moduleRepository;

        public AddModuleUseCase(IModuleRepository moduleRepository)
        {
			_moduleRepository = moduleRepository;
            
        }
        public async Task ExecuteAsync(NewModule newModule)
		{
			await _moduleRepository.AddModuleAsync(newModule);
		}
	}
}
