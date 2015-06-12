using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class TipoLocalDePescaTest
    {
        private Comentario comentario;

        public TipoLocalDePescaTest()
        {
            comentario = new Comentario("Rio", new Usuario("edubalf", "123mudar", "123mudar"));
        }

        [TestMethod]
        public void PreenchimentoDosParametros()
        {
            TipoLocalDePesca tipoLocalDePesca = new TipoLocalDePesca(comentario);

            Assert.AreEqual(tipoLocalDePesca.Comentario, comentario);
        }
    }
}
