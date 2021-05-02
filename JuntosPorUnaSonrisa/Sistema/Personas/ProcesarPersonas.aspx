<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ProcesarPersonas.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Personas.ProcesarPersonas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 class="text-center">Datos Personales</h2>
         <div class="row MargenDiv form-inline">
            
            <div class="col-6 btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblIdentificador"  CssClass="col-sm col-form-label text-lg-center" Text="Nº de Registro Personal" runat="server" />
                    <asp:TextBox ID="TxtIdentificador" CssClass="form-control" Enabled="false" runat="server" Width="143px"/>
                    <asp:ImageButton ID="BtnGenerar" OnClick="BtnGenerar_Click" CssClass="btn btn-warning MargenDiv" Visible="false" ToolTip="Generar Ficha Medica" AlternateText="Generar" ImageUrl="~/Imagenes/aleatory.png" runat="server" />
                
               </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblIDPersona"  CssClass="col-sm col-form-label text-lg-center" Text="Cedula" runat="server" />
                    <asp:TextBox ID="TxtIDPersona" CssClass="form-control" runat="server" />
                    
                
               </div>
            </div>

            <div class="col-sm btn-warning">
                <div class="row form-group">
                
                    <asp:Label AssociatedControlID="TxtApellidoP" CssClass="col-sm col-form-label text-lg-right" Text="Apellido Paterno" runat="server" />
                    <asp:TextBox ID="TxtApellidoP" CssClass="form-control" runat="server" />
                    
                
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtApellidoM" CssClass="col-sm col-form-label text-lg-right" Text="Apellido Materno" runat="server" />
                    <asp:TextBox ID="TxtApellidoM" CssClass="form-control" runat="server" />
                    
                    </div>
            </div>

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtNombres" CssClass="col-sm col-form-label text-lg-right" Text="Nombres" runat="server" />
                    <asp:TextBox ID="TxtNombres" CssClass="form-control" runat="server" />
                                   
                </div>
            </div>
        </div>
    
        <div class="row MargenDiv form-inline">

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtEdad" CssClass="col-sm col-form-label text-lg-right" Text="Edad" runat="server" />
                    <asp:TextBox ID="TxtEdad" CssClass="form-control" runat="server" />
                    
                    </div>
            </div>

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="CmbGenero" CssClass="col-sm col-form-label text-lg-right" Text="Genero" runat="server" />
                    <asp:DropDownList ID="CmbGenero" CssClass="form-control text-lg-left" runat="server">
                        <Items>
                            <asp:ListItem Text="Masculino" Value="M"/>
                            <asp:ListItem Text="Femenino" Value="F"/>
                        </Items>
                    </asp:DropDownList> 
                
                    </div>
            </div>
        </div>
    
    
        <div class="row MargenDiv form-inline">

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    
                    <asp:Label AssociatedControlID="TxtReligion" CssClass="col-sm col-form-label text-lg-right" Text="Religion" runat="server" />
                    <asp:TextBox ID="TxtReligion" CssClass="form-control" runat="server" />
                    
                    </div>
            </div>

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtMedicoT" CssClass="col-sm col-form-label text-lg-right" Text="Medico Tratante" runat="server" />
                    <asp:TextBox ID="TxtMedicoT" CssClass="form-control" runat="server" />
                    
                </div>
            </div>
        </div>
    
        <div class="row MargenDiv form-inline">

            <div class="col-sm btn-warning">
                <div class="row form-group"> 
                    <asp:Label AssociatedControlID="TxtNombresM" CssClass="col-sm col-form-label text-lg-right" Text="Nombre de la Madre" runat="server" />
                    <asp:TextBox ID="TxtNombresM" CssClass="form-control" runat="server" />
                    
                    </div>
            </div>

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtEdadM" CssClass="col-sm col-form-label text-lg-right" Text="Edad de la Madre" runat="server" />
                    <asp:TextBox ID="TxtEdadM" CssClass="form-control" runat="server" />
                   
                </div>
            </div>
        </div>
    
    
        <div class="row MargenDiv form-inline">

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtNombresP" CssClass="col-sm col-form-label text-lg-right" Text="Nombre del Padre" runat="server" />
                    <asp:TextBox ID="TxtNombresP" CssClass="form-control" runat="server" />
                        
                    
                </div>
            </div>

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtEdadP" CssClass="col-sm col-form-label text-lg-right" Text="Edad del Padre" runat="server" />
                    <asp:TextBox ID="TxtEdadP" CssClass="form-control" runat="server" />
                        
                    

                </div>
            </div>
        </div>
            
            <!--      ---------------BOTONES---------------             -->
            <div class="form-group row form-inline">
           <div class="col-sm text-center">
               <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Guardar" OnClick="BtnAceptar_Click" runat="server"  />
                &nbsp;&nbsp;
               <asp:Button ID="BtnCancelar"  CssClass="btn btn-danger" Text="Cancelar" OnClick="BtnCancelar_Click" runat="server" CausesValidation="false" />
               
           </div>
       </div>
        <!--      ---------------LISTA DE ERRORES---------------             -->
      <div class="container alert-warning">
          <asp:ValidationSummary  runat="server" HeaderText="Errores encontrados" DisplayMode="BulletList" ShowSummary="true" ShowMessageBox="true" />
      </div>
    </div>
  
</asp:Content>
