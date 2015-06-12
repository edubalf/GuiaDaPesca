using System;

namespace GuiaDaPesca.Site.ViewModels
{
    public class ComentarioViewModel
    {
        #region Propriets

        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }

        #endregion
    }
}
