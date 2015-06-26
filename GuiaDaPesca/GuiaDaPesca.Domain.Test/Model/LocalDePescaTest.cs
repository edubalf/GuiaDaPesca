using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiaDaPesca.Domain.Model;
using System.Linq;

namespace GuiaDaPesca.Domain.Test.Model
{
    [TestClass]
    public class LocalDePescaTest
    {
        private Localizacao localizacao;
        private Usuario usuario;
        private TipoLocalDePesca tipoLocalDePesca;
        private LocalDePesca localDePesca;
        private Comentario comentario;
        private Peixe peixe;

        public LocalDePescaTest()
        {
            Inicializar();
        }

        [TestMethod]
        public void Inicializar()
        {
            localizacao = new Localizacao(-23.488193, -46.607975);
            usuario = new Usuario("edubalf", "123mudar", "123mudar");
            tipoLocalDePesca = new TipoLocalDePesca(new Comentario("rio", usuario));
            localDePesca = new LocalDePesca("Atibainha", localizacao, usuario, tipoLocalDePesca);
            comentario = new Comentario("Teste", usuario);
            peixe = new Peixe("Pacu");
        }

        [TestMethod]
        public void PreenchimentoPropriedades()
        {
            Assert.AreEqual(localDePesca.Aprovado, false);
            Assert.AreEqual(localDePesca.Nome, "Atibainha");
            Assert.AreEqual(localDePesca.Localizacao, localizacao);
            Assert.AreEqual(localDePesca.TipoLocalDePesca, tipoLocalDePesca);
            Assert.AreEqual(localDePesca.UsuarioCadastro, usuario);
        }

        [TestMethod]
        public void IncluirComentario()
        {
            localDePesca.AdicionarComentario(comentario);

            Assert.AreEqual(localDePesca.Comentarios.Count, 1);
            Assert.AreEqual(localDePesca.Comentarios.First(), comentario);
        }

        [TestMethod]
        public void RemoverComentario()
        {
            localDePesca.AdicionarComentario(comentario);

            Assert.AreEqual(localDePesca.Comentarios.Count, 1);

            localDePesca.RemoverComentario(comentario);

            Assert.AreEqual(localDePesca.Comentarios.Count, 0);
        }

        [TestMethod]
        public void IncluirPeixe()
        {
            localDePesca.AdicionarPeixe(peixe);

            Assert.AreEqual(localDePesca.Peixes.Count, 1);
            Assert.AreEqual(localDePesca.Peixes.First(), peixe);
        }

        [TestMethod]
        public void RemoverPeixe()
        {
            localDePesca.AdicionarPeixe(peixe);

            Assert.AreEqual(localDePesca.Peixes.Count, 1);

            localDePesca.RemoverPeixe(peixe);

            Assert.AreEqual(localDePesca.Peixes.Count, 0);
        }

        [TestMethod]
        public void TrocarNome()
        {
            localDePesca.TrocarNome("Represa de mairipora");

            Assert.AreEqual(localDePesca.Nome, "Represa de mairipora");
        }

        [TestMethod]
        public void TrocarTipoLocalDePesca()
        {
            TipoLocalDePesca tipoLocalDePescaInterno = new TipoLocalDePesca(new Comentario("Rio", usuario));

            localDePesca.TrocarTipoLocalDePesca(tipoLocalDePescaInterno);

            Assert.AreEqual(localDePesca.TipoLocalDePesca, tipoLocalDePescaInterno);
        }
    }
}
