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
    public class TeacherReporsitoryPgSQL : ITeacherRepository
    {
        private readonly IDbContextFactory<PgSqlDbContext> _factory;


        public TeacherReporsitoryPgSQL(IDbContextFactory<PgSqlDbContext> factory)
        {
            _factory = factory;

        }
        public Task AddTeacherAsync(Teacher teacher)
        {
            using var _context = _factory.CreateDbContext();
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
            return Task.CompletedTask;
        }

    }
}
