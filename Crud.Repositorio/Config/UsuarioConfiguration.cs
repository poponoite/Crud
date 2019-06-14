using Crud.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
namespace Crud.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

        }
    }
}
