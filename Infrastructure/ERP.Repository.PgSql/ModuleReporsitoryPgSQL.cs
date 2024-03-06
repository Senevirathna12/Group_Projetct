using ERP.Application.StaffApp.ReporsitoryInterface;
using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql
{
	public class ModuleReporsitoryPgSQL : IModuleRepository
	{
		private readonly IDbContextFactory<PgSqlDbContext> _factory;

		
        public ModuleReporsitoryPgSQL(IDbContextFactory<PgSqlDbContext>factory)
        {
			_factory = factory;
            
        }
        public Task AddModuleAsync(NewModule newModule)
		{
			using var _context = _factory.CreateDbContext();
			_context.Newmodules.Add(newModule);
			_context.SaveChanges();
			return Task.CompletedTask;
		}

	}
}
