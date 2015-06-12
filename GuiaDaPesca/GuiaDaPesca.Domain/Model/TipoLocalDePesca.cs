using System;

namespace GuiaDaPesca.Domain.Model
{
    public class TipoLocalDePesca
    {
        #region Propriets

        public Guid Id { get; private set; }
        public Comentario Comentario { get; private set; }

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
