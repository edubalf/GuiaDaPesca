using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Site.ViewModels
{
    public class RelatoDePescaViewModel
    {
        #region Propriets

        public Guid Id { get; private set; }
        public DateTime Data { get; private set; }
        public virtual ComentarioViewModel Comentario { get; private set; }
        public virtual List<PeixeCapturadoViewModel> PeixesCapturados { get; private set; } = new List<PeixeCapturadoViewModel>();

        #endregion
    }
}
