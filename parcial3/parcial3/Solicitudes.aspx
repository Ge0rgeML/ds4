<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="parcial3.Solicitudes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <table border="1" width="100%">
    <tr>
        <td><a href="WebForm1.aspx">Inicio</a></td>
        <td><a href="Solicitudes.aspx">Solicitudes Registradas</a></td>
    </tr>
         <br /><br />
</table>
    <form id="form1" runat="server">
        <h2>Solicitudes Registradas</h2>

            <asp:GridView ID="GridSolicitudes" runat="server"
                DataSourceID="SqlSolicitudes"
                AutoGenerateColumns="True"
                AllowPaging="True" AllowSorting="True">
            </asp:GridView>

            <asp:SqlDataSource ID="SqlSolicitudes" runat="server"
                ConnectionString="data source=.\SQLEXPRESS;initial catalog=PasaportesDB;Integrated Security=True"
                SelectCommand="SELECT * FROM Solicitantes">
            </asp:SqlDataSource>
    </form>
</body>
</html>
