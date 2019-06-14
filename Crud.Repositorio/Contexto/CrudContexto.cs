using Crud.Dominio.Entidades;
using Crud.Dominio.ObjetoDevalor;
using Crud.Repositorio.Config;
using Microsoft.EntityFrameworkCore;
namespace Crud.Repositorio.Contexto
{
    public class CrudContexto : DbContext
    {
       
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Grupo > Grupos { get; set; }

        public CrudContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());


           /* modelBuilder.Entity<Grupo>().HasData(
                new Grupo()
                {
                    Id = 1,
                    Nome = "TSA"
                },
                new Grupo()
                {
                    Id = 2,
                    Nome = "LYNX"
                }
                );

    */
              
            base.OnModelCreating(modelBuilder);
        }
    }
}
