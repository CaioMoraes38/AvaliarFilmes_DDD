using AvaliarFilmes.Domain.Entities;
using System.Diagnostics;
using System.Text.Json;

namespace TestAvaliarFilmes.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestCategoria()
        {
            Categoria categoria = new Categoria { Id = 1, Nome = "A��o" };

            Debug.WriteLine(JsonSerializer.Serialize(categoria));

            Assert.AreEqual(categoria.Nome, "A��o");
        }
    }
}