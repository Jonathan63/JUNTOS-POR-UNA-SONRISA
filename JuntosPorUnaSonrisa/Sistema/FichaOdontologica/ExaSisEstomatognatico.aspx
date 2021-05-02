<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ExaSisEstomatognatico.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.ExaSisEstomatognatico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 class="text-center">INGRESO DE DATOS DE  EXAMEN DE SYSTEMA ESTOMATOGMATICO</h2>
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
        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblLabios" CssClass="col-sm text-center" Text="Labios:" runat="server" />
                    <asp:RadioButtonList ID="ChkLabios" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblLabioss" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtLabios" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblMejillas" CssClass="col-sm text-center" Text="Mejillas:" runat="server" />
                    <asp:RadioButtonList ID="ChkMejillas" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblMejillass" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtMejillas" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblSuperior" CssClass="col-sm text-center" Text="Maxilar Superior:" runat="server" />
                    <asp:RadioButtonList ID="ChkSuperior" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblSuperiorr" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtSuperior" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblInferior" CssClass="col-sm text-center" Text="Maxilar Inferior:" runat="server" />
                    <asp:RadioButtonList ID="ChkInferior" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblInferiorr" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtInferior" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblLengua" CssClass="col-sm text-center" Text="Lengua:" runat="server" />
                    <asp:RadioButtonList ID="ChkLengua" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblLenguaa" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtLengua" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblPaladar" CssClass="col-sm text-center" Text="Paladar:" runat="server" />
                    <asp:RadioButtonList ID="ChkPaladar" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblPaladarr" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtPaladar" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblPiso" CssClass="col-sm text-center" Text="Piso:" runat="server" />
                    <asp:RadioButtonList ID="ChkPiso" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblPisoo" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtPiso" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblCarrillos" CssClass="col-sm text-center" Text="Carrillos:" runat="server" />
                    <asp:RadioButtonList ID="ChkCarrillos" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblCarrilloss" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtCarrillos" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblSalivales" CssClass="col-sm text-center" Text="Glandulas Salivales:" runat="server" />
                    <asp:RadioButtonList ID="ChkSalivales" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblSalivaless" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtSalivales" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblFaringe" CssClass="col-sm text-center" Text="Oro Faringe:" runat="server" />
                    <asp:RadioButtonList ID="ChkFaringe" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblFaringee" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtFaringe" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblATM" CssClass="col-sm text-center" Text="ATM:" runat="server" />
                    <asp:RadioButtonList ID="ChkATM" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblATMM" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtATM" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblGanglios" CssClass="col-sm text-center" Text="Ganglios:" runat="server" />
                    <asp:RadioButtonList ID="ChkGanglios" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblGanglioss" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtGanglios" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
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
