<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Tratamiento.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.Tratamiento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 class="text-center">INGRESO DE DATOS DE  TRATAMIENTO</h2>
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
            <div class="col-sm-6 btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblIDSecion" CssClass="col-sm col-form-label  text-center" Text="Id Sesion:" runat="server" />
                    <asp:TextBox ID="TxtIDSecion" CssClass="form-control" runat="server" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblZona" CssClass="col-sm col-form-label  text-center" Text="Zona/Diente tratado:" runat="server" />
                    <textarea id="TxtZona" class="col-sm MargenDiv" runat="server" placeholder="Zona blanda y/o Diente tratados"></textarea>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFecha" CssClass="col-sm col-form-label  text-center" Text=" Fecha:" runat="server" />
                    <asp:TextBox ID="TxtFecha" CssClass="form-control" runat="server" type="date" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblDiagnostico" CssClass="col-sm col-form-label  text-center" Text="Diagnostico:" runat="server" />
                    <textarea id="LblDiagnosti" class="col-sm MargenDiv" runat="server" placeholder="Describa"></textarea>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblProsedimientos" CssClass="col-sm col-form-label  text-center" Text="Prosedimientos:" runat="server" />
                    <textarea id="LblProsedimient" class="col-sm MargenDiv" runat="server" placeholder="Describa"></textarea>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblPrescripciones" CssClass="col-sm col-form-label  text-center" Text="Prescripciones:" runat="server" />
                    <textarea id="LblPrescrip" class="col-sm MargenDiv" runat="server" placeholder="Describa"></textarea>
                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblCodigo" CssClass="col-sm col-form-label  text-center" Text=" Codigo:" runat="server" />
                    <asp:TextBox ID="TxtCodigo" CssClass="form-control" runat="server" />
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFirma" CssClass="col-sm col-form-label  text-center" Text="Firma:" runat="server" />
                    <asp:TextBox ID="TxtFirma" CssClass="form-control" runat="server" />
                </div>
            </div>
        </div>
        <div class="form-group row">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Aceptar" runat="server" OnClick="BtnAceptar_Click" />
                &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            </div>
        </div>
        <br />
    </div>
</asp:Content>
