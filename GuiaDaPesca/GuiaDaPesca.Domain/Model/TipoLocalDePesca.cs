using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Model
{
    public class TipoLocalDePesca
    {
        #region Propriets

        public virtual Guid Id { get; protected set; }
        public virtual Comentario Comentario { get; protected set; }

        #endregion

        #region Constructor

        protected TipoLocalDePesca() { }

        public TipoLocalDePesca(Comentario comentario)
        {
            Id = Guid.NewGuid();
            Comentario = comentario;
        }

        #endregion
    }
}
