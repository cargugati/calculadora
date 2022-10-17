using NUnit.Framework;

namespace Calculadora.Tests
{
    [TestFixture]    
    public class CalculadoraTests
    {
        [Test]
        public void DeveAdicionarDoisNumeros()
        {
            //SUT
            var sut = new CalculadoraSimples();

            var resultado = sut.Adicionar(5, 5);

            Assert.That(resultado, Is.EqualTo(10));
        }

        [Test]
        public void DeveMultiplicarDoisNumeros()
        {
            //SUT
            var sut = new CalculadoraSimples();

            var resultado = sut.Multiplicar(5, 3);

            Assert.That(resultado, Is.EqualTo(15));
        }
    }
}