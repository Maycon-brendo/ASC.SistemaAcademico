using SistemaAcademico.Dominio.Contratos;
using SistemaAcademico.Dominio.Entidades;
using SistemaAcademico.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademico.Repositorio.Repositorios
{
    public class ProvaAlunoRepositorio : BaseRepositorio<ProvaAluno>, IProvaAlunoRepositorio
    {
        public ProvaAlunoRepositorio(SistemaAcademicoContexto sistemaAcademicoContexto) : base(sistemaAcademicoContexto)
        {
        }
    }
}
