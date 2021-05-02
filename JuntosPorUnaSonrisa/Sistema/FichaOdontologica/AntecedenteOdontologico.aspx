<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AntecedenteOdontologico.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.AntecedenteOdontologico" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <h2 style="text-align: center; font-weight: bold; margin-top: 18px;">ANTECEDENTES ODONTOLOGICOS</h2>
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
    <!--      --------------ALERGIA ANTIBIOTICO----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblAlergiaAntibiotico" CssClass="col-sm text-justify" Text="Alergia Antibiotico:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9">
            <div class="row form-group">
                <textarea id="TextAlergiaAntibiotico" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------ALERGIA ANESTECIA----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblAlergiaAnestecia" CssClass="col-sm text-justify" Text="Alergia Anestecia:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextAlergiaAnestecia" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------HEMORRAGIAS----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblHemorragias" CssClass="col-sm text-justify" Text="Hemorragias:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextHemorragias" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------VIH----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblVIH" CssClass="col-sm text-justify" Text="VIH:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextVIH" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------TUBERCULOSIS----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblTuberculosis" CssClass="col-sm text-justify" Text="Tuberculosis:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextTuberculosis" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------ASMA----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblAsma" CssClass="col-sm text-justify" Text="Asma:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextAsma" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------DIABTES----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblDiabetes" CssClass="col-sm text-justify" Text="Diabetes:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextDiabetes" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------HIPERTENCION----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblHipertencion" CssClass="col-sm text-justify" Text="Hipertencion:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextHipertencion" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------ENF. CARDIACA----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblEnfCardiaca" CssClass="col-sm text-justify" Text="Enf. Cardiaca:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextEnfCardiaca" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <!--      --------------Especifique----------------             -->
    <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

        <div class="col-sm">
            <div class="row form-group">
                <asp:Label ID="LblEspecifique" CssClass="col-sm text-justify" Text="Especifique:" runat="server" Font-Bold="true" />
            </div>
        </div>
        <div class="col-sm-9 ">
            <div class="row form-group">
                <textarea id="TextEspecifique" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

            </div>
        </div>
    </div>
    <br />
    <!--      ---------------BOTONES---------------             -->
    <div class="form-group row">
        <div class="col-sm text-center">
            <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Aceptar" runat="server" OnClick="BtnAceptar_Click" />
            &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            <br />
        </div>
    </div>
    <div>
        <br />
    </div>
</asp:Content>
