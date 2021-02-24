using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;

namespace Template.Data.EntityConfigurations
{
    public class GuardianConfiguration : EntityTypeConfiguration<Guardian>
    {
        public override void Map(EntityTypeBuilder<Guardian> builder)
        {
            builder.HasOne(p => p.Student).WithOne(p => p.Guardian);
            builder.Property(p => p.Identity).IsRequired();            
        }
    }
}
