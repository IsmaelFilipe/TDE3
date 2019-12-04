using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEInfraData.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliação");

            builder.HasKey(c => c.CodCampanha);
            builder.HasKey(c => c.CodFuncionario);

            builder.Property(c => c.CodCampanha)
                .IsRequired()
                .HasColumnName("CodCampanha")
                ;

            builder.Property(c => c.CodFuncionario)
                .IsRequired()
                .HasColumnName("CodFuncionario");

            builder.Property(c => c.CodSugestoes)
                .IsRequired()
                .HasColumnName("CodSugestoes");

            builder.Property(c => c.Criatividade)
                .IsRequired()
                .HasColumnName("Criatividade");

            builder.Property(c => c.DataInicio)
                .IsRequired()
                .HasColumnName("DataInicio");

            builder.Property(c => c.DataFim)
                .IsRequired()
                .HasColumnName("DataFim");

            builder.Property(c => c.ReducaoCusto)
                .IsRequired()
                .HasColumnName("ReducaoCusto");

            builder.Property(c => c.Investimento)
                .IsRequired()
                .HasColumnName("Investimento");
        }
    }
}
