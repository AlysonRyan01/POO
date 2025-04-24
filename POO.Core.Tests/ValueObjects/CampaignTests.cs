using POO.Core.ValueObjects;
using POO.Core.ValueObjects.Exceptions;

namespace POO.Core.Tests.ValueObjects
{
    [TestClass]
    public class CampaignTests
    {
        private const string ValidSource = "google";
        private const string ValidMedium = "cpc";
        private const string ValidName = "promo-summer";

        private const string InvalidNull = null;
        private const string InvalidEmpty = "";

        [TestMethod]
        public void deve_retornar_excecao_quando_source_for_vazia()
        {
            try
            {
                var Campaign = new Campaign(InvalidEmpty, ValidMedium, ValidName);
                Assert.Fail();
            }
            catch(InvalidCampaignException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void deve_retornar_excecao_quando_source_for_nula()
        {
            try
            {
                var Campaign = new Campaign(InvalidNull, ValidMedium, ValidName);
                Assert.Fail();
            }
            catch(InvalidCampaignException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void nao_deve_retornar_excecao_quando_source_for_valida()
        {
            try
            {
                var Campaign = new Campaign(ValidSource, ValidMedium, ValidName);
                Assert.IsTrue(true);
            }
            catch(InvalidCampaignException)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void deve_retornar_excecao_quando_medium_for_vazia()
        {
            try
            {
                var Campaign = new Campaign(ValidSource, InvalidEmpty, ValidName);
                Assert.Fail();
            }
            catch(InvalidCampaignException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void deve_retornar_excecao_quando_medium_for_nula()
        {
            try
            {
                var Campaign = new Campaign(ValidSource, InvalidNull, ValidName);
                Assert.Fail();
            }
            catch(InvalidCampaignException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void nao_deve_retornar_excecao_quando_medium_for_valida()
        {
            try
            {
                var Campaign = new Campaign(ValidSource, ValidMedium, ValidName);
                Assert.IsTrue(true);
            }
            catch(InvalidCampaignException)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void deve_retornar_excecao_quando_name_for_vazia()
        {
            try
            {
                var campaign = new Campaign(ValidSource, ValidMedium, InvalidEmpty);
                Assert.Fail();
            }
            catch (InvalidCampaignException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void deve_retornar_excecao_quando_name_for_nula()
        {
            try
            {
                var campaign = new Campaign(ValidSource, ValidMedium, InvalidNull);
                Assert.Fail();
            }
            catch (InvalidCampaignException)
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void nao_deve_retornar_excecao_quando_name_for_valida()
        {
            try
            {
                var campaign = new Campaign(ValidSource, ValidMedium, ValidName);
                Assert.IsTrue(true);
            }
            catch (InvalidCampaignException)
            {
                Assert.Fail();
            }
        }
    }
}