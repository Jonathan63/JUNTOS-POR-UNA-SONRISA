<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AntecedenteNutricional.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Antecedentes.AntecedenteNutricional" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid">
        <h2 class="text-center">ANTECEDENTE NUTRICIONAL</h2>
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

        <div class="form-inline MargenDiv row">
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblPeso" CssClass="col-sm text-center" Text="Peso" runat="server" />
                    <asp:TextBox ID="TxtPeso" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblEstatura" CssClass="col-sm text-center" Text="Estatura" runat="server" />
                    <asp:TextBox ID="TxtEstatura" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>



        </div>
        <div class="form-inline MargenDiv row">
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblIndice" CssClass="col-sm text-center" Text="Indice de Masa Corporal(Peso/Estatura^2)" runat="server" />
                    <asp:TextBox ID="TxtIndiceM" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblComidaSolida" CssClass="col-sm text-center" Text="Inicio de Comida Solida ¿a que Edad?" runat="server" />
                    <asp:TextBox ID="TxtComidaSolida" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>

        </div>
        
        <div class="row MargenDiv form-inline btn-warning tab-content">

            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblTexto" CssClass="col-sm" Text="Tipo de Comida Familiar:" runat="server" />
                    <asp:DropDownList ID="ChkTipoComida" CssClass="form-control" runat="server" >
                        <asp:ListItem Text="Seleccionar" Value="S" />
                        <asp:ListItem Text="Vegetarianos" Value="V" />
                        <asp:ListItem Text="Veganos" Value="G" />
                        <asp:ListItem Text="Ovolactovegetarianos" Value="L" />
                        <asp:ListItem Text="Variada" Value="R" />
                        <asp:ListItem Text="Otros" Value="O" />
                    </asp:DropDownList>
                    
                </div>
            </div>
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblOtros" CssClass="col-sm text-center" Text="Otros" runat="server" />
                    <asp:TextBox ID="TxtOtros" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>
            
        </div>

        <div class="row MargenDiv form-inline btn-warning tab-content">
            <div class="col-sm">
                <div class="row form-group">
                    <asp:Label ID="LblDieta" CssClass="col-sm" Text="Dieta Especial" runat="server" />
                   <asp:RadioButtonList ID="RbDieta" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                   
                     <asp:Label ID="LblCual" CssClass="col-sm text-center" Text="Cual?" runat="server" />
                    <asp:TextBox ID="TxtCual" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>
            
        </div>
         <div class="row MargenDiv form-inline btn-warning tab-content">
            <div class="col-sm-6">
                <div class="row form-group">
                   <asp:Button ID="BtnFrecuencia" CssClass="btn btn-info" OnClick="BtnFrecuencia_Click" Text="Frecuencia de Consumo" runat="server" />
                    <asp:Label ID="Label1" CssClass="col-sm" Text="" runat="server" />
                </div>
            </div>
            
        </div>

        <br />
        <!--      ---------------BOTONES---------------             -->
        <div class="form-group row MargenDiv">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" OnClick="BtnAceptar_Click" Text="Guardar" runat="server" />
                &nbsp;&nbsp;
               <asp:Button ID="BtnCancelar" CssClass="btn btn-danger"  OnClick="BtnCancelar_Click" Text="Cancelar" runat="server" CausesValidation="false" />

            </div>
        </div>

    </div>
    <br />
</asp:Content>
