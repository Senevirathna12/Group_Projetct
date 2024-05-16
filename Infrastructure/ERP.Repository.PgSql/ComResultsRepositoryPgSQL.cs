using ERP.Application.StaffApp.ReporsitoryInterface.ResultsMangement;
using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql
{
    public class ComResultsRepositoryPgSQL: IComResultsRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;

        public ComResultsRepositoryPgSQL(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;

        }

        public Task AddComResultsAsync(ComResults comresults)
        {
            using var _context = _factory.CreateDbContext();
            _context.ComResults.Add(comresults);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<ComResults>> GetAllComResultsAsync(string name)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.ComResults.ToListAsync();
        }
    }

   

  

  
}
