using AvaliarFilmes.Domain.Base;

namespace AvaliarFilmes.Domain.Entities
{
    public class Usuario : BaseEntity<int>
    {
        public Usuario()
        {
        }

        public Usuario(int id, string nome, string email, string senha, byte[]? fotoUsuario)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            FotoUsuario = fotoUsuario;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public byte[]? FotoUsuario { get; set; }
    }
}