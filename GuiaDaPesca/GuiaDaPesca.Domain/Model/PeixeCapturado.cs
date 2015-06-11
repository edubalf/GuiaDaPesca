using System;

namespace GuiaDaPesca.Domain.Model
{
    public class PeixeCapturado
    {
        #region Propriets

        public Guid Id { get; private set; }
        public double Peso { get; private set; }
        public double Tamanho { get; private set; }
        public virtual Peixe Peixe { get; private set; }

        #endregion

        #region Constructor

        public PeixeCapturado(Peixe peixe, double? peso, double? tamanho)
        {

        }

        #endregion
    }
}
