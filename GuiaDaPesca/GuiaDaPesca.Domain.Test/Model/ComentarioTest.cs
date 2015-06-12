using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiaDaPesca.Domain.Model;
using System;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class ComentarioTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void DescricaoVazia()
        {
            Comentario comentario = new Comentario("", new Usuario("edubalf", "123456", "123456"));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void UsuarioNull()
        {
            Comentario comentario = new Comentario("Ola mundo", null);
        }

        [TestMethod]
        public void DescricaoEUsuarioCorretamente()
        {
            Comentario comentario = new Comentario("Ola mundo", new Usuario("edubalf", "123456", "123456"));

            Assert.AreEqual(comentario.Descricao, "Ola mundo");
            Assert.AreEqual(comentario.Usuario.Email, "edubalf");
        }

        [TestMethod]
        public void AlterarComentario()
        {
            Comentario comentario = new Comentario("Ola mundo", new Usuario("edubalf", "123456", "123456"));

            comentario.AlterarDescricao("teste");

            Assert.AreEqual("teste", comentario.Descricao);
        }
    }
}
