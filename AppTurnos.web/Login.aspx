<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AppTurnos.web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.1.js" integrity="sha256-3zlB5s2uwoUzrXK3BT7AX3FyvojsraNFxCc2vC/7pNI=" crossorigin="anonymous"></script>
    <link href="Recursos/css/Style.css" rel="stylesheet" />
    <title>Login</title>
</head>
<body class="bg-light">
    <div class="wrapper">
        <div class="formcontent">
            <form id="frmLogin" runat="server">
                <div class="form-control">
                    <div class="row">
                        <asp:Label class="h2" ID="LblBienvenida" runat="server" Text="App Turnos"></asp:Label>
                    </div>

                    <div>
                        <asp:Label ID="LblUsuario" runat="server" Text="Usuario"></asp:Label>
                        <asp:TextBox ID="TxtUsuario" CssClass="form-control" runat="server" placeholder="Nombre de Usuario"></asp:TextBox>
                    </div>

                    <div>
                        <asp:Label ID="LblContraseña" runat="server" Text="Contraseña"></asp:Label>
                        <asp:TextBox ID="TxtContraseña" CssClass="form-control" runat="server" placeholder="Contraseña"></asp:TextBox>
                    </div>

                    <hr/>

                    <div class="row">
                        <asp:Label ID="LblError" runat="server" CssClass="alert-danger" Text=""></asp:Label>
                    </div>

                    <br/>

                    <div class="row">
                        <asp:Button ID="BtnLogin" CssClass="btn btn-primary" runat="server" Text="Ingresar" OnClick="BtnLogin_Click" />
                    </div>
                 </div>
            </form>
        </div>
    </div>
</body>
</html>
