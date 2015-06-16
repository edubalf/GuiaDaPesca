using GuiaDePesca.Resourse.Validation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuiaDaPesca.Domain.Model
{
    public class RelatoDePesca
    {
        #region Propriets

        public virtual Guid Id { get; protected set; }
        public virtual DateTime Data { get; protected set; }
        public virtual Comentario Comentario { get; protected set; }
        public virtual IList<PeixeCapturado> PeixesCapturados { get; protected set; } = new List<PeixeCapturado>();

        public virtual IList<LocalDePesca> LocaisDePesca { get; protected set; }

        #endregion

        #region Constructor

        protected RelatoDePesca() { }

        public RelatoDePesca(Comentario comentario, DateTime data)
        {
            ValidarData(data);
            ValidarComentario(comentario);

            Id = Guid.NewGuid();
            Data = data;
            Comentario = comentario;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adiciona um peixe capturado
        /// </summary>
        public virtual void AdicionarPeixeCapturado(PeixeCapturado peixeCapturado)
        {
            ValidarPeixeCapturadoNaoCadastrado(peixeCapturado);

            PeixesCapturados.Add(peixeCapturado);
        }

        /// <summary>
        /// Atualiza um peixe capturado
        /// </summary>
        public virtual void AtualizaPeixeCapturado(PeixeCapturado peixeCapturado)
        {
            RemoverPeixeCapturado(peixeCapturado);

            AdicionarPeixeCapturado(peixeCapturado);
        }

        /// <summary>
        /// Remove um peixe capturado
        /// </summary>
        public virtual void RemoverPeixeCapturado(PeixeCapturado peixeCapturado)
        {
            ValidarPeixeCapturadoCadastrado(peixeCapturado);

            PeixesCapturados.Remove(ObterPeixeCapturado(peixeCapturado));
        }

        /// <summary>
        /// Altera a data
        /// </summary>
        public virtual void AlterarData(DateTime data)
        {
            ValidarData(data);

            Data = data;
        }

        #endregion

        #region Private Methods

        private void ValidarData(DateTime data)
        {
            Assertion.True(data <= DateTime.Now, "A data da pescaria tem que ser menor que a data atual");
        }

        private void ValidarComentario(Comentario comentario)
        {
            Assertion.NotNull(comentario, "O comentario deve ser passado");
        }

        private void ValidarPeixeCapturadoNaoCadastrado(PeixeCapturado peixeCapturado)
        {
            Assertion.True(ObterPeixeCapturado(peixeCapturado) == null, "Esse peixe já está cadastrado.");
        }

        private void ValidarPeixeCapturadoCadastrado(PeixeCapturado peixeCapturado)
        {
            Assertion.True(ObterPeixeCapturado(peixeCapturado) != null, "Esse peixe não está cadastrado.");
        }

        private PeixeCapturado ObterPeixeCapturado(PeixeCapturado peixeCapturado)
        {
            return PeixesCapturados.Where(x => x.Id == peixeCapturado.Id).FirstOrDefault();
        }

        #endregion
    }
}
