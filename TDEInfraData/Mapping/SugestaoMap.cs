using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEInfraData.Mapping
{
    public class SugestaoMap : IEntityTypeConfiguration<Sugestoes>
    {
        public void Configure(EntityTypeBuilder<Sugestoes> builder)
        {
            builder.ToTable("Sugestoes");

            builder.HasKey(c => c.CodSugestoes);


            builder.Property(c => c.CodFuncionario)
                .IsRequired()
                .HasColumnName("CodFuncionario");

            builder.Property(c => c.CodCampanha)
                .IsRequired()
                .HasColumnName("CodCampanha");

            builder.Property(c => c.Descrição)
                .IsRequired()
                .HasColumnName("Descrição");

            builder.Property(c => c.Custo)
                .IsRequired()
                .HasColumnName("Custo");

            builder.Property(c => c.DataInicio)
                   .IsRequired()
                   .HasColumnName("DataInicio");

            builder.Property(c => c.DataFim)
                .IsRequired()
                .HasColumnName("DataFim");

            builder.Property(c => c.ReduçãoCusto)
                .IsRequired()
                .HasColumnName("ReduçãoCusto");
        }
    }
}
