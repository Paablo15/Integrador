using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrador.Modelo
{
    public class Venta
    {
        private int id;
        private Cliente cliente;
        private Excursion excursion;
        private DateTime fecha;
        private int costo;

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Excursion Excursion
        {
            get { return excursion; }
            set { excursion = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Venta()
        {

        }

    }
}