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
        public virtual IList<Comentario> Comentarios { get; protected set; }

        public virtual IList<PeixeCapturado> PeixesCapturados { get; protected set; }

        #endregion

        #region Constructor

        protected Peixe() { }

        public Peixe(string nome)
        {
            ValidarNome(nome);

            Nome = nome;
            Comentarios = new List<Comentario>();
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

            Comentarios.Add(comentario);
        }

        /// <summary>
        /// Remover um comentario de acordo com o Id
        /// </summary>
        public virtual void RemoverComentario(Comentario comentario)
        {
            Comentario removerComentario = ObterComentario(comentario);
            ValidarComentario(removerComentario);
            Assertion.NotNull(removerComentario, "O comentario não existe.");
            Comentarios.Remove(removerComentario);
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
            return Comentarios.Where(x => x.Id == comentario.Id).FirstOrDefault();
        }

        #endregion
    }
}
