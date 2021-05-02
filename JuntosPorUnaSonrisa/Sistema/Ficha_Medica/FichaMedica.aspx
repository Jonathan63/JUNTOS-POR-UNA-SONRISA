<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="FichaMedica.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.Ficha_Medica.FichaMedica" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <%-- Ventana Emergente --%>
    <div id="VentanaEmergente" class="Ventana">
        <asp:Image ImageUrl="~/Imagenes/warning.png" Width="25%" Height="25%" runat="server" />
        <br />
        <asp:Label ID="LbLTitulo" Text="Esta seguro que desea eliminar!" Font-Size="28px" runat="server"></asp:Label>
        <br />
        <asp:Label ID="LblSubtitulo" Text="La Historia Medica Nº" runat="server"></asp:Label>
        <asp:Label ID="LblEstado" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="LblAviso" Text="No podras revertir los cambios!" runat="server" ForeColor="Yellow"></asp:Label>
        <br />
        <br />
        <div class="text-center">
            <asp:Button Text="Aceptar" OnClick="BtnAceptarE_Click" Width="85px" CssClass="btn btn-primary" ID="BtnAceptarE" runat="server" />
            <asp:Button ID="BtnCancelarE" OnClick="BtnCancelarE_Click" Width="85px" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" />
        </div>
    </div>
    <div class="container-fluid" id="ContenidoHolder">
        <h2 class="text-center">Ficha medica</h2>

        <div class="row MargenDiv form-inline">
            <!--      --------------ID Ficha Medica----------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtFichaMedica" CssClass="col-sm text-center" Text="Nº de Ficha Medica" runat="server" />
                    <asp:TextBox ID="TxtFichaMedica" CssClass="form-control text-center" runat="server" Width="111px" />
                    <asp:ImageButton ID="BtnBuscarFM" OnClick="BtnBuscarFM_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Buscar Ficha Medica" AlternateText="Buscar" ImageUrl="~/Imagenes/search.png" runat="server" />
                    <asp:ImageButton ID="BtnGenerar" OnClick="BtnGenerar_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Generar Ficha Medica" AlternateText="Generar" ImageUrl="~/Imagenes/aleatory.png" runat="server" />
                </div>
            </div>
            <!--      ---------------FECHA DE Ficha Medica---------------             -->
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFechaFM" CssClass="col-sm  text-center" Text="Fecha" runat="server" />
                    <asp:TextBox ID="TxtFechaFM" CssClass="form-control text-center " runat="server" />
                </div>
            </div>

        </div>
        <div class="row MargenDiv form-inline btn-warning">
            <!--      --------------ID Persona----------------             -->
            <div class="col-sm  ">
                <div class="row form-group">
                    <asp:Label AssociatedControlID="TxtPersona" CssClass="col-sm text-center " Text="ID Persona" runat="server" />
                    <asp:ImageButton ID="BtnBuscarP" OnClick="BtnBuscarP_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Buscar Paciente" AlternateText="Buscar" ImageUrl="~/Imagenes/search.png" runat="server" />
                    <asp:TextBox ID="TxtPersona" CssClass="form-control text-center" Visible="false" runat="server" />
                    <asp:TextBox ID="TxtCedula" CssClass="form-control text-center" runat="server" />

                </div>
            </div>
            <!--      --------------ID Persona----------------             -->
            <div class="col-sm ">
                <div class="row form-group">

                    <asp:Label ID="LblPerNombres" CssClass="col-sm text-center" Text="-----------" runat="server" />
                    <asp:ImageButton ID="BtnEditarPersona" OnClick="BtnEditarPersona_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Buscar Paciente" AlternateText="Buscar" ImageUrl="~/Imagenes/user.png" runat="server" />


                </div>
            </div>
        </div>
        <div class="container-fluid" id="ContenidoEdicion" runat="server">
            <div class="row MargenDiv form-inline">
                <!--      --------------Antecedente Familiar----------------             -->
                <div class="col-sm text-center ">


                    <asp:Button ID="BtnAntcFamiliar" Text="Antecedentes Familiares" OnClick="BtnAntcFamiliar_Click" CssClass="btn btn-warning" ToolTip="Antecedentes Familiares" AlternateText="Antecedentes Familiares" runat="server" />

                </div>
                <!--      --------------Antecedente Perinatal----------------             -->
                <div class="col-sm  text-center">

                    <asp:Button ID="BtnAntcPerinatal" OnClick="BtnAntcPerinatal_Click" Text="Antecedente Perinatal" CssClass="btn btn-warning" ToolTip="Antecedente Perinatal" AlternateText="Antecedente Perinatal" runat="server" />

                </div>
            </div>


            <div class="row MargenDiv form-inline">
                <!--      --------------Vacuna----------------             -->
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnVacuna" Text="Vacunas" OnClick="BtnVacuna_Click" CssClass="btn btn-warning" ToolTip="Vacunas" AlternateText="Vacunas" runat="server" />

                </div>
                <!--      --------------Desarrollo Psicomotor----------------             -->
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnPsicomotor" OnClick="BtnPsicomotor_Click" Text="Desarrollo Psicomotor" CssClass="btn btn-warning" ToolTip="Desarrollo Psicomotor" AlternateText="Desarrollo Psicomotor" runat="server" />

                </div>
            </div>


            <div class="row MargenDiv form-inline">
                <!--      --------------Antecedente Quirurgico----------------             -->
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnQuirurgico" OnClick="BtnQuirurgico_Click" Text="Antecedente Quirurgico" CssClass="btn btn-warning" ToolTip="Antecedente Quirurgico" AlternateText="Antecedente Quirurgico" runat="server" />

                </div>
                <!--      --------------Antecedente Neuropsicologico----------------             -->
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnAntcNeuropsico" OnClick="BtnAntcNeuropsico_Click" Text="Antecedente Neuropsicologico" CssClass="btn btn-warning" ToolTip="Antecedente Neuropsicologico" AlternateText="Antecedente Neuropsicologico" runat="server" />

                </div>
            </div>


            <div class="row MargenDiv form-inline">
                <!--      --------------Valoracion Funcional----------------             -->
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnValoracionFunc" OnClick="BtnValoracionFunc_Click" Text="Valoracion Funcional" CssClass="btn btn-warning" ToolTip="Valoracion Funcional" AlternateText="Valoracion Funcional" runat="server" />

                </div>
                <!--      --------------Antecedente Nutricional----------------             -->
                <div class="col-sm  text-center">
                    <asp:Button ID="BtnAntcNutricional" OnClick="BtnAntcNutricional_Click" Text="Antecedente Nutricional" CssClass="btn btn-warning" ToolTip="Antecedente Nutricional" AlternateText="Antecedente Nutricional" runat="server" />

                </div>
            </div>


            <div class="row MargenDiv form-inline">
                <!--      --------------INTERROGATORIO POR APARATOS Y SISTEMAS----------------             -->
                <div class="col-sm text-center">
                    <asp:Button ID="BtnIntAparSis" OnClick="BtnIntAparSis_Click" Text="Interrogatorio por Aparatos y Sistemas" CssClass="btn btn-warning" ToolTip="Interrogatorio por Aparatos y Sistemas" AlternateText="Interrogatorio por Aparatos y Sistemas" runat="server" />

                </div>
                <!--      ---------------Exploracion Fisica---------------             -->
                <div class="col-sm text-center">
                    <asp:Button ID="BtnExploracionFis" Text="Exploracion Fisica" OnClick="BtnExploracionFis_Click" CssClass="btn btn-warning" ToolTip="Exploracion Fisica" AlternateText="Exploracion Fisica" runat="server" />

                </div>
            </div>

        </div>








        <div class="container-fluid" id="AgregarListar" visible="false" runat="server">

            <div class="row MargenDiv form-inline">
                <!--      --------------Valoracion Funcional----------------             -->
                <div class="col-sm  text-center">
                    <asp:ImageButton ID="BtnNuevo" OnClick="BtnNuevo_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Nuevo" AlternateText="Buscar" ImageUrl="~/Imagenes/Add.png" runat="server" />
                    <asp:ImageButton ID="BtnListar" OnClick="BtnListar_Click" CssClass="btn btn-warning MargenDiv" ToolTip="Listar Todos" AlternateText="Buscar" ImageUrl="~/Imagenes/mas.png" runat="server" />


                </div>

            </div>
        </div>

        <div class="container-fluid" id="ListarHistorial" visible="false" runat="server">
            <div class="row">
                <div class="col">
                    <div class="text-center">
                        <asp:GridView runat="server" ID="GriListado"
                            AutoGenerateColumns="False"
                            OnRowCommand="GriListado_RowCommand" AllowPaging="True" Height="100%" Width="100%"
                            OnPageIndexChanging="GriListado_PageIndexChanging"
                            CssClass="colorBlanco" PageSize="5">

                            <AlternatingRowStyle BackColor="White" />

                            <Columns>
                                <asp:TemplateField>
                                    <HeaderTemplate>
                                        Acciones:
                                    </HeaderTemplate>
                                    <ItemTemplate runat="server">
                                        <asp:ImageButton runat="server" ImageUrl="~/Imagenes/Edit.png"
                                            CommandName="Editar"
                                            CommandArgument='<%# Bind("ID_HISTORIAL") %>'
                                            ID="BtnEditar" />
                                        <asp:ImageButton runat="server" ImageUrl="~/Imagenes/Delete.png"
                                            CommandName="Borrar"
                                            CommandArgument='<%# Bind("ID_HISTORIAL") %>'
                                            ID="BtnBorrar" />
                                        <!--DataBinder.Eval(Container.DataItem, "PerCedula") Se puede usar este en casao de que falle el anterior Bind -->
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField HeaderText="Nº de Historial" DataField="ID_HISTORIAL" />
                                <asp:BoundField HeaderText="Fecha " DataField="FIC_MED_FECHA" />
                                <asp:BoundField HeaderText="Padecimientos" DataField="FICHAPADECIMIENTOACT" />


                            </Columns>
                            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                            <PagerSettings FirstPageImageUrl="~/Imagenes/Home.png" LastPageImageUrl="~/Imagenes/Finaly.png" PreviousPageImageUrl="~/Imagenes/Previous.png" NextPageImageUrl="~/Imagenes/Next.png" Mode="NextPreviousFirstLast" />
                            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                            <SortedAscendingCellStyle BackColor="#FDF5AC" />
                            <SortedAscendingHeaderStyle BackColor="#4D0000" />
                            <SortedDescendingCellStyle BackColor="#FCF6C0" />
                            <SortedDescendingHeaderStyle BackColor="#820000" />
                        </asp:GridView>
                    </div>
                </div>
            </div>

        </div>














        <div class="container-fluid" id="Padecimientos" runat="server">

            <div class="row MargenDiv form-inline btn-warning">



                <div class="col-sm-6 btn-warning">
                    <div class="row form-group">
                        <asp:Label ID="LblNumero" CssClass="col-sm  text-center" Text="Nº Historial" runat="server" />
                        <asp:Label ID="LblNumeroH" CssClass="col-sm  text-center" runat="server" />
                        <asp:Label ID="LblFecha" CssClass="col-sm  text-center" Text="Fecha" runat="server" />
                        <asp:Label ID="LblFechaH" CssClass="col-sm text-center " runat="server" />
                    </div>
                </div>
            </div>

            <!--      ------------------------------             -->
            <div class="row MargenDiv form-inline btn-warning">

                <div class="col-sm-3  ">
                    <div class="row form-group">
                        <asp:Label ID="LblPadecimientoActual" CssClass="col-sm text-center" Text="Padecimiento Actual" runat="server" />

                    </div>
                </div>

                <div class="col-sm ">
                    <div class="row form-group">
                        <textarea id="TxtPadecimientoActual" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

                    </div>
                </div>
            </div>

            <div class="row MargenDiv form-inline btn-warning">
                <!--      ------------------------------             -->
                <div class="col-sm-3  ">
                    <div class="row form-group">
                        <asp:Label ID="LblExamenLab" CssClass="col-sm text-center" Text="EXÁMENES DE LABORATORIO, GABINETE Y OTROS" runat="server" />

                    </div>
                </div>
                <!--      ------------------------------             -->
                <div class="col-sm ">
                    <div class="row form-group">
                        <textarea id="TxtExamenLab" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

                    </div>
                </div>
            </div>
            <div class="row MargenDiv form-inline btn-warning">
                <!--      ------------------------------             -->
                <div class="col-sm-3  ">
                    <div class="row form-group">
                        <asp:Label ID="LblTerapeutica" CssClass="col-sm text-center" Text="TERAPÉUTICA EMPLEADA Y RESULTADOS OBTENIDOS" runat="server" />

                    </div>
                </div>
                <!--      ------------------------------             -->
                <div class="col-sm ">
                    <div class="row form-group">
                        <textarea id="TxtTerapeutica" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

                    </div>
                </div>
            </div>
            <div class="row MargenDiv form-inline btn-warning">
                <!--      ------------------------------             -->
                <div class="col-sm-3  ">
                    <div class="row form-group">
                        <asp:Label ID="LblDiagnostico" CssClass="col-sm text-center" Text="DIAGNÓSTICOS O PROBLEMAS CLINICOS" runat="server" />

                    </div>
                </div>
                <!--      ------------------------------             -->
                <div class="col-sm ">
                    <div class="row form-group">
                        <asp:DropDownList ID="CmbDiagnostico" CssClass="col-sm MargenDiv" runat="server">
                            <Items>
                                <asp:ListItem Text="EUTRÓFICO" Value="1" />
                                <asp:ListItem Text="DESNUTRICIÓN AGUDA" Value="2" />
                                <asp:ListItem Text="DESNUTRICION CRÓNICA" Value="3" />
                                <asp:ListItem Text="SOBREPESO" Value="4" />
                                <asp:ListItem Text="OBESIDAD" Value="5" />
                            </Items>
                        </asp:DropDownList>

                    </div>
                </div>
            </div>
            <div class="row MargenDiv form-inline btn-warning">
                <!--      ------------------------------             -->
                <div class="col-sm-3  ">
                    <div class="row form-group">
                        <asp:Label ID="LblComentarios" CssClass="col-sm text-center" Text="COMENTARIOS" runat="server" />

                    </div>
                </div>
                <!--      ------------------------------             -->
                <div class="col-sm ">
                    <div class="row form-group">
                        <textarea id="TxtComentarios" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

                    </div>
                </div>
            </div>
            <div class="row MargenDiv form-inline btn-warning">
                <!--      ------------------------------             -->
                <div class="col-sm-3  ">
                    <div class="row form-group">
                        <asp:Label ID="LblComMedicoTrat" CssClass="col-sm text-center" Text="COMENTARIOS MEDICO TRATANTE" runat="server" />

                    </div>
                </div>
                <!--      ------------------------------             -->
                <div class="col-sm ">
                    <div class="row form-group">
                        <textarea id="TxtComMedicoTrat" class="col-sm MargenDiv" runat="server" placeholder="Describa" />

                    </div>
                </div>
            </div>
        </div>

        <div class="form-group row MargenDiv" id="Botones1" visible="false" runat="server">
            <div class="col-sm text-center">
                <asp:Button ID="BtnGuardar" OnClick="BtnGuardar_Click" CssClass="btn btn-primary" Text="Guardar " runat="server" />
                &nbsp;&nbsp;
           <asp:Button ID="BtnCancelar1" OnClick="BtnCancelar1_Click" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" />

            </div>
        </div>

        <!--      ---------------BOTONES---------------             -->
        <div class="form-group row MargenDiv" id="Botones" runat="server">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" OnClick="BtnAceptar_Click" CssClass="btn btn-primary" Text="Guardar" runat="server" />
                &nbsp;&nbsp;
                <asp:Button ID="BtnCancelar" OnClick="BtnCancelar_Click" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" />
            </div>
        </div>
        <!--      ---------------LISTA DE ERRORES---------------             -->
        <div class="container alert-warning">
            <asp:ValidationSummary runat="server" HeaderText="Errores encontrados" DisplayMode="BulletList" ShowSummary="true" ShowMessageBox="true" />
        </div>
    </div>

    <br />
</asp:Content>
