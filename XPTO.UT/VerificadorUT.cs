using Microsoft.VisualStudio.TestTools.UnitTesting;
using XPTO.UI;

namespace XPTO.UT
{
    [TestClass]
    public class VerificadorUT
    {
        [TestMethod]
        public void Deve_Verificar()
        {
            //0924-2 1790-D
            Verificador verificador = new Verificador();
            string digito = "D", resultado = string.Empty, resposta = "verdadeiro";

            resultado = verificador.Verificar(digito);

            Assert.AreEqual(resultado, resposta);
        }
    }
}
