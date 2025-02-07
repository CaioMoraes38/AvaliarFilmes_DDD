using AutoMapper;
using AvaliarFilmes.Domain.Base;
using AvaliarFilmes.Domain.Entities;
using AvaliarFilmes.Repository.Context;
using AvaliarFilmes.Repository.Repository;
using AvaliarFilmes.Service.Services;
using AvaliarFilmes.App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AvaliarFilmes.App.Cadastros;
using AvaliarFilmes.App.Outros;

namespace AvaliarFilmes.App.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServiceProvider;
        public static void ConfigureServices()
        {
            Services = new ServiceCollection();

            #region Banco de dados
            var strCon = File.ReadAllText(@"C:\Users\Caio\source\repos\AvaliarFilmes\AvaliarFilmes.App\Config\ConfigBanco.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(0);
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Filme>, BaseRepository<Filme>>();
            Services.AddScoped<IBaseRepository<Categoria>, BaseRepository<Categoria>>();
            Services.AddScoped<IBaseRepository<Avaliacao>, BaseRepository<Avaliacao>>();
            #endregion

            #region Formulários
            Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroFilme, CadastroFilme>();
            Services.AddTransient<CadastroAvaliacao, CadastroAvaliacao>();
            Services.AddTransient<CadastroCategoria, CadastroCategoria>();
            Services.AddTransient<CadastroUsuarios, CadastroUsuarios>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Filme>, BaseService<Filme>>();
            Services.AddScoped<IBaseService<Categoria>, BaseService<Categoria>>();
            Services.AddScoped<IBaseService<Avaliacao>, BaseService<Avaliacao>>();
            
            #endregion

            #region Mappings
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();
                config.CreateMap<Filme, FilmeModel>();
                config.CreateMap<Categoria, CategoriaModel>();
                config.CreateMap<Avaliacao, AvaliacaoModel>();
            }).CreateMapper());
            #endregion

            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}