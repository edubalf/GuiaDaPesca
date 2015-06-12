using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiaDaPesca.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class RelatoDePescaTest
    {
        private Usuario usuario;
        private Comentario comentario;
        private Peixe peixe;
        PeixeCapturado peixeCapturado;
        RelatoDePesca relatoDePesca;

        public RelatoDePescaTest()
        {
            usuario = new Usuario("edubalf@hotmail.com", "123mudar", "123mudar");
            comentario = new Comentario("A pesca foi boa", usuario);
            peixe = new Peixe("Pacu");
            peixeCapturado = new PeixeCapturado(peixe, 10, 10);
            relatoDePesca = new RelatoDePesca(comentario, new DateTime(2015, 6, 9));
        }

        [TestMethod]
        public void Construtor()
        {
            Assert.AreEqual(new DateTime(2015, 6, 9), relatoDePesca.Data);
            Assert.AreEqual(relatoDePesca.Comentario, comentario);
        }

        [TestMethod]
        public void IncluirPeixe()
        {
            relatoDePesca.AdicionarPeixeCapturado(peixeCapturado);

            Assert.AreEqual(1, relatoDePesca.PeixesCapturados.Count);
            Assert.AreEqual(relatoDePesca.PeixesCapturados.First(), peixeCapturado);
        }

        [TestMethod]
        public void AtualizarPeixe()
        {
            relatoDePesca.AdicionarPeixeCapturado(peixeCapturado);

            peixeCapturado.AlterarPeso(20);

            relatoDePesca.AtualizaPeixeCapturado(peixeCapturado);

            Assert.AreEqual(1, relatoDePesca.PeixesCapturados.Count);
            Assert.AreEqual(relatoDePesca.PeixesCapturados.First(), peixeCapturado);
        }

        [TestMethod]
        public void RemoverPeixe()
        {
            relatoDePesca.AdicionarPeixeCapturado(peixeCapturado);

            Assert.AreEqual(1, relatoDePesca.PeixesCapturados.Count);

            relatoDePesca.RemoverPeixeCapturado(peixeCapturado);

            Assert.AreEqual(0, relatoDePesca.PeixesCapturados.Count);
        }

        [TestMethod]
        public void AlterarData()
        {
            relatoDePesca.AlterarData(new DateTime(2015, 4, 1));

            Assert.AreEqual(new DateTime(2015, 4, 1), relatoDePesca.Data);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void AlterarDataMaiorQueDataAtual()
        {
            relatoDePesca.AlterarData(DateTime.Now.AddDays(1));
        }
    }
}
