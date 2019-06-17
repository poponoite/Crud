using Crud.Dominio.Contratos;
using Crud.Repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace Crud.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly CrudContexto CrudContexto;

        public BaseRepositorio(CrudContexto crudContexto)
        {
            CrudContexto = crudContexto;
        }

        public void Adicionar(TEntity entity)
        {
            CrudContexto.Set<TEntity>().Add(entity);
            CrudContexto.SaveChanges();
            //throw new NotImplementedException();          
        }

        public void Atualizar(TEntity entity)
        {
            CrudContexto.Set<TEntity>().Update(entity);
            CrudContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return CrudContexto.Set<TEntity>().Find(id);

        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return CrudContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            CrudContexto.Remove(entity);
            CrudContexto.SaveChanges();
        }

        public void Dispose()
        {
            CrudContexto.Dispose();
        }
    }
}
