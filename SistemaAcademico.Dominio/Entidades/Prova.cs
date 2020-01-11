using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.Dominio.Entidades
{
	public class Prova
	{

		public int Id { get; set; }

		public string Nome { get; set; }


		public virtual ICollection<ProvaAluno> ProvaAlunos { get; set; }

	}

}
