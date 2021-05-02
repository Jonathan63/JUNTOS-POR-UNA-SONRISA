<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Frecuencia.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Antecedentes.Frecuencia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid">
        <h2 class="text-center">Frecuencia de Consumo</h2>
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








        <asp:Table ID="Table1" runat="server" GridLines="Both" Height="100%" Width="100%">
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" ColumnSpan="4"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" ColumnSpan="3" Text="Veces a la semana"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" ColumnSpan="4" Text="Veces al dia"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Alimento" Width="200px"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="Nunca"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="Menos de una vez al mes" Width="100px"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="1-3 veces al mes" Width="100px"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="1"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="2-4"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="5-6"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="1"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="2-3"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="4-5"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server" Text="6"></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="frutas"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FA" ID="FA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FA" ID="FA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FA" ID="FA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FB" ID="FB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FB" ID="FB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FB" ID="FB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FC" ID="FC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FC" ID="FC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FC" ID="FC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="FC" ID="FC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Verduras"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VA" ID="VA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VA" ID="VA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VA" ID="VA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VB" ID="VB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VB" ID="VB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VB" ID="VB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VC" ID="VC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VC" ID="VC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VC" ID="VC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="VC" ID="VC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Leche Entera"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LA" ID="LA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LA" ID="LA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LA" ID="LA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LB" ID="LB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LB" ID="LB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LB" ID="LB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LC" ID="LC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LC" ID="LC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LC" ID="LC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LC" ID="LC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Leche deslactosada"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDA" ID="LDA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDA" ID="LDA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDA" ID="LDA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDB" ID="LDB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDB" ID="LDB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDB" ID="LDB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDC" ID="LDC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDC" ID="LDC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDC" ID="LDC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="LDC" ID="LDC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Yogurt"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YA" ID="YA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YA" ID="YA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YA" ID="YA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YB" ID="YB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YB" ID="YB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YB" ID="YB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YC" ID="YC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YC" ID="YC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YC" ID="YC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YC" ID="YC4" />
                </asp:TableCell>

            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Yogurt con frutas"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFA" ID="YFA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFA" ID="YFA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFA" ID="YFA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFB" ID="YFB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFB" ID="YFB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFB" ID="YFB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFC" ID="YFC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFC" ID="YFC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFC" ID="YFC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="YFC" ID="YFC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Queso bajo en grasas (panela, fresco, cottage)"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QA" ID="QA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QA" ID="QA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QA" ID="QA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QB" ID="QB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QB" ID="QB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QB" ID="QB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QC" ID="QC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QC" ID="QC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QC" ID="QC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QC" ID="QC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Queso alto en grasas (amarillo, manchego, chihuahua)"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAA" ID="QAA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAA" ID="QAA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAA" ID="QAA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAB" ID="QAB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAB" ID="QAB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAB" ID="QAB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAC" ID="QAC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAC" ID="QAC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAC" ID="QAC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="QAC" ID="QAC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Embutidos (jamón, salchicha)"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EA" ID="EA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EA" ID="EA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EA" ID="EA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EB" ID="EB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EB" ID="EB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EB" ID="EB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EC" ID="EC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EC" ID="EC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EC" ID="EC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="EC" ID="EC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Huevo"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HA" ID="HA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HA" ID="HA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HA" ID="HA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HB" ID="HB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HB" ID="HB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HB" ID="HB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HC" ID="HC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HC" ID="HC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HC" ID="HC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="HC" ID="HC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Carne de pollo"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PA" ID="PA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PA" ID="PA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PA" ID="PA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PB" ID="PB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PB" ID="PB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PB" ID="PB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PC" ID="PC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PC" ID="PC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PC" ID="PC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="PC" ID="PC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Carne de res"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RA" ID="RA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RA" ID="RA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RA" ID="RA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RB" ID="RB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RB" ID="RB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RB" ID="RB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RC" ID="RC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RC" ID="RC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RC" ID="RC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="RC" ID="RC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Carne de cerdo"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CA" ID="CA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CA" ID="CA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CA" ID="CA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CB" ID="CB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CB" ID="CB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CB" ID="CB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CC" ID="CC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CC" ID="CC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CC" ID="CC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="CC" ID="CC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Mariscos (Barbacoa, Pescado)"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MA" ID="MA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MA" ID="MA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MA" ID="MA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MB" ID="MB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MB" ID="MB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MB" ID="MB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MC" ID="MC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MC" ID="MC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MC" ID="MC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="MC" ID="MC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Vísceras (Hígado de res)"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SA" ID="SA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SA" ID="SA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SA" ID="SA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SB" ID="SB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SB" ID="SB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SB" ID="SB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SC" ID="SC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SC" ID="SC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SC" ID="SC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="SC" ID="SC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Leguminosas (frijol, haba, lentejas, alubias, soya)"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JA" ID="JA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JA" ID="JA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JA" ID="JA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JB" ID="JB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JB" ID="JB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JB" ID="JB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JC" ID="JC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JC" ID="JC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JC" ID="JC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="JC" ID="JC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Agua"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AA" ID="AA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AA" ID="AA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AA" ID="AA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AB" ID="AB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AB" ID="AB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AB" ID="AB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AC" ID="AC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AC" ID="AC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AC" ID="AC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="AC" ID="AC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Bebidas Azucaradas"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BA" ID="BA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BA" ID="BA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BA" ID="BA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BB" ID="BB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BB" ID="BB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BB" ID="BB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BC" ID="BC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BC" ID="BC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BC" ID="BC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="BC" ID="BC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Snack dulce"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KA" ID="KA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KA" ID="KA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KA" ID="KA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KB" ID="KB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KB" ID="KB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KB" ID="KB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KC" ID="KC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KC" ID="KC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KC" ID="KC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="KC" ID="KC4" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow CssClass="align-content-center" runat="server">
                <asp:TableCell CssClass="text-center" runat="server" Text="Snack salado"></asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NA" ID="NA1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NA" ID="NA2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NA" ID="NA3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NB" ID="NB1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NB" ID="NB2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NB" ID="NB3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NC" ID="NC1" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NC" ID="NC2" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NC" ID="NC3" />
                </asp:TableCell>
                <asp:TableCell CssClass="text-center" runat="server">
                    <asp:RadioButton runat="server" GroupName="NC" ID="NC4" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>








        <br />
        <!--      ---------------BOTONES---------------             -->
        <div class="form-group row MargenDiv">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" OnClick="BtnAceptar_Click" runat="server" />
                &nbsp;&nbsp;
               <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" OnClick="BtnCancelar_Click" runat="server" CausesValidation="false" />

            </div>
        </div>
        <br />
    </div>
</asp:Content>
