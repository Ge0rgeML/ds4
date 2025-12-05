<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="parcial3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
            <div class="row">
                 <asp:GridView ID="GridSolicitantes" runat="server" 
                    DataSourceID="SqlSolicitantes" AutoGenerateColumns="True"
                    AllowPaging="True" AllowSorting="True">
                </asp:GridView>

                <asp:SqlDataSource ID="SqlSolicitantes" runat="server"
                    ConnectionString="data source= CHESTER\SQLEXPRESS;initial catalog=PasaportesDB;persist security info=True;Integrated Security=SSPI;"
                    ProviderName="System.Data.SqlClient"
                    SelectCommand="SELECT * FROM Solicitantes">
                </asp:SqlDataSource>
               
        </div>
    </main>

</asp:Content>
