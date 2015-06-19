using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Site.ViewModels
{
    public class PeixeViewModel
    {
        #region Propriets

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<ComentarioViewModel> Comentarios { get; set; }

        #endregion
    }
}
