using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Model
{
    public class LocalDePesca
    {
        #region Propriets

        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public bool Aprovado { get; private set; }
        public virtual Localizacao Localizacao { get; private set; }
        public virtual Usuario UsuarioCadastro { get; private set; }
        public virtual TipoLocalDePesca TipoLocalDePesca { get; private set; }
        public virtual List<Comentario> Comentarios { get; private set; }
        public virtual List<RelatoDePesca> RelatosDePesca { get; private set; }

        #endregion

        #region Constructor

        public LocalDePesca(string nome, Localizacao localizacao, Usuario usuarioCadastro, TipoLocalDePesca tipoLocalDePesca)
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

        /// <summary>
        /// Troca o tipo do local de pesca
        /// </summary>
        public void TrocarTipoLocalDePesca(TipoLocalDePesca tipoLocalDePesca)
        {

        }

        /// <summary>
        /// Troca o nome
        /// </summary>
        public void TrocarNome(string nome)
        {

        }

        #endregion
    }
}
