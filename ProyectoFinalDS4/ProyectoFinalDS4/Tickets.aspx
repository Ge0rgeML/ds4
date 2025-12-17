<%@ Page Title="Tickets" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="Tickets.aspx.cs"
    Inherits="ProyectoFinalDS4.Tickets" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Gestión de Tickets</h2>

    <asp:Button 
        ID="btnNuevoTicket"
        runat="server"
        Text="Nuevo Ticket"
        OnClick="btnNuevoTicket_Click" />

    <hr />

    <asp:Panel ID="pnlFormulario" runat="server" Visible="false">

        <asp:HiddenField ID="hfIdTicket" runat="server" />

        <label>Nombre del solicitante</label><br />
        <asp:TextBox ID="txtNombre" runat="server" /><br /><br />

        <label>Asunto</label><br />
        <asp:TextBox ID="txtAsunto" runat="server" /><br /><br />

        <label>Categoría</label><br />
        <asp:DropDownList ID="ddlCategoria" runat="server">
            <asp:ListItem Text="Redes" Value="Redes" />
            <asp:ListItem Text="Cámaras" Value="Cámaras" />
            <asp:ListItem Text="Equipos" Value="Equipos" />
            <asp:ListItem Text="Software" Value="Software" />
        </asp:DropDownList><br /><br />

        <label>Descripción</label><br />
        <asp:TextBox ID="txtDescripcion"
            runat="server"
            TextMode="MultiLine"
            Rows="4" /><br /><br />

        <label>Prioridad</label><br />
        <asp:DropDownList ID="ddlPrioridad" runat="server">
            <asp:ListItem Text="Baja" Value="Baja" />
            <asp:ListItem Text="Media" Value="Media" />
            <asp:ListItem Text="Alta" Value="Alta" />
        </asp:DropDownList><br /><br />

        <label>Estado</label><br />
        <asp:DropDownList ID="ddlEstado" runat="server">
            <asp:ListItem Text="Abierto" Value="Abierto" />
            <asp:ListItem Text="En Proceso" Value="En Proceso" />
            <asp:ListItem Text="Resuelto" Value="Resuelto" />
        </asp:DropDownList><br /><br />

        <asp:Image
            ID="imgTicket"
            runat="server"
            Width="200px"
            Visible="false" />

        <asp:FileUpload ID="fuImagen" runat="server" /><br /><br />

        <asp:Button
            ID="btnGuardar"
            runat="server"
            Text="Guardar"
            OnClick="btnGuardar_Click" />

    </asp:Panel>

    <hr />

    
    <asp:GridView
    ID="gvTickets"
    runat="server"
    AutoGenerateColumns="false"
    DataKeyNames="IdTicket"
    OnRowCommand="gvTickets_RowCommand" Width="776px">

    <Columns>

        <asp:BoundField DataField="Asunto" HeaderText="Asunto" />
        <asp:BoundField DataField="Categoria" HeaderText="Categoría" />
        <asp:BoundField DataField="Prioridad" HeaderText="Prioridad" />
        <asp:BoundField DataField="Estado" HeaderText="Estado" />

        
        <asp:TemplateField HeaderText="Acciones">
            <ItemTemplate>

                <asp:Button
                    ID="btnEditar"
                    runat="server"
                    Text="Editar"
                    CommandName="Editar"
                    CommandArgument="<%# Container.DataItemIndex %>" />

                <asp:Button
                    ID="btnEliminar"
                    runat="server"
                    Text="Eliminar"
                    CommandName="Eliminar"
                    CommandArgument="<%# Container.DataItemIndex %>"
                    OnClientClick="return confirm('¿Seguro que deseas eliminar este ticket?');" />

            </ItemTemplate>
        </asp:TemplateField>

    </Columns>
</asp:GridView>
</asp:Content>
