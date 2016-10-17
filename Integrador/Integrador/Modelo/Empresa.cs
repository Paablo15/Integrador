using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integrador.Modelo
{
    public class Empresa
    {
        private static Empresa instance;
        public static Empresa GetInstance()
        {
            if (instance == null)
                instance = new Empresa();

            return instance;
        }
        private Empresa() { }

        public void altaCliente(string nombre,int cedula,string direccion,int telefono, string email, DateTime fecha) {

            Cliente c = new Cliente(cedula,nombre,direccion,telefono,email,fecha);
            
            c.agregarCliente();
        }
        public void modificarCliente(string nombre, int cedula, string direccion, int telefono, string email, DateTime fecha) {

            Cliente c = new Cliente(cedula, nombre, direccion, telefono, email, fecha);

            c.modificarCliente();
        }
        public List<Cliente> todosClientes() {
            return Cliente.todosClientes();
        }
        public Cliente darClienteXci(int ci) {
            return Cliente.darClienteXCi(ci);
        }
        internal void altaCliente(string text1, int v1, string text2, int v2, string text3, Func<string> toShortDateString)
        {
            throw new NotImplementedException();
        }
    }
}