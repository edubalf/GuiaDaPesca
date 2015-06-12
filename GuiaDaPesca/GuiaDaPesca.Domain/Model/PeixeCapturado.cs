using GuiaDePesca.Resourse.Validation;
using System;

namespace GuiaDaPesca.Domain.Model
{
    public class PeixeCapturado
    {
        #region Propriets

        public Guid Id { get; private set; }
        public double Peso { get; private set; }
        public double Tamanho { get; private set; }
        public virtual Peixe Peixe { get; private set; }

        #endregion

        #region Constructor

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
        public void AlterarPeixe(Peixe peixe)
        {
            Peixe = peixe;
        }

        /// <summary>
        /// Altera o tamanho
        /// </summary>
        public void AlterarTamanho(double tamanho)
        {
            ValidarTamanho(tamanho);

            Tamanho = tamanho;
        }

        /// <summary>
        /// Altera o peso
        /// </summary>
        public void AlterarPeso(double peso)
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
