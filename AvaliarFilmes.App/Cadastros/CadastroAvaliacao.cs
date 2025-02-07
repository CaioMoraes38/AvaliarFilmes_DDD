using AvaliarFilmes.Domain.Entities;
using AvaliarFilmes.Domain.Base;
using AvaliarFilmes.Service.Validators;
using AvaliarFilmes.App.Outros;
using ReaLTaiizor.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AvaliarFilmes.App.Cadastros
{
    public partial class CadastroAvaliacao : RoyalForm
    {
        private readonly IBaseService<Avaliacao> _avaliacaoService;
        private readonly IBaseService<Filme> _filmeService;

        public CadastroAvaliacao(IBaseService<Avaliacao> avaliacaoService, IBaseService<Filme> filmeService)
        {
            _avaliacaoService = avaliacaoService;
            _filmeService = filmeService;
            InitializeComponent();
            CarregarFilmes();
        }

        private void CarregarFilmes()
        {
            var filmes = _filmeService.Get<Filme>().ToList();
            comboBoxFilmes.DataSource = filmes;
            comboBoxFilmes.DisplayMember = "Titulo";
            comboBoxFilmes.ValueMember = "Id";
        }

        private void comboBoxFilmes_DoubleClick(object sender, EventArgs e)
        {
            if (comboBoxFilmes.SelectedValue != null)
            {
                int filmeId = (int)comboBoxFilmes.SelectedValue;
                // Adicione qualquer lógica adicional necessária aqui
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (comboBoxFilmes.SelectedValue == null)
            {
                MessageBox.Show("Por favor, selecione um filme.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComentario.Text))
            {
                MessageBox.Show("Por favor, insira um comentário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericNota.Value == 0)
            {
                MessageBox.Show("Por favor, insira uma nota válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novaAvaliacao = new Avaliacao
            {
                IdFilme = (int)comboBoxFilmes.SelectedValue,
                IdUsuario = FormPrincipal.Usuario.Id,
                Comentario = txtComentario.Text,
                Nota = (int)numericNota.Value
            };

            try
            {
                _avaliacaoService.Add<Avaliacao, Avaliacao, AvaliacaoValidator>(novaAvaliacao);
                MessageBox.Show("Avaliação cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar avaliação: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}