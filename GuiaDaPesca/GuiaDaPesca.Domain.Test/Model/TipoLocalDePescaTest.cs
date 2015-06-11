using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class TipoLocalDePescaTest
    {

        [TestMethod]
        public void PreenchimentoDosParametros()
        {
            TipoLocalDePesca tipoLocalDePesca = new TipoLocalDePesca("Rio");

            Assert.Equals(tipoLocalDePesca.Descricao, "Rio");
        }

        [TestMethod]
        public void TrocarDescricao()
        {
            TipoLocalDePesca tipoLocalDePesca = new TipoLocalDePesca("Rio");

            Assert.Equals(tipoLocalDePesca.Descricao, "Rio");

            tipoLocalDePesca.AlterarDescricao("Praia");

            Assert.Equals(tipoLocalDePesca.Descricao, "Praia");
        }
    }
}
