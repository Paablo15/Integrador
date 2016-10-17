using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrador.Modelo
{
    public class Excursion
    {
        private int id;
        private string nombre;
        private string descripcion;
        private int duracion;
        // 0 avion, 1 barco, 2 terrestre
        private int tipoTransporte;
        private int costo;

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

        public int Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public Excursion()
        {

        }

    }
}