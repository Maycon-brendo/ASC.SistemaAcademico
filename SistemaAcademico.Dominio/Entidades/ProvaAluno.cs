using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.Dominio.Entidades
{
	public class ProvaAluno
	{
		public int Id { get; set; }

		public int IdAluno { get; set; }
		public virtual Aluno Aluno { get; set; }

		public int IdProva { get; set; }
		public virtual Prova Prova { get; set; }

		public double Nota { get; set; }
	}
}
