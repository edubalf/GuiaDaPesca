using GuiaDePesca.Resourse.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Domain.Model
{
    public class LocalDePesca
    {
        #region Propriets

        public virtual Guid Id { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual bool Aprovado { get; protected set; }
        public virtual Localizacao Localizacao { get; protected set; }
        public virtual Usuario UsuarioCadastro { get; protected set; }
        public virtual TipoLocalDePesca TipoLocalDePesca { get; protected set; }
        public virtual List<Comentario> Comentarios { get; protected set; } = new List<Comentario>();
        public virtual List<RelatoDePesca> RelatosDePesca { get; protected set; } = new List<RelatoDePesca>();

        #endregion

        #region Constructor

        protected LocalDePesca() { }

        public LocalDePesca(string nome, Localizacao localizacao, Usuario usuarioCadastro, TipoLocalDePesca tipoLocalDePesca)
        {
            ValidarNome(nome);
            ValidarTipoLocalDePesca(tipoLocalDePesca);
            Assertion.NotNull(localizacao, "A localização é obrigatória.");
            Assertion.NotNull(usuarioCadastro, "O usuário é obrigatório.");

            Id = Guid.NewGuid();
            Nome = nome;
            Aprovado = false;
            Localizacao = localizacao;
            UsuarioCadastro = usuarioCadastro;
            TipoLocalDePesca = tipoLocalDePesca;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adiciona um comentario
        /// </summary>
        public virtual void AdicionarComentario(Comentario comentario)
        {
            ValidarComentario(comentario);
            Assertion.True(ObterComentario(comentario) == null, "O comentario já foi adicionado.");

            Comentarios.Add(comentario);
        }

        /// <summary>
        /// Remove um comentario
        /// </summary>
        public virtual void RemoverComentario(Comentario comentario)
        {
            Comentario comentarioRemover;

            ValidarComentario(comentario);
            comentarioRemover = ObterComentario(comentario);
            Assertion.True(comentarioRemover != null, "O comentario não pertence a esse local de pesca.");

            Comentarios.Remove(comentarioRemover);
        }

        /// <summary>
        /// Adiciona um relato de pesca
        /// </summary>
        public virtual void AdicionarRelatoDePesca(RelatoDePesca relatoDePesca)
        {
            ValidarRelatoDePesca(relatoDePesca);
            Assertion.True(ObterRelatoDePesca(relatoDePesca) == null, "O relator de pesca já foi adicionado.");

            RelatosDePesca.Add(relatoDePesca);
        }

        /// <summary>
        /// Remove um relato de pesca
        /// </summary>
        public virtual void RemoverRelatoDePesca(RelatoDePesca relatoDePesca)
        {
            RelatoDePesca relatoDePescaRemover;

            ValidarRelatoDePesca(relatoDePesca);
            relatoDePescaRemover = ObterRelatoDePesca(relatoDePesca);
            Assertion.True(relatoDePescaRemover != null, "O relato de pesca não pertence a esse local de pesca.");

            RelatosDePesca.Remove(relatoDePescaRemover);
        }

        /// <summary>
        /// Troca o tipo do local de pesca
        /// </summary>
        public virtual void TrocarTipoLocalDePesca(TipoLocalDePesca tipoLocalDePesca)
        {
            ValidarTipoLocalDePesca(tipoLocalDePesca);

            TipoLocalDePesca = tipoLocalDePesca;
        }

        /// <summary>
        /// Troca o nome
        /// </summary>
        public virtual void TrocarNome(string nome)
        {
            ValidarNome(nome);

            Nome = nome;
        }

        #endregion

        #region Private Methods

        private void ValidarNome(string nome)
        {
            Assertion.NotEmpty(nome, "O nome é obrigatório.");
            Assertion.Length(nome, 5, 200, "O nome deve ter de 5 à 200 caracteres.");
        }

        private void ValidarTipoLocalDePesca(TipoLocalDePesca tipoLocalDePesca)
        {
            Assertion.NotNull(tipoLocalDePesca, "O tipo do local de pesca é obrigatório.");
        }

        private void ValidarComentario(Comentario comentario)
        {
            Assertion.NotNull(comentario, "O comentario é obrigatório.");
        }

        private void ValidarRelatoDePesca(RelatoDePesca relatoDePesca)
        {
            Assertion.NotNull(relatoDePesca, "O relato de pesca é obrigatório.");
        }

        private Comentario ObterComentario(Comentario comentario)
        {
            return Comentarios.Where(x => x.Id == comentario.Id).FirstOrDefault();
        }

        private RelatoDePesca ObterRelatoDePesca(RelatoDePesca relatoDePesca)
        {
            return RelatosDePesca.Where(x => x.Id == relatoDePesca.Id).FirstOrDefault();
        }

        #endregion
    }
}
