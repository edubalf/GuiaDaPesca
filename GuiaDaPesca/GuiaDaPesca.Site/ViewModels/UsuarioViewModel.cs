using System;
using System.ComponentModel.DataAnnotations;

namespace GuiaDaPesca.Site.ViewModels
{
    public class UsuarioViewModel
    {
        #region Propriets

        public Guid Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        [Display(Name = "Confirmação")]
        public string SenhaConfirmacao { get; set; }

        #endregion
    }
}
