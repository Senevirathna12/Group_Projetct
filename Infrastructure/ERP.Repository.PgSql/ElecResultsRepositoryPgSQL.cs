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
    public class ElecResultsRepositoryPgSQL: IElecResultsRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;

        public ElecResultsRepositoryPgSQL(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;

        }

        public Task AddElecResultsAsync(DeieResults elecresults)
        {
            using var _context = _factory.CreateDbContext();
            _context.Deieresults.Add(elecresults);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<IEnumerable<DeieResults>> GetAllElecResultsAsync(string name)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Deieresults.ToListAsync();
        }
    }

}