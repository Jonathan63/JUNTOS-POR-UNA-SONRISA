<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ListarUsuarios.aspx.cs" Inherits="JuntosPorUnaSonrisa.Administracion.Usuarios.ListarUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <%-- Ventana Emergente --%>
    <div id="VentanaEmergente" class="Ventana">
        <asp:Image ImageUrl="~/Imagenes/warning.png" Width="25%" Height="25%" runat="server" />
        <br />
        <asp:Label ID="LbLTitulo" Text="Esta seguro que desea eliminar!" Font-Size="28px" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LblSubtitulo" Text="El registro " runat="server"></asp:Label>
        <asp:Label ID="LblEstado" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblAviso" Text="No podras revertir los cambios!" runat="server" ForeColor="Yellow"></asp:Label>
        <br />
        <br />
        <div class="text-center">
            <asp:Button Text="Aceptar" OnClick="BtnAceptar_Click" Width="85px" CssClass="btn btn-primary" ID="BtnAceptar" runat="server" />
            <asp:Button ID="BtnCancelar" OnClick="BtnCancelar_Click" Width="85px" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" />
        </div>
    </div>
    <div class="container-fluid" id="ContenidoHolder">
        <h2 class="text-center">Listar Usuarios</h2>
        <div class=" container-fluid">

            <div class="row">

                <div class="col-xl">
                    <div class="form-group">
                        <asp:ImageButton ID="BtnNuevo"
                            runat="server"
                            ImageUrl="~/Imagenes/Add.png"
                            OnClick="BtnNuevo_Click"
                            ToolTip="Nuevo Registro"
                            AlternateText="Nuevo" Height="40px" Width="40px" />
                    </div>
                </div>
                <div class="col-sm-auto">
                    <div class="form-inline">
                        <div class="form-group">
                            Buscar: &nbsp;
                        <asp:TextBox ID="TxtBuscar" CssClass="form-control" runat="server" />
                        </div>
                        &nbsp;&nbsp;
                    <asp:ImageButton ID="BtnBuscar"
                        ImageUrl="~/Imagenes/search.png"
                        Text="Aceptar"
                        ToolTip="Buscar"
                        OnClick="BtnBuscar_Click"
                        CssClass="btn btn-warning"
                        runat="server" />
                         <asp:imageButton id="BtnListarTodo" 
                        Visible="false"
                        Text="Aceptar" 
                        ImageUrl="~/Imagenes/mas.png"
                        CssClass="btn btn-warning" 
                        ToolTip="Listar Todo"
                        OnClick="BtnListarTodo_Click"
                        runat="server" 
                        />

                    </div>
                </div>
            </div>
        </div>
        <div class="container-fluid ">
            <div class="row">
                <div class="col">
                    <div class="container" style="align-content: center">
                        <asp:GridView runat="server" ID="GriUsuarios"
                            AutoGenerateColumns="False"
                            CssClass="colorBlanco"
                            OnRowCommand="GriUsuarios_RowCommand" AllowPaging="true"
                            OnPageIndexChanging="GriUsuarios_PageIndexChanging" Height="100%" Width="100%">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        Acciones:
                                    </HeaderTemplate>
                                    <ItemTemplate>
                                        <asp:ImageButton runat="server" ImageUrl="~/Imagenes/Edit.png"
                                            CommandName="Editar" ToolTip="Editar Registro"
                                            CommandArgument='<%# Bind("USR_ID") %>'
                                            ID="BtnEditar" />
                                        <asp:ImageButton runat="server" ImageUrl="~/Imagenes/Delete.png"
                                            CommandName="Borrar" ToolTip="Borrar Registro"
                                            CommandArgument='<%# Bind("USR_ID") %>'
                                            ID="BtnBorrar" />


                                        <!--DataBinder.Eval(Container.DataItem, "PerCedula") Se puede usar este en casao de que falle el anterior Bind -->
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Cuenta:" DataField="USR_ID" />
                                <asp:BoundField HeaderText="Apellido Parterno:" DataField="USR_APELLIDOP" />
                                <asp:BoundField HeaderText="Apellido Materno:" DataField="USR_APELLIDOM" />
                                <asp:BoundField HeaderText="Nombre:" DataField="USR_FIRSTNAME" />
                                <asp:BoundField HeaderText="Rol:" DataField="USR_ROLES" />
                                <asp:BoundField HeaderText="Estado" DataField="USR_ESTADO" />
                            </Columns>
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerSettings FirstPageImageUrl="~/Imagenes/Home.png" LastPageImageUrl="~/Imagenes/Finaly.png" PreviousPageImageUrl="~/Imagenes/Previous.png" NextPageImageUrl="~/Imagenes/Next.png" Mode="NextPreviousFirstLast" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
