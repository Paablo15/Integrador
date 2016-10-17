using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrador.Modelo
{
    public class Transporte
    {
        private Destino ciudadOrigen;
        private Destino ciudadDestino;
        private int tipoTransporte;
        private int costo;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public int TipoTransporte
        {
            get { return tipoTransporte; }
            set { tipoTransporte = value; }
        }

        public Destino CiudadDestino
        {
            get { return ciudadDestino; }
            set { ciudadDestino = value; }
        }

        public Destino CiudadOrigen
        {
            get { return ciudadOrigen; }
            set { ciudadOrigen = value; }
        }
        public Transporte()
        {

        }
    }
}