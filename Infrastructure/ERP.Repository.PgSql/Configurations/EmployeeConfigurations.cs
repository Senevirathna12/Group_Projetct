using Bogus;
using ERP.Domain.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Repository.PgSql.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.HasData(

               Enumerable.Range(1, 10).Select(
                   index => new Faker<Employee>()
                         .RuleFor(s => s.EmployeeId, index + 1000)
                         .RuleFor(s => s.FirstName, f => f.Name.FirstName())
                         .RuleFor(s => s.LastName, f => f.Name.LastName())
                         .RuleFor(s => s.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))


               )
            );


        }
    }
}
