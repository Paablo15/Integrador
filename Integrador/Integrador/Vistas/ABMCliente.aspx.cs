using Integrador.Modelo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Integrador.Vistas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Empresa miEmpresa = Empresa.GetInstance();
        private DateTime parsedDate;

        protected void Page_Load(object sender, EventArgs e)
        {
            gvClientes.DataSource = miEmpresa.todosClientes();
            gvClientes.DataBind();
        }
        protected void borrarFormulario() {
            txtCedula.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
           
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }

        protected void btnAltaCliente_Click(object sender, EventArgs e)
        {
            miEmpresa.altaCliente(txtNombre.Text, int.Parse(txtCedula.Text), txtDireccion.Text, int.Parse(txtTelefono.Text), txtEmail.Text, Convert.ToDateTime(txtFechaNacimiento.Text));
            Response.Redirect(Request.RawUrl);
        }

        protected void gvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
           int ciBuscar=int.Parse( txtCedula.Text = gvClientes.SelectedRow.Cells[6].Text);
            Cliente c = miEmpresa.darClienteXci(ciBuscar);
            txtCedula.Text = c.Ci.ToString();
            txtDireccion.Text =c.Direccion.ToString();
            txtEmail.Text = c.Email.ToString();

            txtNombre.Text = c.Nombre.ToString();
            txtTelefono.Text = c.Telefono.ToString();
            txtFechaNacimiento.TextMode = TextBoxMode.SingleLine;
            txtFechaNacimiento.Text = c.FechaDeNacimiento.Date.ToString();

        }

        protected void btnModificarCliente_Click(object sender, EventArgs e)
        {
            string datevalue = txtFechaNacimiento.Text;
            DateTime parseada;
            parseada = Convert.ToDateTime(datevalue);
            miEmpresa.modificarCliente(txtNombre.Text, int.Parse(txtCedula.Text), txtDireccion.Text, int.Parse(txtTelefono.Text), txtEmail.Text,parseada);
            Response.Redirect(Request.RawUrl);
        }
    }
}