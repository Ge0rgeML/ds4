<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="laboratorio20.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            INGRESE UN NUMERO PARA MOSTRAR TABLA DE MULTIPLICAR HASTA EL 25<br />
            NUMERO:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CALCULAR" />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Height="341px" Width="159px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
