namespace AvaliarFilmes.App.Models
{
    public class FilmeModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public int? AnoLancamento { get; set; }
        public int? Duracao { get; set; }
        public int IdCategoria { get; set; }
        public byte[]? ImagemFilme { get; set; }
        public CategoriaModel? Categoria { get; set; }
    }
}