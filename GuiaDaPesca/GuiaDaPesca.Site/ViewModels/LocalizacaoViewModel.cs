using System;

namespace GuiaDaPesca.Site.ViewModels
{
    public class LocalizacaoViewModel
    {
        #region Propriets

        public Guid Id { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        #endregion
    }
}
