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
    public class ResourceRepositoryPgSQL : IResourceRepository
    {
        private readonly PgSqlDbContext _context;

        public ResourceRepositoryPgSQL(PgSqlDbContext context)
        {
            _context = context;
        }

        public async Task AddResourceAsync(Resource resource)
        {
            _context.Resources.Add(resource);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteResourceAsync(Resource resource)
        {
            _context.Resources.Remove(resource);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Resource>> GetAllResourcesAsync(string name)
        {
            return await _context.Resources
            .Where(r => r.Name.Contains(name))
            .ToListAsync();
        }

        public async Task EditResourceAsync(Resource resource)
        {
            // No need to use _factory, use the existing _context
            var existingResource = await _context.Resources.FirstOrDefaultAsync(x => x.ResourceId == resource.ResourceId);

            if (existingResource != null)
            {
                existingResource.Name = resource.Name;
                existingResource.Description = resource.Description;
                existingResource.Type = resource.Type;
                await _context.SaveChangesAsync();
            }
        }
    }
}