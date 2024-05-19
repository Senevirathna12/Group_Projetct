using Bogus;
using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Configurations
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            builder.HasData(
                Enumerable.Range(1, 10).Select(
                    Index => new Faker<Resource>()
                        .RuleFor(s => s.ResourceId, Index + 4444)
                        .RuleFor(s => s.Name, f => f.Lorem.Sentence()) // Generate random names
                        .RuleFor(s => s.Description, f => f.Lorem.Paragraph()) // Generate random descriptions
                        .RuleFor(s => s.Type, f => f.PickRandom<ResourceType>()) // Pick a random ResourceType
                        .Generate()
                )
            );
        }
    }
}