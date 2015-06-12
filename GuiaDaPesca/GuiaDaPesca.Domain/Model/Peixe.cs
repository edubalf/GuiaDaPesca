using GuiaDePesca.Resourse.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Domain.Model
{
    public class Peixe
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public virtual List<Comentario> comentarios { get; private set; }

        #endregion

        #region Constructor

        protected Peixe() { }

        public Peixe(string nome)
        {
            ValidarNome(nome);

            Nome = nome;
            comentarios = new List<Comentario>();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Inclui um novo comentario
        /// </summary>
        public void IncluirComentario(Comentario comentario)
        {
            ValidarComentario(comentario);
            Assertion.Null(ObterComentario(comentario), "O comentario já existe.");

            comentarios.Add(comentario);
        }

        /// <summary>
        /// Remover um comentario de acordo com o Id
        /// </summary>
        public void RemoverComentario(Comentario comentario)
        {
            Comentario comentarioRemover;

            ValidarComentario(comentario);
            comentarioRemover = ObterComentario(comentario);
            Assertion.NotNull(comentarioRemover, "O comentario não existe.");

            comentarios.Remove(ObterComentario(comentario));
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
            return comentarios.Where(x => x.Id == comentario.Id).FirstOrDefault();
        }

        #endregion
    }
}
