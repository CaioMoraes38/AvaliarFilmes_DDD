using AvaliarFilmes.Domain.Base;

namespace AvaliarFilmes.Domain.Entities
{
    public class Filme : BaseEntity<int>
    {
        public Filme()
        {
        }

        public Filme(int id, string titulo, string? descricao, int? anoLancamento, int? duracao, int idCategoria, byte[]? imagemFilme)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            AnoLancamento = anoLancamento;
            Duracao = duracao;
            IdCategoria = idCategoria;
            ImagemFilme = imagemFilme;
        }

        public string Titulo { get; set; }
        public string? Descricao { get; set; }
        public int? AnoLancamento { get; set; }
        public int? Duracao { get; set; }
        public int IdCategoria { get; set; }
        public byte[]? ImagemFilme { get; set; }
    }
}