<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="PlanesDiagnostico.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.PlanesDiagnostico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 class="text-center">INGRESO DE DATOS DE  PLANES DE DIAGNÓSTICO TERAPÉUTICO Y EDUCACIONAL</h2>
        <br />
        <!--      --------------ID FICHA ODONTOLOGICA----------------             -->
    <div class="row MargenDiv form-inline">

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
                    <asp:Label ID="LblBiometria" CssClass="col-sm col-form-label  text-center" Text=" Biometria" runat="server" />
                     <textarea id="TxtBiometria"  class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblSanguinea" CssClass="col-sm col-form-label  text-center" Text="Quimica Sanguinea" runat="server" />
                     <textarea id="TxtSanguinea"  class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>
       
        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblRayos" CssClass="col-sm col-form-label  text-center" Text="Rayos X" runat="server" />
                     <textarea id="TxtRayos"  class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblEspecifique" CssClass="col-sm col-form-label  text-center" Text=" Especifique" runat="server" />
                     <textarea id="TxtEspecifique"  class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="form-group row">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" runat="server" OnClick="BtnAceptar_Click"/>
                &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            </div>
        </div>
        <br /> 

    </div>
</asp:Content>
