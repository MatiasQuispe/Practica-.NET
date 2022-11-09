<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="AppTurnos.web.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.6.1.js" integrity="sha256-3zlB5s2uwoUzrXK3BT7AX3FyvojsraNFxCc2vC/7pNI=" crossorigin="anonymous"></script>
    <link href="Recursos/css/Style.css" rel="stylesheet" />

    <title>Registro</title>
</head>
<body class="form-control bg-light">
    <div class="container small">
        <div class="row">
            <h2 class="text-center">Formulario de Registro</h2>
            <div class="col">
                <form id="frmRegistrarse" class="form-check" runat="server">
                    <div>
                        <fieldset>
                            <legend>Datos de Login</legend>
                            <asp:Table runat="server">
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label ID="LblUsuario" runat="server" Text="Usuario"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="TxtUsuario" runat="server" CssClass="form-control" placeholder="Nombre de Usuario"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell>
                                        <asp:Label ID="LblContraseña" runat="server" Text="Contraseña"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="TxtContraseña" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:Label ID="LblConfirmarContraseña" runat="server" Text="Confirme Contraseña:"></asp:Label>
                                    </asp:TableCell>
                                    <asp:TableCell>
                                        <asp:TextBox ID="TxtConfirmarContraseña" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow>
                                    <asp:TableCell ColumnSpan="2">
                                        <asp:Label ID="LblError" runat="server" CssClass="alert-danger"></asp:Label>
                                        <asp:Label ID="LblErrorContraseña" runat="server" CssClass="alert-danger"></asp:Label>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>
                        </fieldset>
                        <br />
                        <div>
                            <asp:Button ID="BtnRegistrarse" runat="server" Text="Registrarse" CssClass="btn btn-primary btn-dark" OnClick="BtnRegistrarse_Click"/>
                        </div>
                        <br />
                        <div>
                            <asp:Button ID="BtnRegresar" runat="server" Text="Regresar" CssClass="btn btn-primary btn-info" OnClick="BtnRegresar_Click" />
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
    
</body>
</html>
