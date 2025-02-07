using AvaliarFilmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AvaliarFilmes.Repository.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.ToTable("Avaliacoes");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nota)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(prop => prop.Comentario)
                .HasColumnType("text");

            builder.Property(prop => prop.DataAvaliacao)
                .IsRequired()
                .HasColumnType("datetime")
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasOne<Filme>()
                .WithMany()
                .HasForeignKey(prop => prop.IdFilme);

            builder.HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(prop => prop.IdUsuario);
        }
    }
}