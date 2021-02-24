using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Template.Core.Entities;

namespace Template.Data.EntityConfigurations
{
    public class PaymentConfiguration : EntityTypeConfiguration<Payment>
    {
        public override void Map(EntityTypeBuilder<Payment> builder)
        {
            builder.Property(d => d.StudentIdentity).IsRequired().HasMaxLength(13);
        }
    }
}
