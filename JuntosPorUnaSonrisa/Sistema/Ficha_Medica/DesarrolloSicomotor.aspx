<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="DesarrolloSicomotor.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Ficha_Medica.DesarrolloSicomotor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid">
        <h2 class="text-center">DESARROLLO PSICOMOTOR</h2>
        <div class="row MargenDiv form-inline">
            <!--      --------------ID Ficha Medica----------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFichaMedica" CssClass="col-sm-3 text-center" Text="-----" runat="server" />
                    <asp:Label ID="LblPersona" CssClass="col-sm-3 text-center " Text="-----" runat="server" />
                    <asp:Label ID="LblPerNombres" CssClass="col-sm " Text="-----------" runat="server" />

                </div>
            </div>
        </div>
         

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label lID="LblCabeza" CssClass="col-sm col-form-label  text-center" Text="Sostuvo la cabeza:" runat="server" />
                    <asp:TextBox ID="TxtCabeza" CssClass="form-control" runat="server" PlaceHolder="Edad" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblSonrio" CssClass="col-sm col-form-label  text-center" Text="Sonrio:" runat="server" />
                    <asp:TextBox ID="TxtSonrio" CssClass="form-control" runat="server" PlaceHolder="Edad" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblBalbuceo" CssClass="col-sm col-form-label  text-center" Text="Balbuceo:" runat="server" />
                    <asp:TextBox ID="TxtBalbuceo" CssClass="form-control" runat="server" PlaceHolder="Edad" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblSento" CssClass="col-sm col-form-label  text-center" Text="Sento:" runat="server" />
                    <asp:TextBox ID="TxtSento" CssClass="form-control" runat="server" PlaceHolder="Edad" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblGateo" CssClass="col-sm col-form-label  text-center" Text="Gateo:" runat="server" />
                    <asp:TextBox ID="TxtGateo" CssClass="form-control" runat="server" PlaceHolder="Edad" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblCaminoA" CssClass="col-sm col-form-label  text-center" Text="Camino con ayuda:" runat="server" />
                    <asp:TextBox ID="TxtCaminoA" CssClass="form-control" runat="server" PlaceHolder="Edad" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblCaminoS" CssClass="col-sm col-form-label  text-center" Text="Camino Solo:" runat="server" />
                    <asp:TextBox ID="TxtCaminoS" CssClass="form-control" runat="server" PlaceHolder="Edad" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group text-center">
                    <asp:Label ID="LblEscuela" CssClass="col-sm-4  text-center" Text="Como va en la escuela:" runat="server" />
                    <asp:RadioButtonList ID="ChkEscuela" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" CellPadding="10" runat="server">
                        <asp:ListItem Text="Regular" Value="R" />
                        <asp:ListItem Text="Mal" Value="M" />
                        <asp:ListItem Text="Bueno" Value="B" />
                        <asp:ListItem Text="Muy Bueno" Value="N" />
                        <asp:ListItem Text="Exelente" Value="E" />
                    </asp:RadioButtonList>
                </div>
            </div>            
        </div>

         <div class="form-group row">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" runat="server" OnClick="BtnAceptar_Click" />
                &nbsp;&nbsp;
              <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            </div>
        </div>
        

    </div>
    <br />
</asp:Content>
