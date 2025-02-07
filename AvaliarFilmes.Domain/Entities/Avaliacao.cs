using AvaliarFilmes.Domain.Base;

namespace AvaliarFilmes.Domain.Entities
{
    public class Avaliacao : BaseEntity<int>
    {
        public Avaliacao()
        {
        }

        public Avaliacao(int id, int idFilme, int idUsuario, int nota, string? comentario, DateTime dataAvaliacao)
        {
            Id = id;
            IdFilme = idFilme;
            IdUsuario = idUsuario;
            Nota = nota;
            Comentario = comentario;
            DataAvaliacao = dataAvaliacao;
        }

        public int IdFilme { get; set; }
        public int IdUsuario { get; set; }
        public int Nota { get; set; }
        public string? Comentario { get; set; }
        public DateTime DataAvaliacao { get; set; } = DateTime.Now;
    }
}