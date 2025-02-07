using AutoMapper;
using AvaliarFilmes.Domain.Base;
using AvaliarFilmes.Domain.Entities;
using AvaliarFilmes.Repository.Context;
using AvaliarFilmes.Repository.Repository;
using AvaliarFilmes.Service.Services;
using AvaliarFilmes.Service.Validators;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Json;

namespace TestAvaliarFilmes.Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "AvaliarFilmes";
                var username = "root";
                var password = "";
                var strCon = $"Server={server};Port={port};Database={database};" +
                            $"Uid={username};Pwd={password}";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });

            services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, Usuario>();
            }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestInsertUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();
            var usuario = new Usuario
            {
                Nome = "Caio",
                Email = "caio@gmail.com",
                Senha = "123",
                
            };

            var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectUsuario()
        {
            var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();

            var result = usuarioService.Get<Usuario>();
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}