using System;

namespace GuiaDaPesca.Site.ViewModels
{
    public class PeixeCapturadoViewModel
    {
        #region Propriets

        public Guid Id { get; set; }
        public double Peso { get; set; }
        public double Tamanho { get; set; }
        public PeixeViewModel Peixe { get; set; }

        #endregion
    }
}
