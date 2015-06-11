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

        }

        #endregion

        #region Methods

        /// <summary>
        /// Troca o peixe
        /// </summary>
        public void AlterarPeixe(Peixe peixe)
        {

        }

        /// <summary>
        /// Altera o tamanho
        /// </summary>
        public void AlterarTamanho(double tamanho)
        {

        }

        /// <summary>
        /// Altera o peso
        /// </summary>
        public void AlterarPeso(double peso)
        {

        }

        #endregion
    }
}
