<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Horarios_Especialidad.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Brigada.Horarios_Especialidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <br />
    <div class="container-fluid" id="Especialidad" runat="server">
        <h2 class="text-center">Registro de Especialidades</h2>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblIDEspecialidad" CssClass="col-sm text-center" Text="Identificador de Especialidad" runat="server" />
                    <asp:TextBox ID="TxtEspecialidad" CssClass="form-control" runat="server" />

                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblEspecialidadNombre" CssClass="col-sm text-center" Text="Nombre de la Especialidad" runat="server" />
                    <asp:TextBox ID="TxtEspecialidaName" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
    </div>



     <div class="container-fluid" id="Horarios" runat="server">
        <h2 class="text-center">Registro de Horarios</h2>
        <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="Label1" CssClass="col-sm text-center" Text="Identificador de Horario" runat="server" />
                    <asp:TextBox ID="TxtIdHorario" CssClass="form-control" runat="server" />

                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblDias" CssClass="col-sm text-center" Text="Dias" runat="server" />
                    <asp:TextBox ID="TxtDias" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
         <div class="row MargenDiv form-inline">
            <!--      ------------------------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblIngreso" CssClass="col-sm text-center" Text="Hora de Ingreso" runat="server" />
                    <asp:TextBox ID="TxtIngreso" CssClass="form-control" runat="server" />

                </div>
            </div>
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblSalida" CssClass="col-sm text-center" Text="Hora de Salida" runat="server" />
                    <asp:TextBox ID="Txtsalida" CssClass="form-control" runat="server" />

                </div>
            </div>
        </div>
    </div>


    <br />
    <!--      ---------------BOTONES---------------             -->
        <div class="form-group row MargenDiv">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" OnClick="BtnAceptar_Click" Text="Guardar" runat="server" />
                &nbsp;&nbsp;
               <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" OnClick="BtnCancelar_Click" Text="Cancelar"  runat="server" CausesValidation="false" />

            </div>
        </div>
</asp:Content>
