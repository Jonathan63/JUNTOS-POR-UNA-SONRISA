<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="SignosVitales.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.SignosVitales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <h2 style="text-align: center; font-weight: bold; margin-top: 18px;">SIGNOS VITALES</h2>

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
    <!--      --------------Presion Arterial----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm-4">
            <div class="row form-group">
                <asp:Label ID="LblPresionArterial" CssClass="col-sm text-justify" Text="Presion Arterial:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-auto">
            <div class="row form-group">
                <asp:TextBox ID="TxtPresionArterial" class="col-sm MargenDiv" runat="server" MaxLength="10" />

            </div>
        </div>
    </div>
    <!--      --------------FRECUENCIA CARDIACA----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm-4">
            <div class="row form-group">
                <asp:Label ID="LblFrecuenciaCardiaca" CssClass="col-sm text-justify" Text="Frecuencia Cardiaca (min.):" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-auto">
            <div class="row form-group">
                <asp:TextBox ID="TxtFrecuenciaCardiaca" class="col-sm MargenDiv" runat="server" MaxLength="10" />

            </div>
        </div>
    </div>
    <!--      --------------TEMPERATURA----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm-4">
            <div class="row form-group">
                <asp:Label ID="LblTemperatura" CssClass="col-sm text-justify" Text="Temperatura (°C):" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-auto">
            <div class="row form-group">
                <asp:TextBox ID="TxtTemperatura" class="col-sm MargenDiv" runat="server" MaxLength="10" />

            </div>
        </div>
    </div>
    <!--      --------------FRECUENCIA RESPIRATORIA----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm-4">
            <div class="row form-group">
                <asp:Label ID="LblFRespiratoria" CssClass="col-sm text-justify" Text="F. RESPIRATORIA (min.):" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-auto">
            <div class="row form-group">
                <asp:TextBox ID="TxtFRespiratoria" class="col-sm MargenDiv" runat="server" MaxLength="10" />

            </div>
        </div>
    </div>
    <br />
    <!--      ---------------BOTONES---------------             -->
    <div class="form-group row">
        <div class="col-sm text-center">
            <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" runat="server" OnClick="BtnAceptar_Click" />
            &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            <br />
        </div>
    </div>
    <div>
        <br />
    </div>
</asp:Content>
