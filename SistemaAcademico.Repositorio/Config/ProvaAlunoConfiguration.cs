using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAcademico.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.Repositorio.Config
{
    public class ProvaAlunoConfiguration : IEntityTypeConfiguration<ProvaAluno>
    {
        public void Configure(EntityTypeBuilder<ProvaAluno> builder)
        {
            builder.HasKey(pa => new { pa.IdAluno, pa.IdProva });
            builder.Property(pa => pa.Nota).IsRequired();

            builder.HasOne(pa => pa.Aluno).WithMany(a => a.ProvaAlunos);
            builder.HasOne(pa => pa.Prova).WithMany(p => p.ProvaAlunos);


            
        }
    }
}
