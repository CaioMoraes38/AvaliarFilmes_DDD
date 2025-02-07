using AvaliarFilmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvaliarFilmes.Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.HasIndex(prop => prop.Email)
                .IsUnique();

            builder.Property(prop => prop.Senha)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.FotoUsuario)
                .HasColumnType("blob");
        }
    }
}