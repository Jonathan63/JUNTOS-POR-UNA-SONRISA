<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="FichaOdontologica.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.FichaOdontologica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 style="text-align: center; font-weight: bold; margin-top: 18px;">FICHA ODONTOLOGICA</h2>

        <div class="row MargenDiv form-inline">
            <!--      --------------ID Ficha Odonto----------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFichaOdonto" CssClass="col-sm text-center" Text="Nº de Ficha Odontologica" runat="server" />
                    <asp:TextBox ID="TxtFichaOdontologica" CssClass="form-control text-center" runat="server" Width="111px"/>
                    <asp:ImageButton ID="BtnBuscarFO" OnClick="BtnBuscarFO_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Buscar" AlternateText="Buscar" ImageUrl="~/Imagenes/search.png" runat="server" />
                    <asp:ImageButton ID="BtnGenerarFO" OnClick="BtnGenerarFO_Click"  CssClass="btn btn-warning MargenDiv" ToolTip="Generar Ficha Odontologica" AlternateText="Generar" ImageUrl="~/Imagenes/aleatory.png" runat="server" />
                </div>
            </div>
            <!--      ---------------FECHA DE Ficha odonto---------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFechaTexto" CssClass="col-sm  text-center" Text="Fecha" runat="server" />
                    <asp:Label ID="LblFecha" CssClass="col-sm  text-center" Text="---" runat="server" />
                </div>
            </div>

        </div>
        <div class="row MargenDiv form-inline btn-warning">
            <!--      --------------ID Persona----------------             -->
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtPersona" CssClass="col-sm text-center " Text="ID Persona" runat="server" />
                    <asp:ImageButton ID="BtnBuscarP" OnClick="BtnBuscarP_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Buscar" AlternateText="Buscar" ImageUrl="~/Imagenes/search.png" runat="server" />
                    <asp:TextBox ID="TxtPersona" CssClass="form-control text-center" runat="server" Visible="false" />
                    <asp:TextBox ID="TxtCedula" CssClass="form-control text-center" runat="server" />

                </div>
            </div>
            <!--      --------------ID Persona----------------             -->
            <div class="col-sm ">
                <div class="row form-group">

                    <asp:Label ID="LblPerNombres" CssClass="col-sm text-center" Text="-----------" runat="server" />
                     <asp:ImageButton ID="BtnEditarPersona" OnClick="BtnEditarPersona_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Buscar Paciente" AlternateText="Buscar" ImageUrl="~/Imagenes/user.png" runat="server" />
                    
                </div>
            </div>
        </div>

        <div id="ContenidoSecundario" runat="server">

            <div class="row MargenDiv form-inline btn-warning">

                <!--      --------------Persona Informacion Adicional----------------             -->
                <div class="col-sm btn-warning">
                    <div class="row form-group">
                        <asp:Label ID="LblInfAdicional" CssClass="col-sm text-justify" Text="Informacion Adicional:" runat="server" Font-Bold="True" />
                        <asp:RadioButtonList ID="ChkInfAdicional" CssClass="col-sm-9 form-check-inline text-center" runat="server" RepeatDirection="Horizontal" CellPadding="10" Width="30px" TextAlign="Right">
                            <asp:ListItem Text="Menor de 1 año" Value="A" />
                            <asp:ListItem Text="1-4 años" Value="B" />
                            <asp:ListItem Text="5 - 9 años P." Value="C" />
                            <asp:ListItem Text="5  -  14 años N.P" Value="D" />
                            <asp:ListItem Text="10-14 años P." Value="E" />
                            <asp:ListItem Text="15-19 años" Value="F" />
                            <asp:ListItem Text="Mayor de 20 años" Value="G" />
                        </asp:RadioButtonList>
                        <asp:CheckBoxList ID="ChkEmbarazada" CssClass="col-sm-9 form-check-inline text-center" runat="server" RepeatDirection="Horizontal" CellPadding="10" Width="30px" TextAlign="Right">
                            <asp:ListItem Text="Embarazada" Value="E" />
                        </asp:CheckBoxList>
                    </div>
                </div>
            </div>
            <!--      --------------MOTIVO CONSULTA----------------             -->
            <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

                <div class="col-sm">
                    <div class="row form-group">
                        <asp:Label ID="LblMotivoConsulta" CssClass="col-sm text-justify" Text="Motivo Consulta:" runat="server" Font-Bold="true" />
                    </div>
                </div>
                <div class="col-sm-9 ">
                    <div class="row form-group">
                        <textarea id="TextMotivoConsulta" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

                    </div>
                </div>
            </div>
            <!--      --------------ENFERMEDAD ACTUAL----------------             -->
            <div class="row MargenDiv form-inline btn-warning" style="margin-left: 25px; margin-right: 25px;">

                <div class="col-sm">
                    <div class="row form-group">
                        <asp:Label ID="LblEnfermedadActual" CssClass="col-sm text-justify" Text="Enfermedad Actual:" runat="server" Font-Bold="true" />
                    </div>
                </div>
                <div class="col-sm-9 ">
                    <div class="row form-group">
                        <textarea id="TextEnfermedadActual" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

                    </div>
                </div>
            </div>
            <div class="row MargenDiv form-inline">
                <div class="col-sm text-center ">
                    <asp:Button ID="BtnAnteceFamilia" Text="Antecedentes Familiares" OnClick="BtnAnteceFamilia_Click" CssClass="btn btn-warning" ToolTip="Antecedentes Familiares" AlternateText="Antecedentes Familiares" runat="server" />
                </div>
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnSignosVitales" Text="Signos Vitales" OnClick="BtnSignosVitales_Click" CssClass="btn btn-warning" ToolTip="Signos Vitales" AlternateText="Signos Vitales" runat="server" />
                </div>
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnEstogmatogmatico" Text="Sistema Estomatogmático" OnClick="BtnEstogmatogmatico_Click" CssClass="btn btn-warning" ToolTip="Sistema Estomatogmático" AlternateText="Sistema Estomatogmático" runat="server" />
                </div>
            </div>
            <div class="row MargenDiv form-inline">
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnOdontograma" Text="Odontograma" OnClick="BtnOdontograma_Click" CssClass="btn btn-warning" ToolTip="Odontograma" AlternateText="Odontograma" runat="server" />
                </div>
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnIndSaludBucal" Text="Indicadores de salud Bucal" OnClick="BtnIndSaludBucal_Click" CssClass="btn btn-warning" ToolTip="Indicadores de salud Bucal" AlternateText="Indicadores de salud Bucal" runat="server" />
                </div>

                <div class="col-sm  text-center">
                    <asp:Button ID="BtnPlanesDiagnostico" Text="Planes de Diagnostico" OnClick="BtnPlanesDiagnostico_Click" CssClass="btn btn-warning" ToolTip="Planes de Diagnostico, Terapéutico y educacional" AlternateText="Planes de Diagnostico, Terapéutico y educacional" runat="server" />
                </div>
            </div>
            <div class="row MargenDiv form-inline">
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnDiagnostico" Text="Diagnostico" OnClick="BtnDiagnostico_Click" CssClass="btn btn-warning" ToolTip="Diagnostico" AlternateText="Diagnostico" runat="server" />
                </div>

                <div class="col-sm-6  text-center">
                    <asp:Button ID="BtnTratamiento" Text="Tratamiento" OnClick="BtnTratamiento_Click" CssClass="btn btn-warning" ToolTip="Tratamiento" AlternateText="Tratamiento" runat="server" />
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
        <br />
    </div>

</asp:Content>
