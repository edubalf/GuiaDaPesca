using System;
using System.Collections.Generic;

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

        public Peixe(string nome)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Inclui um novo comentario
        /// </summary>
        public void IncluirComentario(Comentario comentario)
        {

        }

        /// <summary>
        /// Remover um comentario de acordo com o Id
        /// </summary>
        public void RemoverComentario(Comentario comentario)
        {

        }

        /// <summary>
        /// Atualiza um comentario
        /// </summary>
        public void AtualizarComentario(Comentario comentario)
        {

        }

        #endregion
    }
}
