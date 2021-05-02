<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Vacunas.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Ficha_Medica.Vacunas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid">
        <h2 class="text-center">INMUNIZACIONES (Vacunas)</h2>
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
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblTUberculosis" CssClass="col-sm text-center" Text="Tuberculosis" runat="server" />
                    <asp:RadioButtonList ID="RbTuberculosis" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>

            <!--      ------------------------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblVaricela" CssClass="col-sm text-center" Text="Varicela" runat="server" />
                    <asp:RadioButtonList ID="RbVaricela" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>


            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeumococo" CssClass="col-sm text-center" Text="Neumococo" runat="server" />
                    <asp:RadioButtonList ID="RbNeumococo" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
        </div>

        <div class="form-inline MargenDiv row">

            <!--      ------------------------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblHepatitis" CssClass="col-sm text-center" Text="Hepatitis" runat="server" />
                    <asp:RadioButtonList ID="RbHepatitis" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>

            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblInfluenza" CssClass="col-sm text-center" Text="Influenza" runat="server" />
                    <asp:RadioButtonList ID="RbInfluenza" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblRotavirus" CssClass="col-sm text-center" Text="Rotavirus" runat="server" />
                    <asp:RadioButtonList ID="RbRotavirus" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>

        </div>


        <div class="form-inline MargenDiv row">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblPolio" CssClass="col-sm text-center" Text="Polio" runat="server" />
                    <asp:RadioButtonList ID="RbPolio" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblPolioCuantas" CssClass="col-sm text-center" Text="Cuantas" runat="server" />
                    <asp:TextBox ID="TxtPolioCuantas" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>

            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblPentavelente" CssClass="col-sm text-center" Text="Pentavelente" runat="server" />
                    <asp:RadioButtonList ID="RbPentavelente" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblPentavelenteCuantas" CssClass="col-sm text-center" Text="Cuantas" runat="server" />
                    <asp:TextBox ID="TxtPentavelenteCuantas" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>

        </div>

        <div class="form-inline MargenDiv row">
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblTripeViral" CssClass="col-sm text-center" Text="TripeViral" runat="server" />
                    <asp:RadioButtonList ID="RbTripeViral" CssClass="col-sm form-check" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblTripeViralCuantas" CssClass="col-sm text-center" Text="Cuantas" runat="server" />
                    <asp:TextBox ID="TxtTripeViralCuantas" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblOtras" CssClass="col-sm text-center" Text="Otras" runat="server" />
                    <asp:RadioButtonList ID="RbOtras" CssClass="col-sm form-check text-center" RepeatDirection="Horizontal" CellPadding="15" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspecifique" CssClass="col-sm text-center" Text="Especifique" runat="server" />
                    <asp:TextBox ID="TxtEspecifique" CssClass="col-sm text-center MargenDiv" runat="server" />
                </div>
            </div>

        </div>
        <br />
        <!--      ---------------BOTONES---------------             -->
        <div class="form-group row MargenDiv">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" OnClick="BtnAceptar_Click" Text="Guardar" runat="server" />
                &nbsp;&nbsp;
               <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" OnClick="BtnCancelar_Click" Text="Cancelar" runat="server" CausesValidation="false" />

            </div>
        </div>

    </div>


    <br />



</asp:Content>
