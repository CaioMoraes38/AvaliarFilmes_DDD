using AvaliarFilmes.Domain.Entities;
using AvaliarFilmes.Service.Validators;
using AvaliarFilmes.Domain.Base;
using System.Drawing.Imaging;
using ReaLTaiizor.Forms;

namespace AvaliarFilmes.App.Cadastros
{
    public partial class CadastroFilme : RoyalForm
    {
        private readonly IBaseService<Filme> _filmeService;
        private readonly IBaseService<Categoria> _categoriaService;

        public CadastroFilme(IBaseService<Filme> filmeService, IBaseService<Categoria> categoriaService)
        {
            _filmeService = filmeService;
            _categoriaService = categoriaService;
            InitializeComponent();
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            var categorias = _categoriaService.Get<Categoria>().ToList();
            comboBoxCategorias.DataSource = categorias;
            comboBoxCategorias.DisplayMember = "Nome";
            comboBoxCategorias.ValueMember = "Id";
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void PreencheObjeto(Filme filme)
        {
            filme.Titulo = txtTitulo.Text;
            filme.Descricao = txtDescricao.Text;
            filme.AnoLancamento = int.Parse(txtAnoLancamento.Text);
            filme.Duracao = int.Parse(txtDuracao.Text);
            filme.IdCategoria = (int)comboBoxCategorias.SelectedValue;

            if (pictureBoxImagemFilme.Image != null)
            {
                filme.ImagemFilme = ImageToByteArray(pictureBoxImagemFilme.Image);
            }
        }

        private void Salvar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                {
                    MessageBox.Show("O campo Título não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAnoLancamento.Text) || !int.TryParse(txtAnoLancamento.Text, out int anoLancamento))
                {
                    MessageBox.Show("Ano de lançamento inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDuracao.Text) || !int.TryParse(txtDuracao.Text, out int duracao))
                {
                    MessageBox.Show("Duração inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var filme = new Filme();
                PreencheObjeto(filme);

                _filmeService.Add<Filme, Filme, FilmeValidator>(filme);

                MessageBox.Show("Filme cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Avaliar Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarImagemDoBanco(Filme filme)
        {
            if (filme.ImagemFilme != null && filme.ImagemFilme.Length > 0)
            {
                pictureBoxImagemFilme.Image = ByteArrayToImage(filme.ImagemFilme);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCarregaImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione uma imagem",
                Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxImagemFilme.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            var cadastroCategoriaForm = new CadastroCategoria(_categoriaService);
            cadastroCategoriaForm.ShowDialog();
            CarregarCategorias();
        }
    }
}