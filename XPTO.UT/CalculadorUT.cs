using Microsoft.VisualStudio.TestTools.UnitTesting;
using XPTO.UI;

namespace XPTO.UT
{
    [TestClass]
    public class CalculadorUT
    {
        [TestMethod]
        public void Deve_Calcular()
        {
            Calculador calculador = new Calculador();
            int digito = 9, multiplicador = 5;

            int valor = calculador.Calcular(digito, multiplicador);

            Assert.AreEqual(45, valor);
        }
    }
}
