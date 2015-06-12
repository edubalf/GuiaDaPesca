using GuiaDePesca.Resourse.Validation;
using System;

namespace GuiaDaPesca.Domain.Model
{
    public class Comentario
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public virtual Usuario Usuario { get; private set; }

        #endregion

        #region Contructor

        protected Comentario() { }

        public Comentario(string descricao, Usuario usuario)
        {
            ValidarDescricao(descricao);
            ValidarUsuario(usuario);

            Id = Guid.NewGuid();
            Descricao = descricao;
            DataCriacao = DateTime.Now;
            Usuario = usuario;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Altera a descricao
        /// </summary>
        public void AlterarDescricao(string descricao)
        {
            ValidarDescricao(descricao);

            Descricao = descricao;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Valida a descricao
        /// </summary>
        private void ValidarDescricao(string descricao)
        {
            Assertion.NotEmpty(descricao, "A descrição deve ser preenchida");
            Assertion.Length(descricao, 1000, "A descrição ultrapassa o limite de 1000 caracteres");
        }

        /// <summary>
        /// Valida o usuario
        /// </summary>
        private void ValidarUsuario(Usuario usuario)
        {
            Assertion.NotNull(usuario, "O usuário deve ser passado");
        }

        #endregion
    }
}
