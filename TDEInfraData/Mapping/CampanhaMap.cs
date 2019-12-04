using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEInfraData.Mapping
{
    class CampanhaMap : IEntityTypeConfiguration<Campanha>
    {
        public void Configure(EntityTypeBuilder<Campanha> builder)
        {
            builder.ToTable("Campanha");

            builder.HasKey(c => c.CodCampanha);

            builder.Property(c => c.CodFuncionario)
                .IsRequired()
                .HasColumnName("CodFuncionario");

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnName("Nome");

            builder.Property(c => c.Tema)
                .IsRequired()
                .HasColumnName("Tema");

            builder.Property(c => c.DataInicio)
                .IsRequired()
                .HasColumnName("DataInicio");

            builder.Property(c => c.Premio)
                .IsRequired()
                .HasColumnName("Premio");

            builder.Property(c => c.Descricao)
                .IsRequired()
                .HasColumnName("Descricao");

            builder.Property(c => c.DataFim)
                .IsRequired()
                .HasColumnName("DataFim");
        }
    }
}
