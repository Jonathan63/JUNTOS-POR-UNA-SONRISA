<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AntecedenteFamiliar.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Antecedentes.AntecedenteFamiliar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
    <h2 class="text-center">Registro de Antecedentes Familiares</h2>
        <div class="row MargenDiv form-inline">
        <div class="col-sm btn-warning">
            <div class="row form-group">
                <asp:Label AssociatedControlID="Per" CssClass="col-sm" Text="Apellidos" runat="server" />
                <asp:TextBox ID="Per" CssClass="form-control col-sm" runat="server" Enabled="false" />
                
            </div>
        </div>
            <div class="col-sm btn-warning">
            <div class="row form-group">
                <asp:Label AssociatedControlID="TXTNombres" CssClass="col-sm" Text="Nombres" runat="server" />
                <asp:TextBox ID="TXTNombres" CssClass="form-control col-sm" runat="server" Enabled="false" />
                
            </div>
        </div>
    </div>
    <div class="row MargenDiv form-inline">
       
        <!--      ------------------------------             -->
        <div class="col-sm btn-warning">
            <div class="row form-group">
                <asp:Label ID="TxtParentesco" CssClass="col-sm text-center" Text="Parentesco: " runat="server" />
                <asp:DropDownList ID="CmbParentesco" CssClass="col-sm form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="0" />
                            <asp:ListItem Text="Mamá" Value="1" />
                            <asp:ListItem Text="Papá" Value="2" />
                            <asp:ListItem Text="Abuelo/a" Value="3" />
                            <asp:ListItem Text="Hermano/a" Value="4" />
                            <asp:ListItem Text="Hijo/a" Value="5" />
                            <asp:ListItem Text="Otro" Value="6" />
                        </Items>
                    </asp:DropDownList>
            </div>
        </div>
        <div class="col-sm btn-warning">
            <div class="row form-group">
                <asp:Label AssociatedControlID="TxtAntecedentesN" CssClass="col-sm " Text="Nombre del Pariente" runat="server" />
                <asp:TextBox ID="TxtAntecedentesN" CssClass="form-control" runat="server" />
                
            </div>
        </div>
    </div>
    <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning" >
                <div class="row form-group">
                    <asp:Label ID="LblSano" CssClass="col-sm text-center" Text="Sano" runat="server" />
                    <asp:RadioButtonList ID="ChkSano" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal"  Width="30px" CellPadding="10"  runat="server">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtAntEnfermedad" CssClass="col-sm " Text="Enfermedad" runat="server" />
                    <asp:TextBox ID="TxtAntEnfermedad" CssClass="form-control" runat="server" />
                    
                </div>
            </div>
        </div>
    <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning" >
                <div class="row form-group">
                    <asp:Label ID="LblFallecido" CssClass="col-sm-7 text-center" Text="Fallecido" runat="server" />
                    <asp:RadioButtonList ID="ChkFallecido" CssClass="col-sm form-check-inline"  RepeatDirection="Horizontal"  Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                    </asp:RadioButtonList>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtAntCausa" CssClass="col-sm " Text="Causa" runat="server" />
                    <asp:TextBox ID="TxtAntCausa" CssClass="form-control" runat="server" />
                    
                </div>
            </div>
        </div>
     <div class="row MargenDiv form-inline">
        <!--      ------------------------------             -->
        <div class="col-sm  btn-warning" >
            <div class="row form-group">
                <asp:Label ID="LblFuma" CssClass="col-sm-7 text-center" Text="Fuma" runat="server" />
                <asp:RadioButtonList ID="ChkFuma" CssClass="col-sm form-check-inline"  RepeatDirection="Horizontal"  Width="30px" CellPadding="10" runat="server">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                </asp:RadioButtonList>
            </div>
        </div>
        <!--      ------------------------------             -->
        <div class="col-sm  btn-warning">
            <div class="row form-group">
                <asp:Label ID="LblToma" CssClass="col-sm-7 text-center" Text="Ingiere Licor" runat="server" />
                <asp:RadioButtonList ID="ChkToma" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal"  Width="30px" CellPadding="10"  runat="server">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N" />  
                </asp:RadioButtonList>
            </div>
        </div>
    </div>
    <div class="form-inline MargenDiv row">
     <!--      ------------------------------             -->
            <div class="col-sm-6 btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblDrogas" CssClass="col-sm-7 text-center" Text="Consume Drogas" runat="server" />
                    <asp:RadioButtonList ID="ChkDrogas" CssClass="col-sm form-check-inline" RepeatDirection="Horizontal"  Width="30px" CellPadding="10"  runat="server">
                        <asp:ListItem Text="Si" Value="S"/>
                        <asp:ListItem Text="No" Value="N"/>  
                </asp:RadioButtonList>
                </div>
            </div>
        
        </div>


    <!--      ---------------BOTONES---------------             -->
        <div class="form-group row">
       <div class="col-sm text-center">
           <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" OnClick="BtnAceptar_Click" runat="server"  />
            &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar"  CssClass="btn btn-danger" Text="Cancelar" OnClick="BtnCancelar_Click" runat="server" CausesValidation="false" />

       </div>
   </div>
    <!--      ---------------LISTA DE ERRORES---------------             -->
  <div class="container alert-warning">
      <asp:ValidationSummary runat="server" HeaderText="Errores encontrados" DisplayMode="BulletList" ShowSummary="true" ShowMessageBox="true" />
  </div>
        </div>

</asp:Content>
