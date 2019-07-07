using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Academy.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Academy.Persistence.EF.Mappings
{
    public class CourseCategoryMapping:IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.ToTable("CourseCategories").HasKey(x=>x.Id);
            builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
            builder.HasOne(x => x.ParentCategory).WithMany(x=>x.ChildCategories);
        }
    }
}
