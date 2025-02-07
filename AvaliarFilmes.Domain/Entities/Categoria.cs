using AvaliarFilmes.Domain.Base;

namespace AvaliarFilmes.Domain.Entities
{
    public class Categoria : BaseEntity<int>
    {
        public Categoria()
        {
        }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public string Nome { get; set; }
    }
}