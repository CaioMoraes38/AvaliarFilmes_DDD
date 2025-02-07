using AvaliarFilmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AvaliarFilmes.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) :
            base(options)
        {
            Database.EnsureCreated(); 
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais podem ser adicionadas aqui
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Filme>().ToTable("Filmes");
            modelBuilder.Entity<Avaliacao>().ToTable("Avaliacoes");

            // Configurações de relacionamentos
            modelBuilder.Entity<Filme>()
                .HasOne<Categoria>()
                .WithMany()
                .HasForeignKey(f => f.IdCategoria);

            modelBuilder.Entity<Avaliacao>()
                .HasOne<Filme>()
                .WithMany()
                .HasForeignKey(a => a.IdFilme);

            modelBuilder.Entity<Avaliacao>()
                .HasOne<Usuario>()
                .WithMany()
                .HasForeignKey(a => a.IdUsuario);
        }
    }
}