using GuiaDePesca.Resourse.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Domain.Model
{
    public class Peixe
    {
        #region Propriets

        public virtual Guid Id { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual IList<Comentario> Comentario { get; protected set; } = new List<Comentario>();

        public virtual IList<LocalDePesca> LocalDePesca { get; protected set; } = new List<LocalDePesca>();

        #endregion

        #region Constructor

        protected Peixe() { }

        public Peixe(string nome)
        {
            ValidarNome(nome);

            Nome = nome;
            Comentario = new List<Comentario>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Inclui um novo comentario
        /// </summary>
        public virtual void IncluirComentario(Comentario comentario)
        {
            ValidarComentario(comentario);
            Assertion.Null(ObterComentario(comentario), "O comentario já existe.");

            Comentario.Add(comentario);
        }

        /// <summary>
        /// Remover um comentario de acordo com o Id
        /// </summary>
        public virtual void RemoverComentario(Comentario comentario)
        {
            Comentario comentarioRemover;

            ValidarComentario(comentario);
            comentarioRemover = ObterComentario(comentario);
            Assertion.NotNull(comentarioRemover, "O comentario não existe.");

            Comentario.Remove(ObterComentario(comentario));
        }

        #endregion

        #region Private Methods

        private void ValidarNome(string nome)
        {
            Assertion.NotEmpty(nome, "O nome é obrigatório.");
            Assertion.Length(nome, 100, "O nome deve ter menos que 100 caracteres.");
        }

        private void ValidarComentario(Comentario comentario)
        {
            Assertion.NotNull(comentario, "O comentario não pode ser null");
        }

        private Comentario ObterComentario(Comentario comentario)
        {
            return Comentario.Where(x => x.Id == comentario.Id).FirstOrDefault();
        }

        #endregion
    }
}
