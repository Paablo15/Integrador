using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrador.Modelo
{
    public class DestinoExcursion
    {
        private Excursion excursion;
        private Destino destino;

        public Destino Destino
        {
            get { return destino; }
            set { destino = value; }
        }


        public Excursion Excursion
        {
            get { return excursion; }
            set { excursion = value; }
        }

    }
}