using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;

namespace Template.Data.EntityConfigurations
{
    public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public override void Map(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(p => p.Identity);
            builder.HasMany(p => p.Payments);
            builder.HasMany(p => p.Enrollements);
            builder.Property(p => p.Identity).IsRequired().HasMaxLength(13);
        }
    }
}
