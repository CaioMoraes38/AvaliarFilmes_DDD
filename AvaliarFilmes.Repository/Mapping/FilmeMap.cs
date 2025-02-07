using AvaliarFilmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvaliarFilmes.Repository.Mapping
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filmes");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Titulo)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(prop => prop.Descricao)
                .HasColumnType("text");

            builder.Property(prop => prop.AnoLancamento)
                .HasColumnType("year");

            builder.Property(prop => prop.Duracao)
                .HasColumnType("int");

            builder.Property(prop => prop.ImagemFilme)
                .HasColumnType("blob");

            builder.HasOne<Categoria>()
                .WithMany()
                .HasForeignKey(prop => prop.IdCategoria);
        }
    }
}