using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEInfraData.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.ToTable("Usuario");

            builder.HasKey(c => c.CodUsuario);

            builder.Property(c => c.Senha)
                .IsRequired()
                .HasColumnName("Senha");

            builder.Property(c => c.Login)
                .IsRequired()
                .HasColumnName("Login");

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnName("CPF");
        }
    }
}
