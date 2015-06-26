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
        public virtual IList<Comentario> Comentarios { get; protected set; } = new List<Comentario>();
        public virtual IList<Peixe> Peixes { get; set; } = new List<Peixe>();

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
        /// Adiciona um comentario
        /// </summary>
        public virtual void AdicionarPeixe(Peixe peixe)
        {
            ValidarPeixe(peixe);
            Assertion.True(ObterPeixe(peixe) == null, "O peixe já foi adicionado.");

            Peixes.Add(peixe);
        }

        /// <summary>
        /// Remove um comentario
        /// </summary>
        public virtual void RemoverPeixe(Peixe peixe)
        {
            Peixe peixeRemover;

            ValidarPeixe(peixe);
            peixeRemover = ObterPeixe(peixe);
            Assertion.True(peixeRemover != null, "O peixe não pertence a esse local de pesca.");

            Peixes.Remove(peixeRemover);
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

        private void ValidarPeixe(Peixe peixe)
        {
            Assertion.NotNull(peixe, "O comentario é obrigatório.");
        }

        private Comentario ObterComentario(Comentario comentario)
        {
            return Comentarios.Where(x => x.Id == comentario.Id).FirstOrDefault();
        }

        private Peixe ObterPeixe(Peixe peixe)
        {
            return Peixes.Where(x => x.Id == peixe.Id).FirstOrDefault();
        }

        #endregion
    }
}
