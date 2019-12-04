using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEInfraData.Mapping
{
    public class UsersMap : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(c => c.UserID);

            builder.Property(c => c.AcessKey)
                .IsRequired()
                .HasColumnName("AccessKey");

            builder.Property(c => c.userCreated)
                .IsRequired()
                .HasColumnName("userCreated");

            builder.Property(c => c.lastUser)
                .IsRequired()
                .HasColumnName("lastUser");

            builder.Property(c => c.createdAt)
                .IsRequired()
                .HasColumnName("createdAt");

            builder.Property(c => c.updatedAt)
                .IsRequired()
                .HasColumnName("updatedAt");

            builder.Property(c => c.active)
                .IsRequired()
                .HasColumnName("active");
    }
    }
}
