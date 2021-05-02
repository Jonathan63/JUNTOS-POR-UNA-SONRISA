<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AntecedentePerinatal.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Antecedentes.AntecedentePerinatal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid">
        <h2 class="text-center">Registrar Antecedentes Perinatal</h2>
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
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNumEmbarazo" CssClass="col-sm text-center" Text="Numero de Embarazo" runat="server" />
                    <asp:DropDownList ID="CmbNumEmbarazo" CssClass="col-sm form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="0" />
                            <asp:ListItem Text="1" Value="1" />
                            <asp:ListItem Text="2" Value="2" />
                            <asp:ListItem Text="3" Value="3" />
                            <asp:ListItem Text="4" Value="4" />
                            <asp:ListItem Text="5" Value="5" />
                            <asp:ListItem Text="6" Value="6" />
                            <asp:ListItem Text="7" Value="7" />
                            <asp:ListItem Text="8" Value="8" />
                            <asp:ListItem Text="9" Value="9" />
                            <asp:ListItem Text="10" Value="A" />
                            <asp:ListItem Text="> 10" Value="B" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblEmbMultiple" CssClass="col-sm-7 text-center" Text="Embarazo Multiple (gemelos o triates)" runat="server" />
                    <asp:RadioButtonList ID="ChkEmbarazoMult" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblTomaMedicamentos" CssClass="col-sm-7 text-center" Text="¿Toma Medicamentos?" runat="server" />
                    <asp:RadioButtonList ID="ChkTomaMedic" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtQueMedicamento" CssClass="col-sm" Text="¿Que Medicamento?" runat="server" />
                    <asp:TextBox ID="TxtQueMedicamento" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">

                    <asp:Label ID="LblTomaVitaminas" CssClass="col-sm-7 text-center" Text="¿Toma Vitaminas?" runat="server" />
                    <div class="grid-container-2">
                        <asp:RadioButtonList ID="ChkTomaVitam" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                            <asp:ListItem Text="Si" Value="S" />
                            <asp:ListItem Text="No" Value="N" />
                        </asp:RadioButtonList>
                    </div>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtQueVitaminas" CssClass="col-sm" Text="¿Que Vitaminas?" runat="server" />
                    <asp:TextBox ID="TxtQueVitaminas" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtDurEmbarazo" CssClass="col-sm" Text="Duracion de Embarazo (Semanas)" runat="server" />
                    <asp:TextBox ID="TxtDurEmbarazo" CssClass="form-control" runat="server"/>

                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtFumoTomo" CssClass="col-sm " Text="¿Fumó o tomó alguna droga?" runat="server" />
                    <asp:TextBox ID="TxtFumoTomo" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblParNormal" CssClass="col-sm-7 text-center" Text="¿Fue parto normal?" runat="server" />
                    <asp:RadioButtonList ID="ChkPartoNorm" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtObsParto" CssClass="col-sm" Text="¿Observacion Del Parto?" runat="server" />
                    <asp:TextBox ID="TxtObsParto" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtPeso" CssClass="col-sm" Text="¿Cuánto peso?" runat="server" />
                    <asp:TextBox ID="TxtPeso" CssClass="form-control" runat="server" />

                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtTalla" CssClass="col-sm " Text="¿Talla?" runat="server" />
                    <asp:TextBox ID="TxtTalla" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm-6  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtPerCfalico" CssClass="col-sm col-form-label text-lg-right" Text="Perimetro Cefalico" runat="server" />
                    <asp:TextBox ID="TxtPerCfalico" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblTamMetabolico" CssClass="col-sm-7 text-center" Text="Tamiz Metabolico" runat="server" />
                    <asp:RadioButtonList ID="ChkTamizMeta" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Positivo" Value="P" />
                        <asp:ListItem Text="Negativo" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblTamAuditivo" CssClass="col-sm-7 text-center" Text="Tamiz Auditivo" runat="server" />
                    <asp:RadioButtonList ID="ChkTamizAudi" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Positivo" Value="P" />
                        <asp:ListItem Text="Negativo" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblComParto" CssClass="col-sm-7 text-center" Text="¿Tuvo alguna complicación?" runat="server" />
                    <asp:RadioButtonList ID="ChkComplicParto" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtComParto" CssClass="col-sm" Text="Especifique" runat="server" />
                    <asp:TextBox ID="TxtComParto" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblTomoSeno" CssClass="col-sm-7 text-center" Text="¿Tomó seno materno?" runat="server" />
                    <asp:RadioButtonList ID="ChkTomoSeno" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtTiempoSeno" CssClass="col-sm" Text="¿Cuánto tiempo?" runat="server" />
                    <asp:TextBox ID="TxtTiempoSeno" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblTomoFormula" CssClass="col-sm-7 text-center" Text="¿Tomó fórmula?" runat="server" />
                    <asp:RadioButtonList ID="ChkTomoFormula" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal" Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S" />
                        <asp:ListItem Text="No" Value="N" />
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtTomoFormula" CssClass="col-sm" Text="¿Cuál?" runat="server" />
                    <asp:TextBox ID="TxtTomoFormula" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
        <!--      ---------------BOTONES---------------             -->
        <div class="form-group row MargenDiv">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" OnClick="BtnAceptar_Click" runat="server" />
                &nbsp;&nbsp;
               <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" OnClick="BtnCancelar_Click" runat="server" CausesValidation="false" />

            </div>
        </div>
        <div class="container alert-warning">
            <asp:ValidationSummary runat="server" HeaderText="Errores encontrados" DisplayMode="BulletList" ShowSummary="true" ShowMessageBox="true" />
        </div>
    </div>
    <br />
</asp:Content>
