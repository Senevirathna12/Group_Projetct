using ERP.Application.StaffApp.Interfaces.ResultsMnagement;
using ERP.Application.StaffApp.ReporsitoryInterface.ResultsMangement;
using ERP.Domain.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.StaffApp.UseCases.ResultMnagement
{
    public class AddElecResultsUseCase : IAddElecResultsUseCase
    {
        private readonly IElecResultsRepository _elecresultsRepository;

        public AddElecResultsUseCase(IElecResultsRepository elecresultsRepository)
        {
            _elecresultsRepository = elecresultsRepository;

        }

        public async Task ExecuteAsync(DeieResults newElecResults)
        {
            await _elecresultsRepository.AddElecResultsAsync(newElecResults);
        }
    }

}