using Crud.Dominio.ObjetoDevalor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Crud.Repositorio.Config
{
    public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
    {
        public void Configure(EntityTypeBuilder<Grupo> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");


        }
    }
}
