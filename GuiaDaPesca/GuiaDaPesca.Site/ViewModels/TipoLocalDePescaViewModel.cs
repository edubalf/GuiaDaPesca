using System;
using System.ComponentModel.DataAnnotations;

namespace GuiaDaPesca.Site.ViewModels
{
    public class TipoLocalDePescaViewModel
    {
        #region Propriets

        [Required(ErrorMessage = "O tipo é obrigatório.")]
        public Guid Id { get; set; }

        public ComentarioViewModel Comentario { get; set; }

        #endregion
    }
}
