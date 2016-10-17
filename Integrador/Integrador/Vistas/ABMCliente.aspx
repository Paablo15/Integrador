<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ABMCliente.aspx.cs" Inherits="Integrador.Vistas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="row">
        <div class="">

        Nombre
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br />
        Cedula
        <asp:TextBox ID="txtCedula" runat="server" ></asp:TextBox>
        <br />
        Direccion
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        <br />
        Telefono
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br />
        Email
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />
        Fecha de nacimiento
        <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
        </div>
        <br />
        <br />
        <br />
        <asp:Button class="btn btn-primary" ID="btnAltaCliente" runat="server" Text="Dar de alta" />
        <asp:Button class="btn btn-primary" ID="btnModificarCliente" runat="server" Text="Modificar" />
        <br />
        <br />
        </div>
    </div>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True"></asp:CommandField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
