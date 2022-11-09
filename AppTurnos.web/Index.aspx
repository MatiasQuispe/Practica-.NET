<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AppTurnos.web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet"/>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js"></script>
    
    <title>Inicio</title>
</head>
<body>
    <form id="fmr_index" runat="server">
        <div>
            <asp:Label ID="lblBienvenida" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:Button ID="btnCerrarSesion" CssClass="btn btn-dark" runat="server" Text="Cerrar Sesión" OnClick="btnCerrarSesion_Click"/>
        </div>
    </form>
</body>
</html>
