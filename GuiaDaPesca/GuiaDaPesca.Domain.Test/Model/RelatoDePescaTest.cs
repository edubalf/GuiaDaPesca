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
            Assert.Equals(new DateTime(2015, 6, 9), relatoDePesca.Data);
            Assert.Equals(relatoDePesca.Comentario, comentario);
            Assert.Equals(relatoDePesca.PeixesCapturados, new List<PeixeCapturado>());
        }

        [TestMethod]
        public void IncluirPeixe()
        {
            relatoDePesca.AdicionarPeixeCapturado(peixeCapturado);

            Assert.Equals(1, relatoDePesca.PeixesCapturados.Count);
            Assert.Equals(relatoDePesca.PeixesCapturados.First(), peixeCapturado);
        }

        [TestMethod]
        public void AtualizarPeixe()
        {
            relatoDePesca.AdicionarPeixeCapturado(peixeCapturado);

            peixeCapturado.AlterarPeso(20);

            relatoDePesca.AtualizaPeixeCapturado(peixeCapturado);

            Assert.Equals(1, relatoDePesca.PeixesCapturados.Count);
            Assert.Equals(relatoDePesca.PeixesCapturados.First(), peixeCapturado);
        }

        [TestMethod]
        public void RemoverPeixe()
        {
            relatoDePesca.AdicionarPeixeCapturado(peixeCapturado);

            Assert.Equals(1, relatoDePesca.PeixesCapturados.Count);

            relatoDePesca.RemoverPeixeCapturado(peixeCapturado);

            Assert.Equals(0, relatoDePesca.PeixesCapturados.Count);
        }

        [TestMethod]
        public void AlterarData()
        {
            relatoDePesca.AlterarData(new DateTime(2015, 4, 1));

            Assert.Equals(new DateTime(2015, 4, 1), relatoDePesca.Data);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void AlterarDataMaiorQueDataAtual()
        {
            relatoDePesca.AlterarData(DateTime.Now.AddDays(1));
        }
    }
}
