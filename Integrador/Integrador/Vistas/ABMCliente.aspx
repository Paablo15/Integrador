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

            <div class="starter-template">
                <h1>Cliente</h1>
                <div class="row">
                    <div class="form-horizontal">
                        <div class="col-md-6">
                            <div class="form-group">
                                <p>Nombre</p>
                                <div class="col-md-10">
                                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <p>Cedula</p>
                                <div class="col-md-10">
                                    <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <p>Direccion</p>
                                <div class="col-md-10">
                                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <p>Telefono</p>
                                <div class="col-md-10">
                                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <p>Email</p>
                                <div class="col-md-10">
                                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <p>Fecha de nacimiento</p>
                                <div class="col-md-10">
                                    <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-md-offset-2 col-md-10">
                                    <asp:Button class="btn btn-primary" ID="btnAltaCliente" runat="server" Text="Dar de alta" OnClick="btnAltaCliente_Click" />
                                    <asp:Button class="btn btn-primary" ID="btnModificarCliente" runat="server" Text="Modificar" OnClick="btnModificarCliente_Click" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lista de Clientes</h2>
                                <div class="col-md-10">

                                    <asp:GridView ID="gvClientes" runat="server" OnSelectedIndexChanged="gvClientes_SelectedIndexChanged">
                                        <Columns>
                                            <asp:CommandField ShowSelectButton="True" ButtonType="Button"></asp:CommandField>
                                        </Columns>
                                    </asp:GridView>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>

        </div>

    </form>
</body>
</html>
