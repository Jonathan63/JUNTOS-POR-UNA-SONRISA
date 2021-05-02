<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AntecedenteQuirurgico.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Antecedentes.AntecedenteQuirurgico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid">
        <h2 class="text-center">ANTECEDENTES MÉDICO - QUIRURGICOS</h2>
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
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label ID="LblReflujo" CssClass="col-sm-7  text-center" Text="Reflujo:" runat="server" />
                    <asp:RadioButtonList ID="ChkReflujo" AutoPostBack="true" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblCVeses" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbReflujo" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkETiroideas" CssClass="col-sm-7  text-center" Text="Enfermedades Tiroideas:" runat="server" />
                    <asp:RadioButtonList ID="ChkETiroideas" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbTiroideas" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbTiroideas" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkEstrenimiento" CssClass="col-sm-7  text-center" Text="Estrenimiento:" runat="server" />
                    <asp:RadioButtonList ID="ChkEstrenimiento" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbEstrenimiento" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbEstrenimiento" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkDiarrea" CssClass="col-sm-7  text-center" Text="Diarrea:" runat="server" />
                    <asp:RadioButtonList ID="ChkDiarrea" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbDiarrea" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbDiarrea" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkNeumonia" CssClass="col-sm-7  text-center" Text="Neumonia:" runat="server" />
                    <asp:RadioButtonList ID="ChkNeumonia" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbNeumonia" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbNeumonia" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkBronquitis" CssClass="col-sm-7  text-center" Text="Bronquitis:" runat="server" />
                    <asp:RadioButtonList ID="ChkBronquitis" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbBronquitis" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbBronquitis" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkCrup" CssClass="col-sm-7  text-center" Text="Crup:" runat="server" />
                    <asp:RadioButtonList ID="ChkCrup" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbCrup" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbCrup" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkIVUrinarias" CssClass="col-sm-7  text-center" Text="Infeccion vias urinarias:" runat="server" />
                    <asp:RadioButtonList ID="ChkIVUrinarias" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbIVUrinarias" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbIVUrinarias" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkVaricela" CssClass="col-sm-7  text-center" Text="Varicela:" runat="server" />
                    <asp:RadioButtonList ID="ChkVaricela" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbVaricela" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbVaricela" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkEscarlatina" CssClass="col-sm-7  text-center" Text="Escarlatina:" runat="server" />
                    <asp:RadioButtonList ID="ChkEscarlatina" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbEscarlatina" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbEscarlatina" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkDCabeza" CssClass="col-sm-7  text-center" Text="Dolor de Cabeza:" runat="server" />
                    <asp:RadioButtonList ID="ChkDCabeza" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbDCabeza" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbDCabeza" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkNerviosismo" CssClass="col-sm text-center" Text="Nerviosismo / Ansiedad:" runat="server" />
                    <asp:RadioButtonList ID="ChkNerviosismo" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbNerviosismo" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbNerviosismo" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkCombulsiones" CssClass="col-sm  text-center" Text="Convulciones / Epilepcia:" runat="server" />
                    <asp:RadioButtonList ID="ChkCombulsiones" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbCombulsiones" CssClass="col-sm col-form-label  text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbCombulsiones" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row text-center form-group">
                    <asp:Label AssociatedControlID="ChkTransfusiones" CssClass="col-sm  text-center" Text="Transfuciones:" runat="server" />
                    <asp:RadioButtonList ID="ChkTransfusiones" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbTransfuciones" CssClass="col-sm col-form-label text-center" Text="Cuantas Veces" runat="server" />
                    <asp:DropDownList ID="CmbTransfuciones" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="S" />
                            <asp:ListItem Text="1" Value="U" />
                            <asp:ListItem Text="2" Value="D" />
                            <asp:ListItem Text="3" Value="T" />
                            <asp:ListItem Text="> 3" Value="C" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblAlergia" CssClass="col-sm text-center" Text="Alergia:" runat="server" />
                    <asp:RadioButtonList ID="ChkAlergia" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspecifique" CssClass="col-sm" Text="Especificacion" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtEspecifique" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblFracturas" CssClass="col-sm text-center" Text="Fracturas:" runat="server" />
                    <asp:RadioButtonList ID="ChkFracturas" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspecifique1" CssClass="col-sm" Text="Especificacion" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtEspecifique1" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblAccidentes" CssClass="col-sm text-center" Text="Accidentes:" runat="server" />
                    <asp:RadioButtonList ID="ChkAccidente" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspecifique2" CssClass="col-sm" Text="Especificacion" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtEspecifique2" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="TxtCancer" CssClass="col-sm text-center" Text="Cancer o Tumores:" runat="server" />
                    <asp:RadioButtonList ID="ChkCancer" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspecifique3" CssClass="col-sm" Text="Especificacion" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtEspecifique3" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblHospitalizacines" CssClass="col-sm text-center" Text="Hospitalizaciones previas:" runat="server" />
                    <asp:RadioButtonList ID="ChkHospitalizacines" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspecifique4" CssClass="col-sm" Text="Especificacion" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtEspecifique4" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblCirugias" CssClass="col-sm text-center" Text="Cirugias:" runat="server" />
                    <asp:RadioButtonList ID="ChkCirugias" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspecificar5" CssClass="col-sm" Text="Especificacion" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="TxtEspecificar5" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
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
    </div>

    <br />
</asp:Content>
