<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Diagnostico.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.Diagnostico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 class="text-center">INGRESO DE DATOS DE  DIAGNOSTICO BUCAL</h2>
        <br />
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
           
            <div class="col-sm-6 btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblIDDiagnostico" CssClass="col-sm col-form-label  text-center" Text="Id Diagnostico:" runat="server" />
                    <asp:TextBox ID="TxtIDDiagnostico" CssClass="form-control" runat="server" />
                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                   <asp:Label ID="LblDescripcion" CssClass="col-sm col-form-label  text-center" Text="Descripcion:" runat="server" />
                    <textarea id="LblDescrip"  class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblCie" CssClass="col-sm col-form-label  text-center" Text="Cie:" runat="server" />
                    <asp:TextBox ID="TxtCie" CssClass="form-control" runat="server" />
                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                   <asp:Label ID="LblPre" CssClass="col-sm col-form-label  text-center" Text="Pre:" runat="server" />
                    <asp:TextBox ID="TxtPre" CssClass="form-control" runat="server" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblDef" CssClass="col-sm col-form-label  text-center" Text="Def:" runat="server" />
                    <asp:TextBox ID="TxtDef" CssClass="form-control" runat="server" />
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Aceptar" runat="server" OnClick="BtnAceptar_Click"/>
                &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            </div>
        </div>
        <br /> 
    </div>


</asp:Content>
