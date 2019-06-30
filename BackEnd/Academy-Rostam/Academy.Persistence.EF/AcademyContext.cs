using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.Model;
using Academy.Persistence.EF.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Academy.Persistence.EF
{
    public class AcademyContext : DbContext
    {
        public DbSet<CourseCategory> CourseCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=AcademyDb;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
