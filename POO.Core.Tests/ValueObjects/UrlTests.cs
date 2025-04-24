using POO.Core.ValueObjects;
using POO.Core.ValueObjects.Exceptions;

namespace POO.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        [TestMethod]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            try
            {
                var url = new Url("banana");
                Assert.Fail();
            }
            catch (InvalidUrlException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
        {
            try
            {
                var url = new Url("https://tvseletronica.com");
                Assert.IsTrue(true);
            }
            catch (InvalidUrlException)
            {
                Assert.Fail();
            }
        }
    }
}