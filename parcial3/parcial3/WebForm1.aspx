<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="parcial3.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Solicitud de Pasaporte</title>
</head>
<body>

    <table border="1" width="100%">
        <tr>
            <td><a href="WebForm1.aspx">Inicio</a></td>
            <td><a href="Solicitudes.aspx">Solicitudes Registradas</a></td>
        </tr>
    </table>
    <br /><br />

    <form id="form1" runat="server">

        <h2>Formulario de Solicitud de Pasaporte</h2>

        Nombre Completo:<br />
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br /><br />

        Cédula:<br />
        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
        <br /><br />

        Correo Electrónico:<br />
        <asp:TextBox ID="txtCorreo" runat="server"></asp:TextBox>
        <br /><br />

        Teléfono:<br />
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
        <br /><br />

        Fecha de Nacimiento:<br />
        <asp:TextBox ID="txtFecha" runat="server" TextMode="Date"></asp:TextBox>
        <br /><br />

        <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
        <br /><br />

        <asp:Label ID="lblMensaje" runat="server"></asp:Label>

    </form>
</body>
</html>
