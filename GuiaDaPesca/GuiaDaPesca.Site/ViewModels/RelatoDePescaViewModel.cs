using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Site.ViewModels
{
    public class RelatoDePescaViewModel
    {
        #region Propriets

        public Guid Id { get; set; }
        public DateTime Data { get; set; }
        public ComentarioViewModel Comentario { get; set; }
        public List<PeixeCapturadoViewModel> PeixesCapturados { get; set; }

        #endregion
    }
}
