using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Site.ViewModels
{
    public class LocalDePescaViewModel
    {
        #region Propriets

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool Aprovado { get; set; }
        public virtual LocalizacaoViewModel Localizacao { get; set; }
        public virtual UsuarioViewModel UsuarioCadastro { get; set; }
        public virtual TipoLocalDePescaViewModel TipoLocalDePesca { get; set; }
        public virtual List<ComentarioViewModel> Comentarios { get; set; } = new List<ComentarioViewModel>();
        public virtual List<RelatoDePescaViewModel> RelatosDePesca { get; set; } = new List<RelatoDePescaViewModel>();

        #endregion
    }
}
