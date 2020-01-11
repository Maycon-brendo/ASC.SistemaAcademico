using SistemaAcademico.Dominio.Contratos;
using SistemaAcademico.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaAcademico.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly SistemaAcademicoContexto SistemaAcademicoContexto;

        public BaseRepositorio(SistemaAcademicoContexto sistemaAcademicoContexto)
        {
            SistemaAcademicoContexto = sistemaAcademicoContexto;
        }
        public void Adicionar(TEntity entity)
        {
            SistemaAcademicoContexto.Set<TEntity>().Add(entity);
            SistemaAcademicoContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            SistemaAcademicoContexto.Set<TEntity>().Update(entity);
            SistemaAcademicoContexto.SaveChanges();
        }

        public void Dispose()
        {
            SistemaAcademicoContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return SistemaAcademicoContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return SistemaAcademicoContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            SistemaAcademicoContexto.Remove(entity);
            SistemaAcademicoContexto.SaveChanges();
        }
    }
}
