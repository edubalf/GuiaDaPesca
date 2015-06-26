using GuiaDePesca.Resourse.Validation;
using System;
using System.Collections.Generic;

namespace GuiaDaPesca.Domain.Model
{
    public class Localizacao
    {
        #region Propriets

        public virtual Guid Id { get; protected set; }
        public virtual double Latitude { get; protected set; }
        public virtual double Longitude { get; protected set; }

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
