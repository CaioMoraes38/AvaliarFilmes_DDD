using AvaliarFilmes.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace TestAvaliarFilmes.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Filme> Filmes { get; set; }
            public DbSet<Categoria> Categorias { get; set; }
            public DbSet<Avaliacao> Avaliacoes { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "AvaliarFilmes";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]
        public void TestInsertCategorias()
        {
            using (var context = new MyDbContext())
            {
                var categoria = new Categoria
                {
                    Nome = "Ação"
                };
                context.Categorias.Add(categoria);

                categoria = new Categoria
                {
                    Nome = "Comédia"
                };
                context.Categorias.Add(categoria);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListCategorias()
        {
            using (var context = new MyDbContext())
            {
                foreach (var categoria in context.Categorias)
                {
                    Console.WriteLine(JsonSerializer.Serialize(categoria));
                }
            }
        }

        [TestMethod]
        public void TestInsertFilmes()
        {
            using (var context = new MyDbContext())
            {
                var categoria = context.Categorias.FirstOrDefault(c => c.Id == 1);
                var filme = new Filme
                {
                    Titulo = "Filme de Ação",
                    Descricao = "Um filme cheio de ação.",
                    AnoLancamento = 2024,
                    Duracao = 120,
                    IdCategoria = categoria.Id
                };
                context.Filmes.Add(filme);

                categoria = context.Categorias.FirstOrDefault(c => c.Id == 2);
                filme = new Filme
                {
                    Titulo = "Filme de Comédia",
                    Descricao = "Um filme muito engraçado.",
                    AnoLancamento = 2024,
                    Duracao = 90,
                    IdCategoria = categoria.Id
                };
                context.Filmes.Add(filme);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListFilmes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var filme in context.Filmes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(filme));
                }
            }
        }

        [TestMethod]
        public void TestInsertUsuarios()
        {
            using (var context = new MyDbContext())
            {
                var usuario = new Usuario
                {
                    Nome = "Caio de Moraes",
                    Email = "Santos@gmail.com",
                    Senha = "senha123"
                };
                context.Usuarios.Add(usuario);

                usuario = new Usuario
                {
                    Nome = "João Dias",
                    Email = "joao@example.com",
                    Senha = "senha456"
                };
                context.Usuarios.Add(usuario);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListUsuarios()
        {
            using (var context = new MyDbContext())
            {
                foreach (var usuario in context.Usuarios)
                {
                    Console.WriteLine(JsonSerializer.Serialize(usuario));
                }
            }
        }

        [TestMethod]
        public void TestInsertAvaliacoes()
        {
            using (var context = new MyDbContext())
            {
                var filme = context.Filmes.FirstOrDefault(f => f.Id == 1);
                var usuario = context.Usuarios.FirstOrDefault(u => u.Id == 1);
                var avaliacao = new Avaliacao
                {
                    Nota = 5,
                    Comentario = "Excelente filme!",
                    IdFilme = filme.Id,
                    IdUsuario = usuario.Id
                };
                context.Avaliacoes.Add(avaliacao);

                filme = context.Filmes.FirstOrDefault(f => f.Id == 2);
                usuario = context.Usuarios.FirstOrDefault(u => u.Id == 2);
                avaliacao = new Avaliacao
                {
                    Nota = 4,
                    Comentario = "Muito engraçado!",
                    IdFilme = filme.Id,
                    IdUsuario = usuario.Id
                };
                context.Avaliacoes.Add(avaliacao);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAvaliacoes()
        {
            using (var context = new MyDbContext())
            {
                foreach (var avaliacao in context.Avaliacoes)
                {
                    Console.WriteLine(JsonSerializer.Serialize(avaliacao));
                }
            }
        }
    }
}