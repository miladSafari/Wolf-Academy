using System;
using System.Collections.Generic;
using System.Text;
using Academy.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Persistence.EF.Mappings
{
    public class CourseMapping:IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses").HasKey(x=>x.Id);
            builder.Property(x => x.Title).HasMaxLength(255);
            builder.HasOne(a => a.Category).WithMany().IsRequired();
        }
    }
}
