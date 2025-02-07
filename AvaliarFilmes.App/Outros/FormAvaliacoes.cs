using AvaliarFilmes.App.Models;
using AvaliarFilmes.Domain.Entities;
using AvaliarFilmes.Domain.Base;
using ReaLTaiizor.Forms;
using System.Linq;

namespace AvaliarFilmes.App
{
    public partial class FormAvaliacoes : RoyalForm
    {
        private readonly FilmeModel _filme;
        private readonly IBaseService<Avaliacao> _avaliacaoService;
        private readonly IBaseService<Usuario> _usuarioService;

        public FormAvaliacoes(FilmeModel filme, IBaseService<Avaliacao> avaliacaoService, IBaseService<Usuario> usuarioService)
        {
            _filme = filme;
            _avaliacaoService = avaliacaoService;
            _usuarioService = usuarioService;
            InitializeComponent();
            CarregarAvaliacoes();
        }

        private void CarregarAvaliacoes()
        {
            lblTitulo.Text = _filme.Titulo;

            var avaliacoes = _avaliacaoService.Get<Avaliacao>()
                .Where(a => a.IdFilme == _filme.Id)
                .Select(a => new
                {
                    a.Id,
                    a.Comentario,
                    a.Nota,
                    UsuarioNome = _usuarioService.Get<Usuario>().FirstOrDefault(u => u.Id == a.IdUsuario)?.Nome
                })
                .ToList();

            dataGridViewAvaliacoes.DataSource = avaliacoes;
        }
    }
}