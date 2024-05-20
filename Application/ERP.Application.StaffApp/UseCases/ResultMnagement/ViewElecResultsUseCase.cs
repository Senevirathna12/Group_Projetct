using ERP.Application.StaffApp.Interfaces.ResultsMnagement;
using ERP.Application.StaffApp.ReporsitoryInterface.ResultsMangement;
using ERP.Application.StaffApp.ReporsitoryInterface.UsersManagement;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.UseCases.ResultMnagement
{
    public class ViewElecResultsByNameUseCase : IViewElecResultsByNameUseCase
    {
        private readonly IElecResultsRepository elecresultsRepository;
        public ViewElecResultsByNameUseCase(IElecResultsRepository elecresultsRepository)
        {
            this.elecresultsRepository = elecresultsRepository;
        }

        public async Task<IEnumerable<DeieResults>>
            ExecuteAsync(string name = "")
        {
            return await elecresultsRepository.GetAllElecResultsAsync(name);
        }

    }
}