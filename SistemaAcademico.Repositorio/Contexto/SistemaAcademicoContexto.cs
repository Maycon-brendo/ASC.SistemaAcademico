using Microsoft.EntityFrameworkCore;
using SistemaAcademico.Dominio.Entidades;
using SistemaAcademico.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.Repositorio.Contexto
{
    public class SistemaAcademicoContexto : DbContext
    {

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Prova> Provas{ get; set; }
        public DbSet<ProvaAluno> ProvaAlunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public SistemaAcademicoContexto(DbContextOptions options) : base(options)
        {

        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new AlunoConfiguration());
                modelBuilder.ApplyConfiguration(new ProvaAlunoConfiguration());
                modelBuilder.ApplyConfiguration(new ProvaConfiguration());
                modelBuilder.ApplyConfiguration(new TurmaConfiguration());

                base.OnModelCreating(modelBuilder);
            }
    }

    
}
