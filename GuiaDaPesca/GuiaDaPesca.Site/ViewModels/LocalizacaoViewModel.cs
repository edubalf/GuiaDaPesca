using System;

namespace GuiaDaPesca.Site.ViewModels
{
    public class LocalizacaoViewModel
    {
        #region Propriets

        public Guid Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Endereco { get; set; }

        #endregion
    }
}
