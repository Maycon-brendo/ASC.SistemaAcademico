using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.Dominio.Entidades
{
	public class Aluno
	{
		public int Id { get; set; }

		public string Nome { get; set; }

		public int Idade { get; set; }

		public virtual Turma Turma { get; set; }

		public int IdTurma { get; set; }

		public virtual ICollection<ProvaAluno> ProvaAlunos{ get; set; }

		
	}
}
