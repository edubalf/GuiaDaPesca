using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiaDaPesca.Domain.Model;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class PeixeTest
    {
        [TestMethod]
        public void NomeValido()
        {
            Peixe peixe = new Peixe("Pacu");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void NomeVazio()
        {
            Peixe peixe = new Peixe("");
        }

        [TestMethod]
        public void IncluirComentario()
        {
            Peixe peixe = new Peixe("Pacu");
            peixe.IncluirComentario(new Comentario("Peixe grande", new Usuario("edubalf", "123mudar", "123mudar")));

            Assert.IsTrue(peixe.comentarios.Count > 0);
        }

        [TestMethod]
        public void AtualizarComentario()
        {
            Peixe peixe = new Peixe("Pacu");

            Comentario comentario = new Comentario("Peixe grande", new Usuario("edubalf", "123mudar", "123mudar"));

            peixe.IncluirComentario(comentario);

            comentario.AlterarDescricao("Peixe Bravo");

            peixe.AtualizarComentario(comentario);

            Assert.IsTrue(peixe.comentarios.Count > 0);
            Assert.Equals(peixe.comentarios.First().Descricao, "Peixe Bravo");
        }

        [TestMethod]
        public void RemoverComentario()
        {
            Peixe peixe = new Peixe("Pacu");

            Comentario comentario = new Comentario("Peixe grande", new Usuario("edubalf", "123mudar", "123mudar"));

            peixe.IncluirComentario(comentario);

            peixe.RemoverComentario(comentario);

            Assert.IsTrue(peixe.comentarios.Count == 0);
        }
    }
}
