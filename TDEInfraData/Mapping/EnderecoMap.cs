using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEInfraData.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereço");

            builder.HasKey(c => c.CodEndereco);

            builder.Property(c => c.CodFuncionario)
                .IsRequired()
                .HasColumnName("CodEmpresa");

            builder.Property(c => c.Rua)
                .IsRequired()
                .HasColumnName("Rua");

            builder.Property(c => c.Bairro)
                .IsRequired()
                .HasColumnName("Bairro");

            builder.Property(c => c.Numero)
                .IsRequired()
                .HasColumnName("Numero");

            builder.Property(c => c.Complemento)
                .IsRequired()
                .HasColumnName("Complemento");

            builder.Property(c => c.Cidade)
                .IsRequired()
                .HasColumnName("Cidade");

            builder.Property(c => c.Estado)
                .IsRequired()
                .HasColumnName("Estado");

            builder.Property(c => c.CEP)
                .IsRequired()
                .HasColumnName("CEP");
        }
    }
}
