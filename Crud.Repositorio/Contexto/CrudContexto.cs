using Crud.Dominio.Entidades;
using Crud.Dominio.ObjetoDevalor;
using Crud.Repositorio.Config;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
namespace Crud.Repositorio.Contexto
{
    public class CrudContexto : DbContext
    {
        
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo > Grupos { get; set; }

        public CrudContexto(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
