using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GuiaDaPesca.Site.ViewModels
{
    public class LocalDePescaViewModel
    {
        #region Propriets

        public Guid Id { get; set; }

        [Required(ErrorMessage ="O nome é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O nome deve ser menor que 100 caracteres.")]
        public string Nome { get; set; }

        public bool Aprovado { get; set; }

        [Required(ErrorMessage = "A localização é obrigatória.")]
        public LocalizacaoViewModel Localizacao { get; set; }

        public UsuarioViewModel UsuarioCadastro { get; set; }

        [Required(ErrorMessage = "O Tipo é obrigatório.")]
        [Display(Name = "Tipo")]
        public TipoLocalDePescaViewModel TipoLocalDePesca { get; set; }

        public List<ComentarioViewModel> Comentarios { get; set; } = new List<ComentarioViewModel>();

        #endregion
    }
}
