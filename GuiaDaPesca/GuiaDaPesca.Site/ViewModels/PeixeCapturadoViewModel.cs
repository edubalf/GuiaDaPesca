using System;

namespace GuiaDaPesca.Site.ViewModels
{
    public class PeixeCapturadoViewModel
    {
        #region Propriets

        public Guid Id { get; private set; }
        public double Peso { get; private set; }
        public double Tamanho { get; private set; }
        public virtual PeixeViewModel Peixe { get; private set; }

        #endregion
    }
}
