using System;
using System.ComponentModel.DataAnnotations;

namespace GuiaDaPesca.Site.ViewModels
{
    public class UsuarioViewModel
    {
        #region Propriets

        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Email é obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A Senha é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "A confirmação da senha é obrigatório")]
        [Display(Name = "Confirmação")]
        public string SenhaConfirmacao { get; set; }

        #endregion
    }
}
