using AvaliarFilmes.Domain.Entities;
using AvaliarFilmes.Domain.Base;
using AvaliarFilmes.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace AvaliarFilmes.App.Cadastros
{
    public partial class CadastroCategoria : RoyalForm
    {
        private readonly IBaseService<Categoria> _categoriaService;

        public CadastroCategoria(IBaseService<Categoria> categoriaService)
        {
            _categoriaService = categoriaService;
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeCategoria.Text))
            {
                MessageBox.Show("Por favor, insira o nome da categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var novaCategoria = new Categoria
            {
                Nome = txtNomeCategoria.Text
            };

            try
            {
                _categoriaService.Add<Categoria, Categoria, CategoriaValidator>(novaCategoria);
                MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar categoria: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}