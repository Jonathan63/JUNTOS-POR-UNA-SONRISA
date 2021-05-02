<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AparatoSistema.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Ficha_Medica.AparatoSistema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 class="text-center">INGRESO DE DATOS DE INTERROGATORIO POR APARATOS Y SISTEMAS</h2>
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


        <!-- Digestivo-->
         <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblDigestivo" CssClass="col-sm text-center" Text="Digestivo:" runat="server" />
                    <asp:RadioButtonList ID="ChkDigestivo" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblDigestivos" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtDigestivo" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

         <!--  Cardiovascular  -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblCardiovascular" CssClass="col-sm text-center" Text="Cardiovascular:" runat="server" />
                    <asp:RadioButtonList ID="ChkCardiovascular" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblCardiovasculars" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtCardiovascular" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <!--  Pulmonar  -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblPulmonar" CssClass="col-sm text-center" Text="Pulmonar:" runat="server" />
                    <asp:RadioButtonList ID="ChkPulmonar" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblPulmonars" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtPulmonar" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

         <!--  Endocrino  -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblEndocrino" CssClass="col-sm text-center" Text="Endocrino:" runat="server" />
                    <asp:RadioButtonList ID="ChkEndocrino" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEndocrinos" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtEndocrino" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <!--  Urinario  -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblUrinario" CssClass="col-sm text-center" Text="Urinario" runat="server" />
                    <asp:RadioButtonList ID="ChkUrinario" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblUrinarios" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtUrinario" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <!--  Genital  -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblGenital" CssClass="col-sm text-center" Text="Genital" runat="server" />
                    <asp:RadioButtonList ID="ChkGenital" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblGenitals" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtGenital" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

         <!--  Menarca  -->
        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                   <asp:Label ID="LblMenarcas" CssClass="col-sm col-form-label  text-center" Text="Menarca" runat="server" />
                    <textarea id="LblMenarca"  class="col-sm MargenDiv" runat="server" placeholder="dd/mm/aaaa" />
                </div>
            </div>
             <!--  Fum  -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFums" CssClass="col-sm col-form-label  text-center" Text="FUM" runat="server" />
                    <textarea id="LblFum"  class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>
         <!--  Ritmo  -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblRitmo" CssClass="col-sm text-center" Text="Ritmo" runat="server" />
                    <asp:RadioButtonList ID="ChkRitmo" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Irregular" Value="I" />
                        <asp:ListItem Text="Regular" Value="R" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblRitmos" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtRitmo" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

         <!--  Esqueletico  -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblEsqueletico" CssClass="col-sm text-center" Text="Musculo Esqueletico" runat="server" />
                    <asp:RadioButtonList ID="ChkEsqueletico" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEsqueleticos" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtEsqueletico" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

         <!--  Nervioso  -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblNervioso" CssClass="col-sm text-center" Text="Nervioso" runat="server" />
                    <asp:RadioButtonList ID="ChkNervioso" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblNerviosos" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtNervioso" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

         <!--  Psiquiatrico -->
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblPsiquiatrico" CssClass="col-sm text-center" Text="Psiquiatrico" runat="server" />
                    <asp:RadioButtonList ID="ChkPsiquiatrico" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="S/N" Value="S" />
                        <asp:ListItem Text="C/P" Value="C" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblPsiquiatricos" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtPsiquiatrico" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <!--  Botones -->
        <div class="form-group row">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" runat="server" OnClick="BtnAceptar_Click"
                    />
                &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            </div>
        </div>
        <br /> 
    </div>


</asp:Content>
