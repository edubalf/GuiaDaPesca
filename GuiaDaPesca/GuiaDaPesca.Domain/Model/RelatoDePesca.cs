using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Model
{
    public class RelatoDePesca
    {
        #region Propriets

        public Guid Id { get; private set; }
        public DateTime Data { get; private set; }
        public virtual Comentario Comentario { get; private set; }
        public virtual List<PeixeCapturado> PeixesCapturados { get; private set; }

        #endregion

        #region Constructor

        public RelatoDePesca(Comentario comentario, DateTime data)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Adiciona um peixe capturado
        /// </summary>
        public void AdicionarPeixeCapturado(PeixeCapturado peixeCapturado)
        {

        }

        /// <summary>
        /// Atualiza um peixe capturado
        /// </summary>
        public void AtualizaPeixeCapturado(PeixeCapturado peixeCapturado)
        {

        }

        /// <summary>
        /// Remove um peixe capturado
        /// </summary>
        public void RemoverPeixeCapturado(PeixeCapturado peixeCapturado)
        {

        }

        /// <summary>
        /// Altera a data
        /// </summary>
        public void AlterarData(DateTime data)
        {

        }

        /// <summary>
        /// Altera o comentario
        /// </summary>
        public void AlterarComentario(Comentario comentario)
        {

        }

        #endregion
    }
}
