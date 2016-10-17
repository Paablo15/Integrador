using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Integrador.Controllers;

namespace Integrador.Modelo
{
    public class Cliente
    {
        private int ci;
        private string nombre;
        private string direccion;
        private int telefono;
        private string email;
        private DateTime fechaDeNacimiento;
        #region Propiedades

        public DateTime FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Ci
        {
            get { return ci; }
            set { ci = value; }
        }
        #endregion  
        public Cliente()
        {

        }
        public Cliente(int ci, string nombre, string direccion, int telefono, string email, DateTime fecha)
        {
            Nombre = nombre;
            Ci = ci;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            FechaDeNacimiento = fecha;
        }
        public void agregarCliente()
        {
            ClienteController.GetInstance().agregarCliente(this);
        }
        public void modificarCliente()
        {
            ClienteController.GetInstance().modificarCliente(this);
        }
        public static List<Cliente> todosClientes()
        {
            return ClienteController.GetInstance().listarCliente();
        }
        public static Cliente darClienteXCi(int ci)
        {

            return ClienteController.GetInstance().darClientexCi(ci);
        }
    }

}