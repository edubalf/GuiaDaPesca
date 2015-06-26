using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class LocalizacaoTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void LatLongInvalida()
        {
            var localizacao = new Localizacao(0, 0);
        }

        [TestMethod]
        public void LatLongValido()
        {
            var localizacao = new Localizacao(-23.488193, -46.607975);
        }
    }
}
