using GuiaDaPesca.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class PeixeCapturadoTest
    {
        [TestMethod]
        public void PreenchimentoCorreto()
        {
            PeixeCapturado peixeCapturado = new PeixeCapturado(new Peixe("Pacu"), 10, 5);

            Assert.Equals("Pacu", peixeCapturado.Peixe.Nome);
            Assert.Equals(10, peixeCapturado.Peso);
            Assert.Equals(5, peixeCapturado.Tamanho);
        }

        [TestMethod]
        public void AlterarPeixe()
        {
            PeixeCapturado peixeCapturado = new PeixeCapturado(new Peixe("Pacu"), 10, 5);

            Assert.Equals("Pacu", peixeCapturado.Peixe.Nome);

            peixeCapturado.AlterarPeixe(new Peixe("Tilapia"));

            Assert.Equals("Tilapia", peixeCapturado.Peixe.Nome);
            Assert.Equals(10, peixeCapturado.Peso);
            Assert.Equals(5, peixeCapturado.Tamanho);
        }

        [TestMethod]
        public void AlterarPeso()
        {
            PeixeCapturado peixeCapturado = new PeixeCapturado(new Peixe("Pacu"), 10, 5);

            Assert.Equals(10, peixeCapturado.Peso);

            peixeCapturado.AlterarPeso(50);

            Assert.Equals("Pacu", peixeCapturado.Peixe.Nome);
            Assert.Equals(50, peixeCapturado.Peso);
            Assert.Equals(5, peixeCapturado.Tamanho);
        }

        [TestMethod]
        public void AlterarTamanho()
        {
            PeixeCapturado peixeCapturado = new PeixeCapturado(new Peixe("Pacu"), 10, 5);

            Assert.Equals(5, peixeCapturado.Tamanho);

            peixeCapturado.AlterarTamanho(20);

            Assert.Equals("Pacu", peixeCapturado.Peixe.Nome);
            Assert.Equals(10, peixeCapturado.Peso);
            Assert.Equals(20, peixeCapturado.Tamanho);
        }
    }
}
