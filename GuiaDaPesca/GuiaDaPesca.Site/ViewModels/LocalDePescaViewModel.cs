using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Site.ViewModels
{
    public class LocalDePescaViewModel
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public bool Aprovado { get; private set; }
        public virtual LocalizacaoViewModel Localizacao { get; private set; }
        public virtual UsuarioViewModel UsuarioCadastro { get; private set; }
        public virtual TipoLocalDePescaViewModel TipoLocalDePesca { get; private set; }
        public virtual List<ComentarioViewModel> Comentarios { get; private set; } = new List<ComentarioViewModel>();
        public virtual List<RelatoDePescaViewModel> RelatosDePesca { get; private set; } = new List<RelatoDePescaViewModel>();

        #endregion
    }
}
