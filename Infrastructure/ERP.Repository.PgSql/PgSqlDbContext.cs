﻿using ERP.Domain.Core.Entity;

using Microsoft.EntityFrameworkCore;

namespace ERP.Repository.PgSql
{
    public class PgSqlDbContext : DbContext
    {
        public PgSqlDbContext(DbContextOptions<PgSqlDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new StudentConfigurations());
            //modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            
            modelBuilder.Entity<ModuleOfferingTeacher>()
            .HasKey(mt => new { mt.ModuleOfferingId, mt.TeacherId });

            modelBuilder.Entity<ModuleOfferingTeacher>()
                .HasOne(mt => mt.ModuleOffering)
                .WithMany(mt => mt.Teachers)
                .HasForeignKey(mt => mt.ModuleOfferingId);
     

            //modelBuilder.Entity<ModuleOfferingTeacher>()
            //    .HasOne(mt => mt.Teacher)
            //    .WithMany(mt => mt.TeachingModules)
            //    .HasForeignKey(mt => mt.TeacherId);


            modelBuilder.Entity<ModuleOfferingFirstExaminer>()
                .HasKey(mf => new {mf.ModuleOfferingId,mf.TeacherId});

            modelBuilder.Entity<ModuleOfferingFirstExaminer>()
                .HasOne(mf => mf.ModuleOffering)
                .WithMany(mf => mf.FirstExaminers)
                .HasForeignKey(mf => mf.TeacherId);

            //modelBuilder.Entity<ModuleOfferingFirstExaminer>()
            //    .HasOne(mf => mf.Teacher)
            //    .WithMany(mf => mf.FirstExaminersModules)
            //    .HasForeignKey(mf =>mf.TeacherId);


            modelBuilder.Entity<ModuleOfferingSecondExaminer>()
                .HasKey(ms => new { ms.ModuleOfferingId, ms.TeacherId });

            modelBuilder.Entity<ModuleOfferingSecondExaminer>()
                .HasOne(ms => ms.ModuleOffering)
                .WithMany(ms => ms.SecondExaminers)
                .HasForeignKey(ms => ms.TeacherId);

            //modelBuilder.Entity<ModuleOfferingSecondExaminer>()
            //    .HasOne(ms => ms.Teacher)
            //    .WithMany(ms => ms.SecondExaminersModules)
            //    .HasForeignKey(ms => ms.TeacherId);

            // module registration primary key

            modelBuilder.Entity<NewModule>()
                .HasKey(mf => new { mf.ModuleId });

            modelBuilder.Entity<ComResults>()
               .HasKey(mf => new { mf.ComId });
        
            modelBuilder.Entity<DeieResults>()
                .HasKey(mf => new { mf.DEIEid });            

            // module registration foreign key

            //modelBuilder.Entity<NewModule>()
            //    .HasOne(ms => ms.Teacher)
            //    .WithMany(ms => ms.modules)
            //    .HasForeignKey(ms => ms.teacherId);

            modelBuilder.Entity<Resource>()
                .HasKey(mf => new {mf.ResourceId});



        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<ComResults> ComResults { get; set; }
        public DbSet<DeieResults> Deieresults { get; set; }
        public DbSet<ModuleOfferingTeacher> ModuleTeachers { get; set;}
        public DbSet<ModuleOfferingFirstExaminer> ModuleFirstExaminers { get; set; }
        public DbSet<ModuleOfferingSecondExaminer> ModuleSecondExaminers { get; set; }

        public DbSet<NewModule> Newmodules { get; set; }

        public DbSet<Resource> Resources { get; set; }
        

    }
}
