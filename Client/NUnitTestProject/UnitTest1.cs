using NUnit.Framework;
using Client;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("Ola")]
        [TestCase("Testando")]
        public void MostrarMensagemDigitada(string message)
        {
            UI.DisplayMessage(message);
            Assert.Pass();
        }
    }
}
