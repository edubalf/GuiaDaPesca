using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Model
{
    public class LocaisDePesca
    {
        #region Propriets

        public Guid Id { get; private set; }
        public bool Aprovado { get; private set; }
        public virtual Localizacao Localizacao { get; private set; }
        public virtual Usuario UsuarioCadastro { get; private set; }
        public virtual TipoLocalDePesca TipoLocalDePesca { get; private set; }
        public virtual List<Comentario> Comentarios { get; private set; }
        public virtual List<RelatoDePesca> RelatosDePesca { get; private set; }

        #endregion

        #region Constructor

        public LocaisDePesca(string descricao, Localizacao localizacao, Usuario usuarioCadastro, TipoLocalDePesca tipoLocalDePesca)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Adiciona um comentario
        /// </summary>
        public void AdicionarComentario(Comentario comentario)
        {

        }

        /// <summary>
        /// Remove um comentario
        /// </summary>
        public void RemoverComentario(Comentario comentario)
        {

        }

        /// <summary>
        /// Atualiza um comentario
        /// </summary>
        public void AtualizarComentario(Comentario comentario)
        {

        }

        /// <summary>
        /// Adiciona um relato de pesca
        /// </summary>
        public void AdicionarRelatoDePesca(RelatoDePesca relatoDePesca)
        {

        }

        /// <summary>
        /// Remove um relato de pesca
        /// </summary>
        public void RemoverRelatoDePesca(RelatoDePesca relatoDePesca)
        {

        }

        /// <summary>
        /// Atualiza um relato de pesca
        /// </summary>
        public void AtualizarRelatoDePesca(RelatoDePesca relatoDePesca)
        {

        }

        #endregion
    }
}
