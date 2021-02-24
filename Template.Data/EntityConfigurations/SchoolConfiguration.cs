using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;

namespace Template.Data.EntityConfigurations
{
    public class SchoolConfiguration : EntityTypeConfiguration<School>
    {
        public override void Map(EntityTypeBuilder<School> builder)
        {
            builder.HasMany(p => p.Students);          
        }
    }
}
