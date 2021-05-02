<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="ProcesarUsuarios.aspx.cs" Inherits="JuntosPorUnaSonrisa.Administracion.Usuarios.ProcesarUsuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">

     <div class="container-fluid">
        <h2 class="text-center">Registro De Datos</h2>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:label associatedcontrolid="TxtApellidoP" cssclass="col-sm " text="Apellido Paterno" runat="server" />
                    <asp:textbox id="TxtApellidoP" cssclass="form-control" runat="server" />
                    </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:label associatedcontrolid="TxtApellidoM" cssclass="col-sm" text="Apellido Materno" runat="server" />
                    <asp:textbox id="TxtApellidoM" cssclass="form-control" runat="server" />
                   
                    </div>
            </div>

        </div>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:label associatedcontrolid="TxtFirstName" cssclass="col-sm " text="Primer Nombre" runat="server" />
                    <asp:textbox id="TxtFirstName" cssclass="form-control" runat="server" />
                     </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:label associatedcontrolid="TxtSecondName" cssclass="col-sm" text="Segundo Nombre" runat="server" />
                    <asp:textbox id="TxtSecondName" cssclass="form-control" runat="server" />
                        </div>
            </div>

        </div>

        

        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:label associatedcontrolid="TxtCedula" cssclass="col-sm " text="Cedula" runat="server" />
                    <asp:textbox id="TxtCedula" cssclass="form-control " runat="server" />
                </div>
            </div>
             <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:button id="BtnGenerarUsu" cssclass="btn btn-info col-sm" OnClick="BtnGenerarUsu_Click" text="Generar Usuario" runat="server" />
                    <asp:textbox id="TxtCuenta" cssclass="form-control " runat="server" />
                   
                </div>
            </div>

        </div>

        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:label associatedcontrolid="CmbRol" cssclass="col-sm-6" text="Rol:" runat="server" />
                    <asp:dropdownlist id="CmbRol" cssclass="form-control col-sm-6" runat="server">
                        <Items>
                            <asp:ListItem text="Estudiante Medicina" value="M" />
                            <asp:ListItem text="Estudiante Odontologia" value="O" />
                            <asp:ListItem text="Tutor Medico" value="X" />
                            <asp:ListItem text="Tutor Odontologico" value="Y" />                            
                            <asp:ListItem Text="Administrador" Value="A" />
                        </Items>
                    </asp:dropdownlist>
                </div>
            </div>
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:label associatedcontrolid="CmbEstado" cssclass="col-sm-6" text="Estado:" runat="server" />
                    <asp:dropdownlist id="CmbEstado" cssclass="form-control col-sm-6" runat="server">
                        <Items>
                            <asp:ListItem Text="Activo" Value="A" />
                            <asp:ListItem Text="Inactivo" Value="I" />
                        </Items>
                    </asp:dropdownlist>
                </div>
            </div>
        </div>
        <!--      ---------------BOTONES---------------             -->
        <div class="form-group row MargenDiv">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" OnClick="BtnAceptar_Click" Text="Aceptar" runat="server" />
                &nbsp;&nbsp;
               <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" OnClick="BtnCancelar_Click" Text="Cancelar" runat="server" CausesValidation="false" />

            </div>
        </div>
        <div class="container alert-warning">
            <asp:ValidationSummary runat="server" HeaderText="Errores encontrados" DisplayMode="BulletList" ShowSummary="true" ShowMessageBox="true" />
        </div>
    </div>
</asp:Content>
