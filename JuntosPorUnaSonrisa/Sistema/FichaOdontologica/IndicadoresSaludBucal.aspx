<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IndicadoresSaludBucal.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.IndicadoresSaludBucal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 class="text-center">INGRESO DE DATOS DE INDICADORES DESALUD BUCAL</h2>
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

        <h4 class="text-center">HIGIENE ORAL SIMPLIFICADA</h4>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="LblPD" CssClass="col-sm col-form-label  text-center" Text=" Piezas Dentales" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <asp:Label ID="LblPlaca" CssClass="col-sm col-form-label  text-center" Text=" Placa" runat="server" />
                    <asp:Label ID="LblCalculo" CssClass="col-sm col-form-label  text-center" Text=" Calculo" runat="server" />
                    <asp:Label ID="LblGingiv" CssClass="col-sm col-form-label  text-center" Text=" Gingivitis" runat="server" />
                </div>
            </div>
        </div>


        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm text-center ">
                <div class="row form-group">
                    <asp:CheckBox ID="Chk16" runat="server" Text="16" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk17" runat="server" Text="17" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk55" runat="server" Text="55" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group text-center">
                    <asp:TextBox ID="TxtPlaca16_55" Width="80px" runat="server" placeholder="0-1-2-3-9" />
                    <asp:TextBox ID="TxtCalculo16_55" Width="80px" runat="server" placeholder="0-1-2-3" />
                    <asp:TextBox ID="TxtGingivitis16_55" Width="80px" runat="server" placeholder="0-1" />
                </div>
            </div>
        </div>


        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:CheckBox ID="Chk11" runat="server" Text="11" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk21" runat="server" Text="21" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk51" runat="server" Text="51" />

                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <asp:TextBox ID="TxtPlaca11_51" Width="80px" runat="server" placeholder="0-1-2-3-9" />
                    <asp:TextBox ID="TxtCalculo11_51" Width="80px" runat="server" placeholder="0-1-2-3" />
                    <asp:TextBox ID="TxtGingivitis11_51" Width="80px" runat="server" placeholder="0-1" />
                </div>
            </div>
        </div>


        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:CheckBox ID="Chk26" runat="server" Text="26" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk27" runat="server" Text="27" />&nbsp;&nbsp;&nbsp;   &nbsp;&nbsp;&nbsp;                
                    <asp:CheckBox ID="Chk65" runat="server" Text="65" />

                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <asp:TextBox ID="TxtPlaca26_65" Width="80px" runat="server" placeholder="0-1-2-3-9" />

                    <asp:TextBox ID="TxtCalculo26_65" Width="80px" runat="server" placeholder="0-1-2-3" />

                    <asp:TextBox ID="TxtGingivitis26_65" Width="80px" runat="server" placeholder="0-1" />
                </div>
            </div>
        </div>


        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">

                    <asp:CheckBox ID="Chk36" runat="server" Text="36" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk37" runat="server" Text="37" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk75" runat="server" Text="75" />

                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">

                    <asp:TextBox ID="TxtPlaca36_75" Width="80px" runat="server" placeholder="0-1-2-3-9" />

                    <asp:TextBox ID="TxtCalculo36_75" Width="80px" runat="server" placeholder="0-1-2-3" />

                    <asp:TextBox ID="TxtGingivitis36_75" Width="80px" runat="server" placeholder="0-1" />
                </div>
            </div>
        </div>


        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">

                    <asp:CheckBox ID="Chk31" runat="server" Text="31" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk41" runat="server" Text="41" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk71" runat="server" Text="71" />

                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">

                    <asp:TextBox ID="TxtPlaca31_71" Width="80px" runat="server" placeholder="0-1-2-3-9" />

                    <asp:TextBox ID="TxtCalculo31_71" Width="80px" runat="server" placeholder="0-1-2-3" />

                    <asp:TextBox ID="TxtGingivitis31_71" Width="80px" runat="server" placeholder="0-1" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">

                    <asp:CheckBox ID="Chk46" runat="server" Text="46" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk47" runat="server" Text="47" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBox ID="Chk85" runat="server" Text="85" />

                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">

                    <asp:TextBox ID="TxtPlaca46_85" Width="80px" runat="server" placeholder="0-1-2-3-9" />

                    <asp:TextBox ID="TxtCalculo46_85" Width="80px" runat="server" placeholder="0-1-2-3" />

                    <asp:TextBox ID="TxtGingivitis46_85" Width="80px" runat="server" placeholder="0-1" />
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="Label4" CssClass="col-sm col-form-label  text-center" Text=" Totales  " runat="server" />

                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">

                    <asp:TextBox ID="TxtTotalPlac" Width="80px" runat="server" />

                    <asp:TextBox ID="TxtTotalCalculo" Width="80px" runat="server" />

                    <asp:TextBox ID="TxtTotalGingivitis" Width="80px" runat="server" />
                </div>
            </div>
        </div>

        <hr />
         <h4 class="text-center">Problemas Bucales </h4>
       

        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="Label1" CssClass="col-sm col-form-label  text-center" Text=" Peridontal" runat="server" />
                    <asp:DropDownList ID="CmbEnfPeridontal" runat="server">
                        <asp:ListItem Value="L">Leve</asp:ListItem>
                        <asp:ListItem Value="M">Moderado</asp:ListItem>
                        <asp:ListItem Value="S">Severo</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <asp:Label ID="Label2" CssClass="col-sm col-form-label  text-center" Text=" Mal Oclusion" runat="server" />
                    <asp:DropDownList ID="CmbMalOclusion" runat="server">
                        <asp:ListItem Value="I" Text="Angle I"></asp:ListItem>
                        <asp:ListItem Value="M">Angle II</asp:ListItem>
                        <asp:ListItem Value="S">Angle III</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="col-sm ">
                <div class="row form-group">
                    <asp:Label ID="Label3" CssClass="col-sm col-form-label  text-center" Text=" Fluorosis" runat="server" />
                    <asp:DropDownList ID="CmbFluorosis" runat="server">
                        <asp:ListItem Value="L">Leve</asp:ListItem>
                        <asp:ListItem Value="M">Moderado</asp:ListItem>
                        <asp:ListItem Value="S">Severo</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <hr />

        <h4 class="text-center">INDICES CPO-ceo </h4>
        


        <div class="row MargenDiv form-inline btn-warning">
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label ID="Label8" CssClass="col-sm col-form-label  text-center" Text=" D" runat="server" />

                    <asp:TextBox ID="TxtDC" Width="80px" runat="server" Placeholder="C" />

                    <asp:TextBox ID="TxtDP" Width="80px" runat="server" Placeholder="P" />

                    <asp:TextBox ID="TxtDO" Width="80px" runat="server" Placeholder="O" />

                    <asp:TextBox ID="TexTotalCPO" Width="80px" runat="server" Placeholder="Total" />
                </div>
            </div>

        </div>



        <div class="row MargenDiv form-inline btn-warning">

            <div class="col-sm ">
                <div class="row form-group">
                    <asp:Label ID="Label9" CssClass="col-sm col-form-label  text-center" Text=" d" runat="server" />

                    <asp:TextBox ID="Txtc" Width="80px" runat="server" Placeholder="c" />

                    <asp:TextBox ID="Txte" Width="80px" runat="server" Placeholder="e" />

                    <asp:TextBox ID="Txto" Width="80px" runat="server" Placeholder="o" />

                    <asp:TextBox ID="TxtTotalceo" Width="80px" runat="server" Placeholder="Total" />
                </div>
            </div>
        </div>
        <br />
        <br />
        <div class="form-group row">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Aceptar" runat="server" OnClick="BtnAceptar_Click" />

                <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            </div>
        </div>
        <br />


    </div>
</asp:Content>
