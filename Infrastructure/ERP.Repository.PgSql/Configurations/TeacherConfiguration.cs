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
	internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
	{
		public void Configure(EntityTypeBuilder<Teacher> builder)
		{

			builder.HasData(

			   Enumerable.Range(1,3).Select(
				   index => new Faker<Teacher>()
						 .RuleFor(s => s.TeacherId, index + 1000)
						 .RuleFor(s => s.FirstName, f => f.Name.FirstName())
						 .RuleFor(s => s.LastName, f => f.Name.LastName())
						 .RuleFor(s => s.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
						 .Generate()

			   )
			);




		}

	}
}
