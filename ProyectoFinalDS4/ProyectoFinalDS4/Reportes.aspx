<%@ Page Title="Reportes" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Reportes.aspx.cs"
    Inherits="ProyectoFinalDS4.Reportes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Reportes de Tickets</h2>

    <table border="1" cellpadding="8">
        <tr>
            <th>Total de Tickets</th>
            <td><asp:Label ID="lblTotal" runat="server" /></td>
        </tr>
        <tr>
            <th>Tickets Abiertos</th>
            <td><asp:Label ID="lblAbiertos" runat="server" /></td>
        </tr>
        <tr>
            <th>Tickets En Proceso</th>
            <td><asp:Label ID="lblEnProceso" runat="server" /></td>
        </tr>
        <tr>
            <th>Tickets Resueltos</th>
            <td><asp:Label ID="lblResueltos" runat="server" /></td>
        </tr>
    </table>
</asp:Content>
