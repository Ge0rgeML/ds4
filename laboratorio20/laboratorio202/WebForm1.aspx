<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="laboratorio202.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Matriz N x N - Diagonal inversa</title>
    <style>
        .matrix-table td { text-align:center; width:40px; padding:4px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Mostrar una matriz N x N (diagonal inversa = 1)</h3>
            <asp:Label ID="Label1" runat="server" Text="Ingrese N:"></asp:Label>
            <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
            <asp:Button ID="btnGenerar" runat="server" Text="Generar" OnClick="btnGenerar_Click" />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br /><br />
            <asp:Literal ID="litMatrix" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>