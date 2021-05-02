<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ExploracionFisica.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Ficha_Medica.ExploracionFisica" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid">
        <h2 class="text-center">EXPLORACIÓN FÍSICA </h2>
        <div class="row MargenDiv form-inline">
            <!--      --------------ID Ficha Medica----------------             -->
            <div class="col-sm  btn-warning" >
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
                    <asp:Label ID="LblTA" CssClass="col-sm text-center" Text="T.A" runat="server" />
                    <asp:TextBox ID="TxtTA" CssClass="col-sm text-center MargenDiv"  runat="server" />
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblTemperatura" CssClass="col-sm text-center" Text="Temperatura" runat="server" />
                    <asp:TextBox ID="TxtTemperatura" CssClass="col-sm text-center MargenDiv"  runat="server" />
                </div>
            </div>
            
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblPulso" CssClass="col-sm text-center" Text="Pulso" runat="server" />
                    <asp:TextBox ID="TxtPulso" CssClass="col-sm text-center MargenDiv"  runat="server" />
                </div>
            </div>
        
        </div>

        <div class="form-inline MargenDiv row">
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFreCardiaca" CssClass="col-sm text-center" Text="Frecuencia Cardiaca" runat="server" />
                    <asp:TextBox ID="TxtFreCardiaca" CssClass="col-sm text-center MargenDiv"  runat="server" />
                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFreRespiratoria" CssClass="col-sm text-center" Text="Frecuencia Respiratoria" runat="server" />
                    <asp:TextBox ID="TxtFreRespiratoria" CssClass="col-sm text-center MargenDiv"  runat="server" />
                </div>
            </div>
        </div>

        <!--      ------------------------------             -->
        <div class="row MargenDiv form-inline btn-warning tab-content">
            
            <div class="col-sm  " >
                <div class="row form-group">
                    <asp:Label ID="LblCabeza" CssClass="col-sm text-center" Text="Cabeza" runat="server" />
                    <asp:RadioButtonList ID="RbCabeza" CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspecifique" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="LblObsCabeza"  class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline btn-warning tab-content">
            <!--      ------------------------------             -->
            <div class="col-sm  " >
                <div class="row form-group">
                    <asp:Label ID="LblCuello" CssClass="col-sm text-center" Text="Cuello" runat="server" />
                    <asp:RadioButtonList ID="RbCuello" CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label ID="LblObsEspe" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="LblObsCuello" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>



        
        <div class="row MargenDiv form-inline btn-warning">
            <!--      ------------------------------             -->
            <div class="col-sm  " >
                <div class="row form-group">
                    <asp:Label ID="LblExpTorax" CssClass="col-sm text-center" Text="Torax" runat="server" />
                    <asp:RadioButtonList ID="RbExpTorax" CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label ID="LblOEspecifiqueTorax" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="LblObsTorax" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <!--      ------------------------------             -->
            <div class="col-sm  " >
                <div class="row form-group">
                    <asp:Label ID="Label4" CssClass="col-sm text-center" Text="Abdomen" runat="server" />
                    <asp:RadioButtonList ID="RbAbdomen"  CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspAbdomen" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="LblObsAbdomen" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>


        <div class="row MargenDiv form-inline btn-warning">
            <!--      ------------------------------             -->
            <div class="col-sm  " >
                <div class="row form-group">
                    <asp:Label ID="Label5" CssClass="col-sm text-center" Text="Genitales" runat="server" />
                    <asp:RadioButtonList ID="RbGenitales" CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspGenitales" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  ">
                <div class="row form-group">
                    <textarea id="LblObsGenitales" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>


        <div class="row MargenDiv form-inline btn-warning">
            <!--      ------------------------------             -->
            <div class="col-sm  " >
                <div class="row form-group">
                    <asp:Label ID="Label6" CssClass="col-sm text-center" Text="Extremidades" runat="server" />
                    <asp:RadioButtonList ID="RbExtremidades" CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspExtremidades" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm">
                <div class="row form-group">
                    <textarea id="LblobsExtremidades" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline btn-warning">
            <!--      ------------------------------             -->
            <div class="col-sm  " >
                <div class="row form-group">
                    <asp:Label ID="Label7" CssClass="col-sm text-center" Text="Neurologico" runat="server" />
                    <asp:RadioButtonList ID="RbNeurologica" CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspNeurologica" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="LblObsNeurologica" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>
        <div class="row MargenDiv form-inline btn-warning">
            <!--      ------------------------------             -->
            <div class="col-sm  " >
                <div class="row form-group">
                    <asp:Label ID="Label8" CssClass="col-sm text-center" Text="Examen Rectal" runat="server" />
                    <asp:RadioButtonList ID="RbExamenRectal" CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label ID="LblEspExamenRectal" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="LblObsExamenRectal" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>


        <div class="row MargenDiv form-inline btn-warning">
            <!--      ------------------------------             -->
            <div class="col-sm " >
                <div class="row form-group">
                    <asp:Label ID="Label9" CssClass="col-sm text-center" Text="Pelvico" runat="server" />
                    <asp:RadioButtonList ID="RbPelvico" CssClass="col-sm form-check"   runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                    <asp:Label lID="LblEspPelvico" CssClass="col-sm" Text="Especificación" runat="server" />
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm ">
                <div class="row form-group">
                    <textarea id="LblObsPelvico" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                     
                </div>
            </div>
        </div>

        

        <!--      ---------------BOTONES---------------             -->
        <div class="form-group row MargenDiv">
           <div class="col-sm text-center">
               <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Aceptar"  OnClick="BtnAceptar_Click" runat="server"  />
                &nbsp;&nbsp;
               <asp:Button ID="BtnCancelar"  CssClass="btn btn-danger" Text="Cancelar" OnClick="BtnCancelar_Click" runat="server" CausesValidation="false" />

           </div>
       </div>
       
    </div>
    <br />
</asp:Content>