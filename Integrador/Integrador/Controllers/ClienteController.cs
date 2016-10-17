using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Integrador.Controllers
{
    public class ClienteController:Conexion.Conexion
    {
        private static ClienteController instance;
        public static ClienteController GetInstance()
        {
            if (instance == null)
                instance = new ClienteController();

            return instance;
        }
        private ClienteController() { }
        public void agregarCliente(Modelo.Cliente cliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = abrirConexion();
            comando.CommandText = "INSERT INTO Cliente(ci, nombre, direccion, telefono, email, fechaDeNacimiento) VALUES(@ci, @nombre, @direccion, @telefono, @email, @fechaNacimiento)";
            comando.Parameters.AddWithValue("@ci", cliente.Ci);
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
            comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
            comando.Parameters.AddWithValue("@telefono", cliente.Telefono);
            comando.Parameters.AddWithValue("@email", cliente.Email);
            comando.Parameters.AddWithValue("@fechaNacimiento", cliente.FechaDeNacimiento);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }
        public void modificarCliente(Modelo.Cliente clienteAModificar)
        {

            SqlCommand comando = new SqlCommand();
            comando.Connection = abrirConexion();
            comando.CommandText = "UPDATE Clientes SET ci = @ci, nombre = @nombre, direccion=@direccion,telefono=@telefono,email=@email,fechaDeNacimiento=@fechaNacimiento Where ci = @ci";

            comando.Parameters.AddWithValue("@ci", clienteAModificar.Ci);
            comando.Parameters.AddWithValue("@nombre", clienteAModificar.Nombre);
            comando.Parameters.AddWithValue("@direccion", clienteAModificar.Direccion);
            comando.Parameters.AddWithValue("@telefono", clienteAModificar.Telefono);
            comando.Parameters.AddWithValue("@email", clienteAModificar.Email);
            comando.Parameters.AddWithValue("@fechaNacimiento", clienteAModificar.FechaDeNacimiento);

            comando.ExecuteNonQuery();

            cerrarConexion();
        }
        public List<Modelo.Cliente> listarCliente()
        {
            List<Modelo.Cliente> nuevaLista = new List<Modelo.Cliente>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = abrirConexion();
            comando.CommandText = "SELECT * FROM Clientes";

            SqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Modelo.Cliente pCliente = new Modelo.Cliente();
                    pCliente.Ci = (int.Parse(reader["ci"].ToString()));
                    pCliente.Nombre = reader["nombre"].ToString();
                    pCliente.Direccion = reader["direccion"].ToString();
                    pCliente.Telefono = (int.Parse(reader["telefono"].ToString()));
                    pCliente.Email = reader["email"].ToString();
                    pCliente.FechaDeNacimiento = DateTime.Parse(reader["fechaDeNacimiento"].ToString());
                    nuevaLista.Add(pCliente);
                }
            }
            cerrarConexion();
            return nuevaLista;
        }
       
    }
}