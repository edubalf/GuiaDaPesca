using GuiaDePesca.Resourse.Validation;
using System;

namespace GuiaDaPesca.Domain.Model
{
    public class Localizacao
    {
        #region Propriets

        public Guid Id { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        #endregion

        #region Constructor

        protected Localizacao() { }

        public Localizacao(double latitude, double longitude)
        {
            Assertion.NotEquals(latitude, Convert.ToDouble(0), "A latitude não pode ser 0");
            Assertion.NotEquals(longitude, Convert.ToDouble(0), "A longitude não pode ser 0");

            Id = Guid.NewGuid();
            Latitude = latitude;
            Longitude = longitude;
        }

        #endregion
    }
}
