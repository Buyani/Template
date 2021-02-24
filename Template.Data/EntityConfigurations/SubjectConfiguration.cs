using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;

namespace Template.Data.EntityConfigurations
{
    public class SubjectConfiguration : EntityTypeConfiguration<Subject>
    {
        public override void Map(EntityTypeBuilder<Subject> builder)
        {
            throw new NotImplementedException();
        }
    }
}
