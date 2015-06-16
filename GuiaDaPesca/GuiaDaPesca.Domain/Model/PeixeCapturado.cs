using GuiaDePesca.Resourse.Validation;
using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Model
{
    public class PeixeCapturado
    {
        #region Propriets

        public virtual Guid Id { get; protected set; }
        public virtual double Peso { get; protected set; }
        public virtual double Tamanho { get; protected set; }
        public virtual Peixe Peixe { get; protected set; }

        public virtual IList<RelatoDePesca> RelatosDePesca { get; protected set; }

        #endregion

        #region Constructor

        protected PeixeCapturado() { }

        public PeixeCapturado(Peixe peixe, double peso, double tamanho)
        {
            ValidarPeso(peso);
            ValidarTamanho(tamanho);

            Id = Guid.NewGuid();
            Peixe = peixe;
            Peso = peso;
            Tamanho = tamanho;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Troca o peixe
        /// </summary>
        public virtual void AlterarPeixe(Peixe peixe)
        {
            Peixe = peixe;
        }

        /// <summary>
        /// Altera o tamanho
        /// </summary>
        public virtual void AlterarTamanho(double tamanho)
        {
            ValidarTamanho(tamanho);

            Tamanho = tamanho;
        }

        /// <summary>
        /// Altera o peso
        /// </summary>
        public virtual void AlterarPeso(double peso)
        {
            ValidarPeso(peso);

            Peso = peso;
        }

        #endregion

        #region Privete Methods

        private void ValidarPeso(double peso)
        {
            Assertion.True(peso >= 0, "O peso deve ser positivo");
        }

        private void ValidarTamanho(double tamanho)
        {
            Assertion.True(tamanho >= 0, "O tamanho deve ser positivo");
        }

        #endregion
    }
}
