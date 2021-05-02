<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ValoracionFuncional.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Ficha_Medica.ValoracionFuncional" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid">
        <h2 style="text-align:center; font-weight:bold; margin-top:18px;">VALORACION PERSONAL</h2>
    
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

  <div class="row MargenDiv form-inline btn-warning" style="margin-left:20px;">
     <!--      --------------Val Apoyo Especial----------------             -->
            <div class="col-sm">
                <div class="row form-group">
                    <asp:Label ID="LblValApoyoEspecial" CssClass="col-sm-8 text-justify" 
                        Text="¿Tiene su niño(a) alguna capacidad diferente que requiera apoyo especial?:" runat="server" Font-Bold="True" />
                     <div class="col-auto">
                     <div class="row form-group">
                        <asp:RadioButtonList ID="ChkValApoyoEspecial" CssClass="col-1 form-check-inline"   runat="server" RepeatDirection="Horizontal" RepeatLayout="Table" CellSpacing="-1" CellPadding="10" Width="30px">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                        </asp:RadioButtonList>
                   </div>
                   </div>
                </div>
            </div>
 </div>
     <!--      --------------Que tipo de Apoyo Requiere // es solo label----------------             -->
           <div class="row MargenDiv form-inline btn-warning">
              <asp:Label ID="LblApoyoRequerido" CssClass="col-sm-7 text-center" Text="¿Que tipo de apoyo requiere?" 
                  runat="server" Font-Bold="true"/>
           </div>
 
<div class="row MargenDiv form-inline btn-warning">

     <!--      --------------Val  Auditivo----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                   <asp:Label ID="LblAuditivo" CssClass="col-sm-3 text-center" Text="Auditivo:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkAuditivo" CssClass="col-1 form-check-inline"   runat="server" RepeatDirection="Horizontal" CellPadding="10" Width="30px">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                </div>
            </div>
 </div>
<div class="row MargenDiv form-inline btn-warning">
     <!--      --------------Val Motor----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                   <asp:Label ID="LblMotor" CssClass="col-sm-3 text-center" Text="Motor:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkMotor" CssClass="col-1 form-check-inline"   runat="server" RepeatDirection="Horizontal" Width="30px" CellPadding="10">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                </div>
            </div>
 </div>
              <div class="row MargenDiv form-inline btn-warning">
     <!--      --------------Val  Visual----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                   <asp:Label ID="LblVisual" CssClass="col-sm-3 text-center" Text="Visual:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkVisual" CssClass="col-1 form-check-inline"   runat="server" CellPadding="10" RepeatDirection="Horizontal" Width="30px">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                </div>
            </div>
 </div>
               <div class="row MargenDiv form-inline btn-warning">
     <!--      --------------Val Idioma----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                   <asp:Label ID="LBLIdioma" CssClass="col-sm-3 text-center" Text="Idioma:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkIdioma" CssClass="col-1 form-check-inline"   runat="server" RepeatDirection="Horizontal" Width="30px" CellPadding="10">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                </div>
            </div>
 </div>
             <div class="row MargenDiv form-inline btn-warning">
     <!--      --------------Val  Otro----------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                   <asp:Label ID="LblOtro" CssClass="col-sm-3 text-center" Text="Otros:" runat="server" Font-Bold="True" />
                    <asp:RadioButtonList ID="ChkOtro" CssClass="col-1 form-check-inline text-center"   runat="server" RepeatDirection="Horizontal" Width="30px" CellPadding="10">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                </div>
            </div>
 </div>
 <!--      --------------Val Especificacion----------------             -->
    <div class="col-sm MargenDiv">
                <div class="row ">
                    <asp:Label ID="LblEspecificacion" CssClass="col-sm-2 col-form-label text-center" Text="Especificacion:" runat="server" Font-Bold="True" />
                    <div class="col-sm">
                    <asp:TextBox ID="TxtEspecificacion" CssClass="form-control" runat="server" />
                </div>
       </div>
   </div>
               <br />
    <!--      ---------------BOTONES---------------             -->
        <div class="form-group row">
       <div class="col-sm text-center">
           <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Aceptar" runat="server"  OnClick="BtnAceptar_Click"/>
            &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click"/>
           <br />
       </div>
   </div>
            <div>
            </div>
    </div>
    <br />
</asp:Content>
