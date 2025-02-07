namespace AvaliarFilmes.App.Models
{
    public class AvaliacaoModel
    {
        public int Id { get; set; }
        public int IdFilme { get; set; }
        public int IdUsuario { get; set; }
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public DateTime DataAvaliacao { get; set; }
        public FilmeModel? Filme { get; set; }
        public UsuarioModel? Usuario { get; set; }
    }
}