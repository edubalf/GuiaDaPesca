using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Localizacao(double latitude, double longitude)
        {

        }

        #endregion
    }
}
