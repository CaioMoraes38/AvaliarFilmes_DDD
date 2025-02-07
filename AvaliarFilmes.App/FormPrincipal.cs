using AvaliarFilmes.App.Cadastros;
using AvaliarFilmes.App.Models;
using AvaliarFilmes.App.Outros;
using AvaliarFilmes.Domain.Base;
using AvaliarFilmes.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AvaliarFilmes.App
{
    public partial class FormPrincipal : RoyalForm
    {
        public static Usuario Usuario { get; set; }
        private readonly IServiceProvider _serviceProvider;
        private readonly IBaseService<Filme> _filmeService;

        public FormPrincipal(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _filmeService = _serviceProvider.GetService<IBaseService<Filme>>();
            if (_filmeService == null)
            {
                throw new InvalidOperationException("FilmeService is not registered.");
            }
            InitializeComponent();
            CarregaLogin();
            btnCadastroAvaliacao.Click += BtnCadastroAvaliacao_Click;
            btnCadastroFilme.Click += BtnCadastroFilme_Click;
            dgvFilmes.CellDoubleClick += DgvFilmes_CellDoubleClick; // Adiciona o evento de duplo clique
            CarregarFilmes();

        }

        private void CarregaLogin()
        {
            var login = _serviceProvider.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFilme>();
        }

        private void avaliacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAvaliacao>();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFilme>();
        }

        private void Feed_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var form = _serviceProvider.GetService<TFormulario>();
            if (form != null && !form.IsDisposed)
            {
                form.FormClosed += (s, args) => CarregarFilmes();
                form.Show();
                form.BringToFront();
                form.Activate();
            }
        }

        private void BtnCadastroAvaliacao_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroAvaliacao>();
        }

        private void BtnCadastroFilme_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFilme>();
        }

        private void CarregarFilmes()
        {
            var filmes = _filmeService.Get<FilmeModel>().ToList();
            dgvFilmes.Rows.Clear();
            foreach (var filme in filmes)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dgvFilmes);
                row.Cells[0].Value = filme.Titulo;
                row.Cells[1].Value = filme.AnoLancamento;
                row.Cells[2].Value = filme.Descricao; // Adiciona a descrição do filme
                if (filme.ImagemFilme != null && filme.ImagemFilme.Length > 0)
                {
                    try
                    {
                        using (var ms = new System.IO.MemoryStream(filme.ImagemFilme))
                        {
                            row.Cells[3].Value = Image.FromStream(ms);
                        }
                    }
                    catch (ArgumentException)
                    {
                        row.Cells[3].Value = null;
                    }
                }
                row.Tag = filme; // Armazena o objeto filme na propriedade Tag da linha
                dgvFilmes.Rows.Add(row);
            }
        }

        private void DgvFilmes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvFilmes.Rows[e.RowIndex];
                var filme = selectedRow.Tag as FilmeModel;
                if (filme != null)
                {
                    var avaliacaoService = _serviceProvider.GetService<IBaseService<Avaliacao>>();
                    var usuarioService = _serviceProvider.GetService<IBaseService<Usuario>>();
                    if (avaliacaoService != null && usuarioService != null)
                    {
                        var formAvaliacoes = new FormAvaliacoes(filme, avaliacaoService, usuarioService);
                        formAvaliacoes.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Serviços de avaliação ou usuário não estão registrados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}