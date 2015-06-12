using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Site.ViewModels
{
    public class PeixeViewModel
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public virtual List<ComentarioViewModel> comentarios { get; private set; }

        #endregion
    }
}
