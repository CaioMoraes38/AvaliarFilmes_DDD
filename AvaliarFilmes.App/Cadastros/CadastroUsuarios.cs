using AvaliarFilmes.Domain.Entities;
using AvaliarFilmes.Service.Validators;
using AvaliarFilmes.Domain.Base;
using System.Drawing.Imaging;
using ReaLTaiizor.Forms;


namespace AvaliarFilmes.App.Cadastros
{
    public partial class CadastroUsuarios : RoyalForm
    {
        private readonly IBaseService<Usuario> _usuarioService;

        public CadastroUsuarios(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
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

        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = txtNome.Text;
            usuario.Email = txtEmail.Text;
            usuario.Senha = txtSenha.Text;

            if (pictureBoxFoto.Image != null)
            {
                usuario.FotoUsuario = ImageToByteArray(pictureBoxFoto.Image);
            }
        }

        private void Salvar()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("O campo Nome não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (pictureBoxFoto.Image == null)
                {
                    MessageBox.Show("A imagem é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var usuario = new Usuario();
                PreencheObjeto(usuario);

                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Avaliar Filmes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarImagemDoBanco(Usuario usuario)
        {
            if (usuario.FotoUsuario != null && usuario.FotoUsuario.Length > 0)
            {
                pictureBoxFoto.Image = ByteArrayToImage(usuario.FotoUsuario);
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Selecione uma imagem",
                Filter = "Arquivos de imagem|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void airButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}