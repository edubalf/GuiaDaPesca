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
        private RelatoDePesca relatoDePesca;

        public LocalDePescaTest()
        {
            Inicializar();
        }

        [TestMethod]
        public void Inicializar()
        {
            localizacao = new Localizacao(-23.488193, -46.607975);
            usuario = new Usuario("edubalf", "123mudar", "123mudar");
            tipoLocalDePesca = new TipoLocalDePesca("Rio");
            localDePesca = new LocalDePesca("Atibainha", localizacao, usuario, tipoLocalDePesca);
            comentario = new Comentario("Teste", usuario);
            relatoDePesca = new RelatoDePesca(comentario, DateTime.Now);
        }

        [TestMethod]
        public void PreenchimentoPropriedades()
        {
            Assert.Equals(localDePesca.Aprovado, false);
            Assert.Equals(localDePesca.Nome, "Atibainha");
            Assert.Equals(localDePesca.Localizacao, localizacao);
            Assert.Equals(localDePesca.TipoLocalDePesca, tipoLocalDePesca);
            Assert.Equals(localDePesca.UsuarioCadastro, usuario);
        }

        [TestMethod]
        public void IncluirComentario()
        {
            localDePesca.AdicionarComentario(comentario);

            Assert.Equals(localDePesca.Comentarios.Count, 1);
            Assert.Equals(localDePesca.Comentarios.First(), comentario);
        }

        [TestMethod]
        public void AtualizarComentario()
        {
            localDePesca.AdicionarComentario(comentario);

            Assert.Equals(localDePesca.Comentarios.First(), comentario);

            comentario.AlterarDescricao("Ola Mundo");

            localDePesca.AtualizarComentario(comentario);

            Assert.Equals(localDePesca.Comentarios.Count, 1);
            Assert.Equals(localDePesca.Comentarios.First(), comentario);
        }

        [TestMethod]
        public void RemoverComentario()
        {
            localDePesca.AdicionarComentario(comentario);

            Assert.Equals(localDePesca.Comentarios.Count, 1);

            localDePesca.RemoverComentario(comentario);

            Assert.Equals(localDePesca.Comentarios.Count, 0);
        }

        [TestMethod]
        public void AdicionarRelatoDePesca()
        {
            localDePesca.AdicionarRelatoDePesca(relatoDePesca);

            Assert.Equals(localDePesca.RelatosDePesca.Count, 1);
            Assert.Equals(localDePesca.RelatosDePesca.First(), relatoDePesca);
        }

        [TestMethod]
        public void AtualizarRelatoDePesca()
        {
            localDePesca.AdicionarRelatoDePesca(relatoDePesca);

            comentario.AlterarDescricao("Outro peixe");

            Assert.Equals(localDePesca.RelatosDePesca.First(), relatoDePesca);

            relatoDePesca.AlterarComentario(comentario);

            localDePesca.AtualizarRelatoDePesca(relatoDePesca);

            Assert.Equals(localDePesca.RelatosDePesca.Count, 1);
            Assert.Equals(localDePesca.RelatosDePesca.First(), relatoDePesca);
        }

        [TestMethod]
        public void RemoverRelatoDePesca()
        {
            localDePesca.AdicionarRelatoDePesca(relatoDePesca);

            Assert.Equals(localDePesca.RelatosDePesca.Count, 1);

            localDePesca.RemoverRelatoDePesca(relatoDePesca);

            Assert.Equals(localDePesca.RelatosDePesca.Count, 0);
        }

        [TestMethod]
        public void TrocarNome()
        {
            localDePesca.TrocarNome("Represa de mairipora");

            Assert.Equals(localDePesca.Nome, "Represa de mairipora");
        }

        [TestMethod]
        public void TrocarTipoLocalDePesca()
        {
            TipoLocalDePesca tipoLocalDePescaInterno = new TipoLocalDePesca("Pesqueiro");

            localDePesca.TrocarTipoLocalDePesca(tipoLocalDePescaInterno);

            Assert.Equals(localDePesca.TipoLocalDePesca, tipoLocalDePescaInterno);
        }
    }
}
