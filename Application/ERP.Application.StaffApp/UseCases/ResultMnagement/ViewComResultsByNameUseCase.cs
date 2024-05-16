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
    public class ViewComResultsByNameUseCase : IViewComResultsByNameUseCase
    {
        private readonly IComResultsRepository comresultsRepository;
        public ViewComResultsByNameUseCase(IComResultsRepository comresultsRepository)
        {
            this.comresultsRepository = comresultsRepository;
        }

        public async Task<IEnumerable<ComResults>>
         ExecuteAsync(string name = "")
        {
            return await comresultsRepository.GetAllComResultsAsync(name);
        }

    }
}
