using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEInfraData.Mapping
{
    public class CadastroMap : IEntityTypeConfiguration<Cadastro>
    {
        public void Configure(EntityTypeBuilder<Cadastro> builder)
        {
            builder.ToTable("Cadastro");

            builder.HasKey(c => c.CodCadastro);

            builder.Property(c => c.Login)
                .IsRequired()
                .HasColumnName("Login");

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome");

            builder.Property(c => c.Senha)
                .IsRequired()
                .HasColumnName("Senha");

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnName("CPF");

            builder.Property(c => c.CodUsuario)
                .IsRequired()
                .HasColumnName("CodUsuario");
        }
    }
}
