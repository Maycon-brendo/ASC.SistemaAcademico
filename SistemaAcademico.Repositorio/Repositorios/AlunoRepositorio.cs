using SistemaAcademico.Dominio.Contratos;
using SistemaAcademico.Dominio.Entidades;
using SistemaAcademico.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.Repositorio.Repositorios
{
    public class AlunoRepositorio : BaseRepositorio<Aluno>, IAlunoRepositorio
    {
        public AlunoRepositorio(SistemaAcademicoContexto sistemaAcademicoContexto) : base(sistemaAcademicoContexto)
        {
        }
    }
}
