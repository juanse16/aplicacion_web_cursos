<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario2.aspx.cs" Inherits="Web.formulario2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css" integrity="sha384-zCbKRCUGaJDkqS1kPbPd7TveP5iyJE0EjAuZQTgFLD2ylzuqKfdKlfG/eSrtxUkn" crossorigin="anonymous">
    <title>Prueba</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="txtID" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:DropDownList ID="dlistap" runat="server"  AutoPostBack="true"  CssClass="form-control "></asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="NOMBRE"></asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
                <asp:TextBox ID="txtAge" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="form-inline">
                <div class="mb-3 mx-sm-3">
                    <asp:Button ID="btnCrear" runat="server" Text="Crear" CssClass="btn btn-success" OnClick="btnCrear_Click" /></div>
                <div class="mb-3 mx-sm-3">
                    <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass="btn btn-secondary" OnClick="btn_buscar_Click" /></div>
                <div class="mb-3 mx-sm-3">
                    <asp:Button ID="btn_actualizar" runat="server" Text="Actualizar" CssClass="btn btn-primary" OnClick="btn_actualizar_Click" /></div>
                <div class="mb-3 mx-sm-3">
                    <asp:Button ID="btn_eliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="btn_eliminar_Click" /></div>
                </div>
            <div class="mb-3 mx-sm-3">
                    <asp:Button ID="btn_global" runat="server" Text="Ver clientes" CssClass="btn btn-dark" OnClick="btn_global_Click" /></div>
            </div>

            <div class="container" runat="server">
            <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
            <asp:GridView ID="datos" runat="server" CssClass="table" AutoGenerateColumns="false" EmptyDataText="No se encontraron registros" howFooter="true" DataKeyNames="id"
                 OnRowEditing="datos_RowEditing" 
                 OnRowCancelingEdit="datos_RowCancelingEdit" OnRowDeleting="datos_RowDeleting" OnRowUpdating="datos_RowUpdating" >
                <Columns>
                    <asp:TemplateField HeaderText="ID">
                         <ItemTemplate>
                             <asp:Label  runat="server" Text='<%# Eval("id") %>'></asp:Label>
                         </ItemTemplate>
                         <EditItemTemplate>
                             <asp:TextBox ID="txtID"  Text='<%# Eval("id") %>' runat="server" CssClass="form-control"></asp:TextBox>
                         </EditItemTemplate>
                     </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre">
                         <ItemTemplate>
                             <asp:Label  runat="server" Text='<%# Eval("name") %>'></asp:Label>
                         </ItemTemplate>
                         <EditItemTemplate>
                             <asp:TextBox ID="txtNombre"  Text='<%# Eval("name") %>' runat="server" CssClass="form-control"></asp:TextBox>
                         </EditItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Edad">
                         <ItemTemplate>
                             <asp:Label  runat="server" Text='<%# Eval("age") %>'></asp:Label>
                         </ItemTemplate>
                         <EditItemTemplate>
                             <asp:TextBox ID="txtAge"  Text='<%# Eval("age") %>' runat="server" CssClass="form-control"></asp:TextBox>
                         </EditItemTemplate>
                     </asp:TemplateField>
                     <asp:TemplateField>
                         <ItemTemplate>
                             <asp:Button ID="btnEditar" Text="Editar"  runat="server" CommandName="Edit" ToolTip="Edit" CssClass="btn btn-primary" />
                             <asp:Button ID="btnEliminar" Text="Eliminar" runat="server" CommandName="Delete" ToolTip="Delete" CssClass="btn btn-danger" />
                         </ItemTemplate>
                         <EditItemTemplate>
                             <asp:Button ID="btnGuardar" Text="Guardar" runat="server" CommandName="Update" ToolTip="Update" CssClass="btn btn-success" />
                             <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CommandName="Cancel" ToolTip="Cancel" CssClass="btn btn-secondary" />   
                         </EditItemTemplate>
                         <FooterTemplate>

                         </FooterTemplate>
                     </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>

    </form>
</body>
</html>
