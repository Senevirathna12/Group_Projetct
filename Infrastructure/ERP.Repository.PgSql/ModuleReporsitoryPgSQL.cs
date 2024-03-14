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
        public async Task DeleteModuleAsync(NewModule mod)
        {
            using var _context = _factory.CreateDbContext();
            _context.Newmodules.Remove(mod);
            await _context.SaveChangesAsync();
        }
        public Task EditModuleAsync(NewModule editModule)
        {
            using var _context = _factory.CreateDbContext();
            var newModule = _context.Newmodules.FirstOrDefault(x => x.ModuleId == editModule.ModuleId);

            if (newModule != null)
            {
                newModule.ModuleId = editModule.ModuleId;
                newModule.ModuleName = editModule.ModuleName;
                newModule.semester = editModule.semester;
                newModule.Teacher = editModule.Teacher;
                newModule.Credit = editModule.Credit;
                newModule.teacherId = editModule.teacherId;

            }

            return Task.CompletedTask;
        }
        public async Task<IEnumerable<NewModule>> GetAllModulesAsync(string name)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Newmodules.ToListAsync();
        }
        public async Task<NewModule> GetModulesById(int moduleId)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Newmodules.FirstOrDefaultAsync(x => x.ModuleId == moduleId);

        }

    }
}