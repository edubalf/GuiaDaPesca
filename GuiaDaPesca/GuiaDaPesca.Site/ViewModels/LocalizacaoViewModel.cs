using System;
using System.ComponentModel.DataAnnotations;

namespace GuiaDaPesca.Site.ViewModels
{
    public class LocalizacaoViewModel
    {
        #region Propriets

        public Guid Id { get; set; }

        [Required(ErrorMessage = "O endereço deve ser validado.")]
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        #endregion
    }
}
