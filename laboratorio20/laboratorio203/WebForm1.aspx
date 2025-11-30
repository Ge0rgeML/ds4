<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="laboratorio203.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Productos - CRUD</title>
    <style>
        body { font-family: Segoe UI, Tahoma, Arial; background:#f5f5f5; }
        .container { width:820px; margin:18px auto; background:#f0f0f0; padding:12px; border:1px solid #d0d0d0; box-shadow:0 0 0 #fff; }
        .toolbar {
            height:34px;
            background: linear-gradient(#eaeaea,#e6e6e6);
            border:1px solid #d0d0d0;
            padding:4px;
            display:flex;
            align-items:center;
            gap:6px;
        }
        .tb-btn {
            width:28px; height:28px;
            border:1px solid #bdbdbd;
            background:white;
            padding:0; margin:0;
            cursor:pointer;
            text-align:center;
            line-height:26px;
            font-size:14px;
        }
        .search-area { margin-left:12px; display:flex; align-items:center; gap:6px; }
        .search-area label { margin-right:4px; }
        .search-input { width:140px; height:22px; padding:2px 4px; }
        .content { margin-top:14px; }
        .row { display:flex; margin-bottom:14px; align-items:center; }
        .col-id { width:160px; }
        .col-nombre { flex:1; margin-left:18px; }
        .col-field label { display:block; margin-bottom:6px; color:#333; }
        .txt { width:100%; height:24px; padding:2px 6px; box-sizing:border-box; }
        .two-cols { display:flex; gap:40px; }
        .two-cols .col { width:200px; }
        .actions { margin-top:20px; }
        .btn-salir {
            width:120px; height:44px;
            background:#e0e0e0; border:1px solid #bdbdbd;
            font-size:18px; cursor:pointer;
        }
        .messages { margin-top:8px; min-height:18px; }
        .message { color:green; }
        .error { color:#c00; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="toolbar">
                
                <asp:Button ID="btnNuevo" runat="server" CssClass="tb-btn" Text="+" OnClick="btnNuevo_Click" ToolTip="Nuevo" />
                <asp:Button ID="btnGuardar" runat="server" CssClass="tb-btn" Text="💾" OnClick="btnGuardar_Click" ToolTip="Guardar" />
                <asp:Button ID="btnCancelar" runat="server" CssClass="tb-btn" Text="⦻" OnClick="btnCancelar_Click" ToolTip="Cancelar" />
                <asp:Button ID="btnEliminar" runat="server" CssClass="tb-btn" Text="−" OnClick="btnEliminar_Click" ToolTip="Eliminar" />
                
                <div class="search-area" style="margin-left:14px;">
                    <label style="font-size:14px;color:#222;">Buscar por id:</label>
                    <asp:TextBox ID="tstId" runat="server" CssClass="search-input" />
                    <asp:Button ID="btnBuscar" runat="server" CssClass="tb-btn" Text="🔍" OnClick="btnBuscar_Click" ToolTip="Buscar" />
                </div>
            </div>

            <div class="content">
                <div class="row">
                    <div class="col-id col-field">
                        <label for="txtId">Id</label>
                        <asp:TextBox ID="txtId" runat="server" CssClass="txt" ReadOnly="true" />
                    </div>
                    <div class="col-nombre col-field">
                        <label for="txtNombre">Nombre</label>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="txt" />
                    </div>
                </div>

                <div class="row two-cols">
                    <div class="col col-field">
                        <label for="txtPrecio">Precio</label>
                        <asp:TextBox ID="txtPrecio" runat="server" CssClass="txt" />
                    </div>
                    <div class="col col-field">
                        <label for="txtStock">Stock</label>
                        <asp:TextBox ID="txtStock" runat="server" CssClass="txt" />
                    </div>
                </div>

                <div class="actions">
                    <asp:Button ID="btnSalir" runat="server" CssClass="btn-salir" Text="Salir" OnClientClick="window.close(); return false;" />
                </div>

                <div class="messages">
                    <asp:Label ID="lblMessage" runat="server" CssClass="message" />
                    <asp:Label ID="lblError" runat="server" CssClass="error" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>