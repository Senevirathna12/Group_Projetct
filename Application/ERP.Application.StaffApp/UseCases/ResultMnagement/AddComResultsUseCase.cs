
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
    public class AddComResultsUseCase : IAddComResultsUseCase
    {
        private readonly IComResultsRepository _comresultsRepository;

        public AddComResultsUseCase(IComResultsRepository comresultsRepository)
        {
            _comresultsRepository = comresultsRepository;

        }

        public async Task ExecuteAsync(ComResults newComResults)
        {
            await _comresultsRepository.AddComResultsAsync(newComResults);
        }
    }
}
