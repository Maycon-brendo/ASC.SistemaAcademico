using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAcademico.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.Repositorio.Config
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.HasKey(a => a.Id);
            builder
                .Property(a => a.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(a => a.Idade)
                .IsRequired();
            builder.Property(a => a.NotaFinal)
                .IsRequired();                
            builder.HasOne(a => a.Turma);

        }
    }
}
