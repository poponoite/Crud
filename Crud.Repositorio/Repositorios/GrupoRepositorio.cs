using Crud.Dominio.Contratos;
using Crud.Dominio.ObjetoDevalor;
using Crud.Repositorio.Contexto;

namespace Crud.Repositorio.Repositorios
{
    public class GrupoRepositorio : BaseRepositorio<Grupo>, IGrupoRepositorio
    {
        public GrupoRepositorio(CrudContexto crudContexto) : base(crudContexto)
        {
        }
    }
}
