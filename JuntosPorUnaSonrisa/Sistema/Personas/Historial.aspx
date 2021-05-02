<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Historial.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Personas.Historial" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid" id="ContenidoHolder">
        <h2 class="text-center">Reporte</h2>
        <div class="row">
          
            <!--      ---------------BUSCAR---------------             -->
            <div class="col-sm-auto">
                <div class="form-inline">
                    <div class="form-group">

                        Buscar: &nbsp;
                        <asp:TextBox ID="TxtBuscar"  CssClass="form-control" runat="server" />
                    </div>
                    &nbsp;&nbsp;
                    <asp:ImageButton ID="BtnBuscar"
                        Text="Aceptar"
                        ImageUrl="~/Imagenes/search.png"
                        CssClass="btn btn-warning"
                        OnClick="BtnBuscar_Click"
                        ToolTip="Buscar"
                        runat="server" />
                    <asp:ImageButton ID="BtnListarTodo"
                        Visible="false"
                        Text="Aceptar"
                        ImageUrl="~/Imagenes/mas.png"
                        CssClass="btn btn-warning"
                        ToolTip="Listar Todo"
                        OnClick="BtnListarTodo_Click"
                        runat="server" />

                </div>
            </div>


        </div>
        <br />

        <!--      ------------------------------             -->

        <div class="container-fluid">
            <div class="row">
                <div class="col">
                    <div class="text-center">
                        <asp:GridView runat="server" ID="GriListado"
                            AutoGenerateColumns="False"
                            CssClass="colorBlanco" 
                            OnPageIndexChanging="GriListado_PageIndexChanging" AllowPaging="true" 
                            Height="100%" Width="100%"
                            PageSize="15">

                            <AlternatingRowStyle BackColor="White" />

                            <Columns>
                                
                                <asp:BoundField HeaderText="" DataField="ID" />
                                <asp:BoundField HeaderText="Usuario" DataField="USUARIO" />
                                <asp:BoundField HeaderText="Fecha" DataField="FECHA" />
                                <asp:BoundField HeaderText="Accion" DataField="ACCION" />
                                <asp:BoundField HeaderText="Ficha" DataField="NUMERO" />

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
        <br />
        <br />

    </div>
</asp:Content>
