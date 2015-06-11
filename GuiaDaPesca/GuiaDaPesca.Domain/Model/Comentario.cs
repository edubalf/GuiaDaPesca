using System;

namespace GuiaDaPesca.Domain.Model
{
    public class Comentario
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public virtual Usuario usuario { get; set; }

        #endregion

        #region Contructor

        public Comentario(string descricao, Usuario usuario)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Altera a descricao
        /// </summary>
        public void AlterarDescricao(string descricao)
        {

        }

        #endregion
    }
}
