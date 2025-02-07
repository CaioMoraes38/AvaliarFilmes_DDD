using AvaliarFilmes.App.Cadastros;
using AvaliarFilmes.Domain.Base;
using AvaliarFilmes.Domain.Entities;
using AvaliarFilmes.Service.Validators;
using ReaLTaiizor.Forms;


namespace AvaliarFilmes.App.Outros
{
    public partial class Login : RoyalForm
    {
        private readonly IBaseService<Usuario> _usuarioService;

        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }

        private Usuario? ObterUsuario(string nome, string senha)
        {
            ChecaExistenciaDeUsuarioCadastrado();
            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Nome == nome).FirstOrDefault();
            if (usuario == null)
                return null;
            return usuario.Senha != senha ? null : usuario;
        }

        private void ChecaExistenciaDeUsuarioCadastrado()
        {
            var usuarios = _usuarioService.Get<Usuario>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    Nome = "admin",
                    Senha = "admin",
                    FotoUsuario = null,
                    Email = "admin@gmail.com"
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            Usuario usuario = ObterUsuario(txtUsuario.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválida!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Usuário encontrado!", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Remova a linha abaixo se não houver necessidade de atualizar o usuário
                // usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);

                // Define o usuário logado no FormPrincipal
                FormPrincipal.Usuario = usuario;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtRegistrar_Click(object sender, EventArgs e)
        {
            CadastroUsuarios cadastroUsuarios = new CadastroUsuarios(_usuarioService);
            cadastroUsuarios.ShowDialog();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}