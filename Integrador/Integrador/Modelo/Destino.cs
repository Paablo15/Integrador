using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrador.Modelo
{
    public class Destino
    {
        private int codigo;
        private string nombre;
        private string pais;
        private string descripcion;
        private int tieneCosta;
        private int costo;

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public int TieneCosta
        {
            get { return tieneCosta; }
            set { tieneCosta = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Destino()
        {

        }
    }
}