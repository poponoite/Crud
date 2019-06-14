using Crud.Dominio.Contratos;
using Crud.Dominio.Entidades;
using Crud.Repositorio.Contexto;

namespace Crud.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(CrudContexto crudContexto) : base(crudContexto)
        {
        }
    }
}
