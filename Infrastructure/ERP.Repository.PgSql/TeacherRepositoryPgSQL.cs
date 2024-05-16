using ERP.Application.StaffApp.ReporsitoryInterface.UsersManagement;
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

        public async Task DeleteTeacherAsync(Teacher teacher)
        {
            using var _context = _factory.CreateDbContext();
            _context.Teachers.Remove(teacher);
            await _context.SaveChangesAsync();
        }

        public Task EditTeacherAsync(Teacher tea)
        {
            using var _context = _factory.CreateDbContext();
            var teacher = _context.Teachers.FirstOrDefault(x => x.TeacherId == tea.TeacherId);

            if (teacher != null)
            {
                teacher.Department = tea.Department;
                teacher.FirstName = tea.FirstName;
                teacher.LastName = tea.LastName;
                teacher.Email = tea.Email;
                teacher.PhoneNumber = tea.PhoneNumber;
                teacher.NationalID = tea.NationalID;
                teacher.District = tea.District;
                _context.SaveChanges();
            }

            return Task.CompletedTask;
        }

        public async Task<bool> ExistAsync(Teacher teacher)
        {
            using var _context = _factory.CreateDbContext();
            return await Task.FromResult(_context.Teachers.Any(x => x.TeacherId == teacher.TeacherId));
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachersAsync(string name)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Teachers.ToListAsync();
        }

        public async Task<Teacher> GetTeacherById(int teacherId)
        {
            using var _context = _factory.CreateDbContext();
            return await _context.Teachers.FirstOrDefaultAsync(x => x.TeacherId == teacherId);
        }
    }
}
