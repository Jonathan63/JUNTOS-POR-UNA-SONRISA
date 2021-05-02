<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AntecedentesNeuropsicologico.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Antecedentes.AntecedentesNeuropsicologico" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
     <div class="container-fluid">
         <h2 style="text-align:center; font-weight:bold;  margin-top:18px;">ANTECEDENTE NEUROPSICOLOGICO</h2>

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

 <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Conducta Casa----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuConductaCasa" CssClass="col-sm-7 text-justify" Text="Su conducta en casa es:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuConductaCasa" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" Width="30px" RepeatDirection="Horizontal" CellSpacing="1">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
     <!--      --------------Neu Casa Edad----------------             -->
    <div class="col-auto">
            <div class="row form-group">
                <asp:Label ID="LblNeuCasaEdad" CssClass="col-auto" Text="Edad:" runat="server" />
                <asp:TextBox ID="TxtNeuCasaEdad" CssClass="col-sm-3 MargenDiv" runat="server" MaxLength="20" />
           </div>
   </div>
 </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Conducta Escuela----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuConductaEscuela" CssClass="col-sm-7 text-justify" Text="Su conducta en escuela es:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuConductaEscuela" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" Width="30px" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
     <!--      --------------Neu Conducta Escuela Edad----------------             -->
    <div class="col-auto">
                <div class="row form-group ">
       <asp:Label ID="LblNeuConductaEscuelaEdad" CssClass="col-auto" Text="Edad:" runat="server" />
           <asp:TextBox ID="TxtNeuConductaEscuelaEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
       </div>
       </div>
   </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Aprovechamiento----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuAprovechamiento" CssClass="col-sm-7 text-justify" Text="Su aprovechamiento es:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuAprovechamiento" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="30px">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
               <!--      --------------Neu Aprovechamiento Edad----------------             -->
    <div class="col-auto">
                <div class="row form-group">
       <asp:Label ID="LblNeuAprovechamientoEdad" CssClass="col-auto" Text="Edad:" runat="server" />
           <asp:TextBox ID="TxtNeuAprovechaientoEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
       </div>
       </div>
          </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Pierde Equilibrio----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuPierdeEquilibrio" CssClass="col-sm-7 text-justify" Text="Pierde el quilibrio con facilidad:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuPierdeEquilibrio" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="30px">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
               <!--      --------------Neu Pierde Equilibrio Edad----------------             -->
    <div class="col-auto">
                <div class="row form-group">
       <asp:Label ID="LblNeuPierdeEquilibrioEdad" CssClass="col-auto" Text="Edad:" runat="server" />
           <asp:TextBox ID="TxtNeuPierdeEquilibrioEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
       </div>
       </div>
   </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Dificultad Para Hablar----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuDifHablar" CssClass="col-sm-7 text-justify" Text="Dificultad para hablar:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuDifHablar" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="0px">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
               <!--      --------------Neu Dificultad Para Hablar----------------             -->
    <div class="col-auto">
                <div class="row form-group">
       <asp:Label ID="LblNeuDifHablarEdad" CssClass="col-auto" Text="Edad:" runat="server" />
           <asp:TextBox ID="TxtNeuDifHablarEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
       </div>
       </div>
   </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Dificultad Consiliar Sueño----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuConsiliarSueno" CssClass="col-sm-7 text-justify" Text="Dificultad para consiliar el sueño:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuConsiliarSueno" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="30px">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
               <!--      --------------Neu Dificultad Consiliar Sueño----------------             -->
    <div class="col-auto">
                <div class="row form-group">
       <asp:Label ID="LblNeuConsiliarSuenoEdad" CssClass="col-auto" Text="Edad:" runat="server" />
           <asp:TextBox ID="TxtNeuConsiliarSuenoEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
       </div>
       </div>
   </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Despierta Noche----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuDespiertaNoche" CssClass="col-sm-7 text-justify" Text="Despierta durante la noche:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuDespiertaNoche" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="30px">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
               <!--      --------------Neu Despierta Noche Edad----------------             -->
    <div class="col-auto">
                <div class="row form-group">
       <asp:Label ID="LblNeuDespiertaNocheEdad" CssClass="col-auto" Text="Edad:" runat="server" />
           <asp:TextBox ID="TxtNeuDespiertaNocheEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
       </div>
       </div>
   </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Desmayo----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuDesmayo" CssClass="col-sm-7 text-justify" Text="Se ha desmayado alguna vez:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuDesmayo" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="30px">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
               <!--      --------------Neu Desmayo Edad----------------             -->
    <div class="col-auto">
                <div class="row form-group">
       <asp:Label ID="LblNeuDesmayoEdad" CssClass="col-auto" Text="Edad:" runat="server" />
           <asp:TextBox ID="TxtNeuDesmayoEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
       </div>
       </div>
   </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Como Ve----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuComoVe" CssClass="col-sm-7 text-justify" Text="¿Como ve?:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuComoVe" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="30px">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
               <!--      --------------Como Ve----------------             -->
    <div class="col-auto">
                <div class="row form-group">
                <asp:Label ID="LblNeuComoVeEdad" CssClass="col-auto" Text="Edad:" runat="server" />
                <asp:TextBox ID="TxtNeuComoVeEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
                </div>
       </div>
   </div>

      <div class="row MargenDiv form-inline" style="margin-left:30px;">
     <!--      --------------Neu Como Oye----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNeuComoOye" CssClass="col-sm-7 text-justify" Text="¿Como oye?:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkNeuComoOye" CssClass="col-sm form-check-inline text-center"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="30px">
                        <asp:ListItem Text="Buena" Value="B"/>
                        <asp:ListItem Text="Regular" Value="R" />  
                        <asp:ListItem Text="Mala" Value="M" />
                    </asp:RadioButtonList>
                </div>
            </div>
               <!--      --------------Como Oye----------------             -->
    <div class="col-auto">
                <div class="row form-group">
                <asp:Label ID="LblNeuComoOyeEdad" CssClass="col-auto" Text="Edad:" runat="server" />
               <asp:TextBox ID="TxtNeuComoOyeEdad" CssClass="col-sm-3 MargenDiv" runat="server" />
       </div>
     </div>
    </div>
    <!--      ---------------BOTONES---------------             -->
        <div class="form-group row">
       <div class="col-sm text-center">
           <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" runat="server"  OnClick="BtnAceptar_Click"/>
            &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click"/>

       </div>
   </div>
    <div>
        
    </div>
     </div>
    <br />
</asp:Content>
