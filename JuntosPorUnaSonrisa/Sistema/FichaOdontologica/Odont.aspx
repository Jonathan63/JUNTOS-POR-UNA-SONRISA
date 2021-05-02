<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Odont.aspx.cs" Inherits="JuntosPorUnaSonrisa.Sistema.FichaOdontologica.Odont" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PHContenido" runat="server">
    <div class="container-fluid">
        <h2 class="text-center">INGRESO DE DATOS DE  DIAGNOSTICO BUCAL</h2>
        <br />




        <div class="row MargenDiv form-inline">
            <!--      --------------ID Ficha Medica----------------             -->
            <div class="col-sm  btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblFichaMedica" CssClass="col-sm-3 text-center" Text="-----" runat="server" />
                    <asp:Label ID="LblPersona" CssClass="col-sm-3 text-center " Text="-----" runat="server" />
                    <asp:Label ID="LblPerNombres" CssClass="col-sm " Text="-----------" runat="server" />
                    <asp:Label ID="LblHistorial" CssClass="col-sm " Text="Historia Nº" runat="server" Visible="false"/>
                    <asp:Label ID="LblNHistorial" CssClass="col-sm " Text="" runat="server" Visible="false"/>
                    <asp:Button ID="BtnGenerar" Visible="false"  Text="Generar" runat="server"/>
                </div>
            </div>
        </div>
        <div class="row text-center MargenDiv form-inline">

            <asp:Image runat="server" CssClass="align-content-center" ImageUrl="~/Imagenes/Dientes.png" />

        </div>
        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblPaciente" CssClass="col-sm text-center" Text="Paciente:" runat="server" />
                    <asp:RadioButtonList ID="ChkPersona" CssClass="col-sm form-check" runat="server" CellPadding="15" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Niñ@" Value="N" />
                        <asp:ListItem Text="Adulto" Value="A" />
                    </asp:RadioButtonList>
                </div>
            </div>

            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblNDiente" CssClass="col-sm col-form-label  text-center" Text="Numero de diente:" runat="server" />
                    <asp:DropDownList ID="CmbDiente" CssClass="form-control" runat="server">
                        <Items>
                            <asp:ListItem Text="Seleccionar" Value="ZZ" />
                            <asp:ListItem Text="11" Value="11" />
                            <asp:ListItem Text="12" Value="12" />
                            <asp:ListItem Text="13" Value="13" />
                            <asp:ListItem Text="14" Value="14" />
                            <asp:ListItem Text="15" Value="15" />
                            <asp:ListItem Text="16" Value="16" />
                            <asp:ListItem Text="17" Value="17" />
                            <asp:ListItem Text="18" Value="18" />
                            <asp:ListItem Text="21" Value="21" />
                            <asp:ListItem Text="22" Value="22" />
                            <asp:ListItem Text="23" Value="23" />
                            <asp:ListItem Text="24" Value="24" />
                            <asp:ListItem Text="25" Value="25" />
                            <asp:ListItem Text="26" Value="26" />
                            <asp:ListItem Text="27" Value="27" />
                            <asp:ListItem Text="28" Value="28" />
                            <asp:ListItem Text="31" Value="31" />
                            <asp:ListItem Text="32" Value="32" />
                            <asp:ListItem Text="33" Value="33" />
                            <asp:ListItem Text="34" Value="34" />
                            <asp:ListItem Text="35" Value="35" />
                            <asp:ListItem Text="36" Value="36" />
                            <asp:ListItem Text="37" Value="37" />
                            <asp:ListItem Text="38" Value="38" />
                            <asp:ListItem Text="41" Value="41" />
                            <asp:ListItem Text="42" Value="42" />
                            <asp:ListItem Text="43" Value="43" />
                            <asp:ListItem Text="44" Value="44" />
                            <asp:ListItem Text="45" Value="45" />
                            <asp:ListItem Text="46" Value="46" />
                            <asp:ListItem Text="47" Value="47" />
                            <asp:ListItem Text="48" Value="48" />
                        </Items>
                    </asp:DropDownList>
                </div>
            </div>
        </div>

        <div class="row MargenDiv form-inline">
            <div class="col-sm btn-warning">
                <div class="row form-group">
                    <asp:Label ID="LblEnfermedad" CssClass="col-sm text-center" Text="Enfermedad:" runat="server" />

                </div>
                <div class="row form-group">
                    <asp:DropDownList ID="CmbEnfermedades" CssClass="col-sm MargenDiv" runat="server">
                        <Items>
                            <asp:ListItem Text="K000 - ANODONCIA" Value="K000" />
                            <asp:ListItem Text="K001 - DIENTES SUPERNUMERARIOS " Value="K001" />
                            <asp:ListItem Text="K002 - ANOMALIAS DEL TAMAÑO Y DE LA FORMA DEL DIENTE" Value="K002" />
                            <asp:ListItem Text="K003 - DIENTES MOTEADOS" Value="K003" />
                            <asp:ListItem Text="K004 - ALTERACIONES EN LA FORMACION DENTARIA" Value="K004" />
                            <asp:ListItem Text="K005 - ALTERACIONES HEREDITARIAS DE LA ESTRUCTURA DENTARIA, NO CLASIFICADAS EN OTRA PARTE" Value="K005" />
                            <asp:ListItem Text="K006 - ALTERACIONES EN LA ERUPCION DENTARIA" Value="K006" />
                            <asp:ListItem Text="K007 - SINDROME DE LA ERUPCION DENTARIA" Value="K007" />
                            <asp:ListItem Text="K008 - OTROS TRASTORNOS DEL DESARROLLO DE LOS DIENTES" Value="K008" />
                            <asp:ListItem Text="K009 - TRASTORNO DEL DESARROLLO DE LOS DIENTES, NO ESPECIFICADO" Value="K009" />
                            <asp:ListItem Text="K010 - DIENTES INCLUIDOS" Value="K010" />
                            <asp:ListItem Text="K011 - DIENTES IMPACTADOS " Value="K011" />
                            <asp:ListItem Text="K020 - CARIES LIMITADA AL ESMALTE " Value="K020" />
                            <asp:ListItem Text="K021 - CARIES DE LA DENTINA" Value="K021" />
                            <asp:ListItem Text="K022 -  CARIES DEL CEMENTO" Value="K022" />
                            <asp:ListItem Text="K023 - CARIES DENTARIA DETENIDA K024 ODONTOCLASIA" Value="K023" />
                            <asp:ListItem Text="K028 - OTRAS CARIES DENTALES" Value="K028" />
                            <asp:ListItem Text="K029 - CARIES DENTAL, NO ESPECIFICADA" Value="K029" />
                            <asp:ListItem Text="K030 - ATRICION EXCESIVA DE LOS DIENTES" Value="K030" />
                            <asp:ListItem Text="K031 - ABRASION DE LOS DIENTES" Value="K031" />
                            <asp:ListItem Text="K032 - EROSION DE LOS DIENTES" Value="K032" />
                            <asp:ListItem Text="K033 - REABSORCION PATOLOGICA DE LOS DIENTES" Value="K033" />
                            <asp:ListItem Text="K034 - HIPERCEMENTOSIS" Value="K034" />
                            <asp:ListItem Text="K035 - ANQUILOSIS DENTAL" Value="K035" />
                            <asp:ListItem Text="K036 - DEPOSITOS [ACRECIONES] EN LOS DIENTES " Value="K036" />
                            <asp:ListItem Text="K037 - CAMBIOS POSTERUPTIVOS DEL COLOR DE LOS TEJIDOS DENTALES DUROS" Value="K037" />
                            <asp:ListItem Text="K038 - OTRAS ENFERMEDADES ESPECIFICADAS DE LOS TEJIDOS DUROS DE LOS DIENTES" Value="K038" />
                            <asp:ListItem Text="K039 - ENFERMEDAD NO ESPECIFICADA DE LOS TEJIDOS DENTALES DUROS" Value="K039" />
                            <asp:ListItem Text="K040 - PULPITIS" Value="K040" />
                            <asp:ListItem Text="K041 - NECROSIS DE LA PULPA " Value="K041" />
                            <asp:ListItem Text="K042 - DEGENERACION DE LA PULPA" Value="K042" />
                            <asp:ListItem Text="K043 - FORMACION ANORMAL DE TEJIDO DURO EN LA PULPA" Value="K043" />
                            <asp:ListItem Text="K044 - PERIODONTITIS APICAL AGUDA ORIGINADA EN LA PULPA" Value="K044" />
                            <asp:ListItem Text="K045 - PERIODONTITIS APICAL CRONICA" Value="K045" />
                            <asp:ListItem Text="K046 - ABSCESO PERIAPICAL CON FISTULA" Value="K046" />
                            <asp:ListItem Text="K047 - ABSCESO PERIAPICAL SIN FISTULA" Value="K047" />
                            <asp:ListItem Text="K048 - QUISTE RADICULAR" Value="K048" />
                            <asp:ListItem Text="K049 - OTRAS ENFERMEDADES Y LAS NO ESPECIFICADAS DE LA PULPA Y DEL TEJIDO PERIAPICAL" Value="K049" />
                            <asp:ListItem Text="K050 - GINGIVITIS AGUDA" Value="K050" />
                            <asp:ListItem Text="K051 - GINGIVITIS CRONICA" Value="K051" />
                            <asp:ListItem Text="K052 - PERIODONTITIS AGUDA" Value="K052" />
                            <asp:ListItem Text="K053 - PERIODONTITIS CRONICA" Value="K053" />
                            <asp:ListItem Text="K054 - PERIODONTOSIS" Value="K054" />
                            <asp:ListItem Text="K055 - OTRAS ENFERMEDADES PERIODONTALES" Value="K055" />
                            <asp:ListItem Text="K056 - ENFERMEDAD DE PERIODONTO, NO ESPECIFICADA" Value="K056" />
                            <asp:ListItem Text="K060 - RETRACCION GINGIVAL" Value="K060" />
                            <asp:ListItem Text="K061 - HIPERPLASIA GINGIVAL" Value="K061" />
                            <asp:ListItem Text="K062 - LESIONES DE LA ENCIA Y DE LA ZONA EDENTULA ASOCIADAS CON TRAUMATISMO" Value="K062" />
                            <asp:ListItem Text="K068 - OTROS TRASTORNOS ESPECIFICADOS DE LA ENCIA Y DE LA ZONA EDENTULA" Value="K068" />
                            <asp:ListItem Text="K069 - TRASTORNO NO ESPECIFICADO DE LA ENCIA Y DE LA ZONA EDENTULA" Value="K069" />
                            <asp:ListItem Text="K070 - ANOMALIAS EVIDENTES DEL TAMAÑO DE LOS MAXILARES" Value="K070" />
                            <asp:ListItem Text="K071 - ANOMALIAS DE LA RELACION MAXILOBASILAR" Value="K071" />
                            <asp:ListItem Text="K072 - ANOMALIAS DE LA RELACION ENTRE LOS ARCOS DENTARIOS" Value="K072" />
                            <asp:ListItem Text="K073 - ANOMALIAS DE LA POSICION DEL DIENTE" Value="K073" />
                            <asp:ListItem Text="K074 - MALOCLUSION DE TIPO NO ESPECIFICADO" Value="K074" />
                            <asp:ListItem Text="K075 - ANOMALIAS DENTOFACIALES FUNCIONALES" Value="K075" />
                            <asp:ListItem Text="K076 - TRASTORNOS DE LA ARTICULACION TEMPOROMAXILAR" Value="K076" />
                            <asp:ListItem Text="K078 - OTRAS ANOMALIAS DENTOFACIALES" Value="K078" />
                            <asp:ListItem Text="K079 - ANOMALIA DENTOFACIAL, NO ESPECIFICADA" Value="K079" />
                            <asp:ListItem Text="K080 - EXFOLIACION DE LOS DIENTES DEBIDA A CAUSAS SISTEMICAS" Value="K080" />
                            <asp:ListItem Text="K081 - PERDIDA DE DIENTES DEBIDA A ACCIDENTE, EXTRACCION O ENFERMEDAD PERIODONTAL LOCAL" Value="K081" />
                            <asp:ListItem Text="K082 - ATROFIA DE REBORDE ALVEOLAR DESDENTADO" Value="K082" />
                            <asp:ListItem Text="K083 - RAIZ DENTAL RETENIDA" Value="K083" />
                            <asp:ListItem Text="K088 - OTRAS AFECCIONES ESPECIFICADAS DE LOS DIENTES Y DE SUS ESTRUCTURAS DE SOSTEN " Value="K088" />
                            <asp:ListItem Text="K089 - TRASTORNO DE LOS DIENTES Y DE SUS ESTRUCTURAS DE SOSTEN, NO ESPECIFICADO " Value="K089" />
                            <asp:ListItem Text="K090 - QUISTES ORIGINADOS POR EL DESARROLLO DE LOS DIENTES" Value="K090" />
                            <asp:ListItem Text="K091 - QUISTES DE LAS FISURAS (NO ODONTOGENICOS) " Value="K091" />
                            <asp:ListItem Text="K092 - OTROS QUISTES DE LOS MAXILARES" Value="K092" />
                            <asp:ListItem Text="K098 - OTROS QUISTES DE LA REGION BUCAL, NO CLASIFICADOS EN OTRA PARTE" Value="K098" />
                            <asp:ListItem Text="K099 - QUISTE DE LA REGION BUCAL, SIN OTRA ESPECIFICACION" Value="K099" />
                            <asp:ListItem Text="K100 - TRASTORNOS DEL DESARROLLO DE LOS MAXILARES" Value="K100" />
                            <asp:ListItem Text="K101 - GRANULOMA CENTRAL DE CELULAS GIGANTES" Value="K101" />
                            <asp:ListItem Text="K102 - AFECCIONES INFLAMATORIAS DE LOS MAXILARES " Value="K102" />
                            <asp:ListItem Text="K103 - ALVEOLITIS DEL MAXILAR" Value="K103" />
                            <asp:ListItem Text="K108 - OTRAS ENFERMEDADES ESPECIFICADAS DE LOS MAXILARES" Value="K108 " />
                            <asp:ListItem Text="K109 - ENFERMEDAD DE LOS MAXILARES, NO ESPECIFICADA" Value="K109" />
                            <asp:ListItem Text="K110 - ATROFIA DE GLANDULA SALIVAL" Value="K110" />
                            <asp:ListItem Text="K111 - HIPERTROFIA DE GLANDULA SALIVAL" Value="K111" />
                            <asp:ListItem Text="K112 - SIALADENITIS" Value="K112" />
                            <asp:ListItem Text="K113 - ABSCESO DE GLANDULA SALIVAL" Value="K113" />
                            <asp:ListItem Text="K114 - FISTULA DE GLANDULA SALIVAL" Value="K114" />
                            <asp:ListItem Text="K115 - SIALOLITIASIS" Value="K115" />
                            <asp:ListItem Text="K116 - MUCOCELE DE GLANDULA SALIVAL" Value="K116" />
                            <asp:ListItem Text="K117 - ALTERACIONES DE LA SECRECION SALIVAL" Value="K117" />
                            <asp:ListItem Text="K118 - OTRAS ENFERMEDADES DE LAS GLANDULAS SALIVALES" Value="K118" />
                            <asp:ListItem Text="K119 - ENFERMEDAD DE GLANDULA SALIVAL. NO ESPECIFICADA" Value="K119" />
                            <asp:ListItem Text="K120 - ESTOMATITIS AFTOSA RECURRENTE" Value="K120" />
                            <asp:ListItem Text="K121 - OTRAS FORMAS DE ESTOMATITIS" Value="K121" />
                            <asp:ListItem Text="K122 - CELULITIS Y ABSCESO DE BOCA" Value="K122" />
                            <asp:ListItem Text="K130 - ENFERMEDADES DE LOS LABIOS" Value="K130" />
                            <asp:ListItem Text="K131 - MORDEDURA DEL LABIO Y DE LA MEJILLA" Value="K131" />
                            <asp:ListItem Text="K132 - LEUCOPLASIA Y OTRAS ALTERACIONES DEL EPITELIO BUCAL, INCLUYENDO LA LENGUA " Value="K132" />
                            <asp:ListItem Text="K133 - LEUCOPLASIA PILOSA" Value="K133" />
                            <asp:ListItem Text="K134 - GRANULOMA Y LESIONES SEMEJANTES DE LA MUCOSA BUCAL" Value="K134" />
                            <asp:ListItem Text="K135 - FIBROSIS DE LA SUBMUCOSA BUCAL" Value="K135" />
                            <asp:ListItem Text="K136 - HIPERPLASIA IRRITATIVA DE LA MUCOSA BUCAL" Value="K136" />
                            <asp:ListItem Text="K137 - OTRAS LESIONES Y LAS NO ESPECIFICADAS DE LA MUCOSA BUCAL" Value="K137" />
                            <asp:ListItem Text="K140 - GLOSITIS" Value="K140" />
                            <asp:ListItem Text="K141 - LENGUA GEOGRAFICA" Value="K141" />
                            <asp:ListItem Text="K142 - GLOSITIS ROMBOIDEA MEDIANA" Value="K142" />
                            <asp:ListItem Text="K143 - HIPERTROFIA DE LAS PAPILAS LINGUALES" Value="K143" />
                            <asp:ListItem Text="K144 - ATROFIA DE LAS PAPILAS LINGUALES" Value="K144 " />
                            <asp:ListItem Text="K145 - LENGUA PLEGADA" Value="K145 LENGUA PLEGADA" />
                            <asp:ListItem Text="K146 - GLOSODINIA" Value="K146" />
                            <asp:ListItem Text="K148 - OTRAS ENFERMEDADES DE LA LENGUA" Value="K148" />
                            <asp:ListItem Text="K149 - ENFERMEDAD DE LA LENGUA, NO ESPECIFICADA" Value="K149 " />
                            <asp:ListItem Text="L032 - CELULITIS DE LA CARA" Value="L032" />
                            <asp:ListItem Text="O293 - REACCION TOXICA A LA ANESTESIA LOCAL ADMINISTRADA DURANTE EL EMBARAZO " Value="O293" />
                            <asp:ListItem Text="Q351 - FISURA DEL PALADAR DURO" Value="Q351" />
                            <asp:ListItem Text="Q353 - FISURA DEL PALADAR BLANDO" Value="Q353" />
                            <asp:ListItem Text="Q355 - FISURA DEL PALADAR DURO Y DEL PALADAR BLANDO" Value="Q355" />
                            <asp:ListItem Text="Q356 - FISURA DEL PALADAR, LINEA MEDIA " Value="Q356" />
                            <asp:ListItem Text="Q357 - FISURA DE LA UVULA" Value="Q357" />
                            <asp:ListItem Text="Q359 - FISURA DEL PALADAR, SIN OTRA ESPECIFICACION" Value="Q359 " />
                            <asp:ListItem Text="Q360 - LABIO LEPORINO, BILATERAL" Value="Q360" />
                            <asp:ListItem Text="Q361 - LABIO LEPORINO, LINEA MEDIA" Value="Q361 " />
                            <asp:ListItem Text="Q369 - LABIO LEPORINO, UNILATERAL" Value="Q369" />
                            <asp:ListItem Text="Q370 - FISURA DEL PALADAR DURO CON LABIO LEPORINO BILATERAL" Value="bQ370" />
                            <asp:ListItem Text="Q371 - FISURA DEL PALADAR DURO CON LABIO LEPORINO, UNILATERAL" Value="Q371 " />
                            <asp:ListItem Text="Q372 - FISURA DEL PALADAR BLANDO CON LABIO LEPORINO BILATERAL" Value="Q372" />
                            <asp:ListItem Text="Q373 - FISURA DEL PALADAR BLANDO CON LABIO LEPORINO UNILATERAL" Value="Q373" />
                            <asp:ListItem Text="Q374 - FISURA DEL PALADAR DURO Y DEL PALADAR BLANDO CON LABIO LEPORINO BILATERAL " Value="Q374 " />
                            <asp:ListItem Text="Q375 - FISURA DEL PALADAR DURO Y DEL PALADAR BLANDO CON LABIO LEPORINO UNILATERAL" Value="Q375 " />
                            <asp:ListItem Text="Q378 - FISURA DEL PALADAR CON LABIO LEPORINO BILATERAL, SIN OTRA ESPECIFICACION" Value="Q378 " />
                            <asp:ListItem Text="Q379 - FISURA DEL PALADAR CON LABIO LEPORINO UNILATERAL, SIN OTRA ESPECIFICACION " Value="Q379 " />
                            <asp:ListItem Text="Q380 - MALFORMACIONES CONGENITAS DE LOS LABIOS, NO CLASIFICADAS EN OTRA PARTE " Value="Q380" />
                            <asp:ListItem Text="Q381 - ANQUILOGLOSIA" Value="Q381" />
                            <asp:ListItem Text="Q382 - MACROGLOSIA" Value="Q382" />
                            <asp:ListItem Text="Q383 - OTRAS MALFORMACIONES CONGENITAS DE LA LENGUA" Value="Q383" />
                            <asp:ListItem Text="Q384 - MALFORMACIONES CONGENITAS DE LAS GLANDULAS Y DE LOS CONDUCTOS SALIVALES" Value="Q384 " />
                            <asp:ListItem Text="Q385 - MALFORMACIONES CONGENITAS DEL PALADAR, NO CLASIFICADAS EN OTRA PARTE" Value="Q385 " />
                            <asp:ListItem Text="Q386 - OTRAS MALFORMACIONES CONGENITAS DE LA BOCA" Value="Q386" />
                            <asp:ListItem Text="Q754 - DISOSTOSIS MAXILOFACIAL" Value="Q754" />
                            <asp:ListItem Text="Q758 - OTRAS MALFORMACIONES CONGENITAS ESPECIFICADAS DE LOS HUESOS DEL CRANEO Y DE LA CARA" Value="Q758" />
                            <asp:ListItem Text="Q759 - MALFORMACION CONGENITA NO ESPECIFICADA DE LOS HUESOS DEL CRANEO Y DE LA CARA" Value="Q759" />
                            <asp:ListItem Text="R040 - EPISTAXIS" Value="R040 " />
                            <asp:ListItem Text="S014 - HERIDA DE LA MEJILLA Y DE LA REGION TEMPOROMANDIBULAR" Value="S014 " />
                            <asp:ListItem Text="S015 - HERIDA DEL LABIO Y DE LA CAVIDAD BUCAL" Value="S015" />
                            <asp:ListItem Text="S023 - FRACTURA DEL SUELO DE LA ORBITA" Value="S023" />
                            <asp:ListItem Text="S024 - FRACTURA DEL MALAR Y DEL HUESO MAXILAR SUPERIOR " Value="S024" />
                            <asp:ListItem Text="S025 - FRACTURA DE LOS DIENTES" Value="S025" />
                            <asp:ListItem Text="S026 - FRACTURA DEL MAXILAR INFERIOR" Value="S026" />
                            <asp:ListItem Text="S027 - FRACTURAS MULTIPLES QUE COMPROMETEN EL CRANEO Y LOS HUESOS DE LA CARA" Value="S027 " />
                            <asp:ListItem Text="S028 - FRACTURA DE OTROS HUESOS DEL CRANEO Y DE LA CARA" Value="S028" />
                            <asp:ListItem Text="S030 - LUXACION DEL MAXILAR" Value="S030" />
                            <asp:ListItem Text="B378 - CANDIDIASIS DE OTROS SITIOS" Value="B378 " />
                            <asp:ListItem Text="S032 - LUXACION DE DIENTE" Value="S032" />
                        </Items>
                    </asp:DropDownList>
                </div>
                <div class="row form-group">
                    <textarea id="TxtEnfermedad" class="col-sm MargenDiv" runat="server" placeholder="Describa" />
                </div>
            </div>
        </div>

        <div class="form-group row">
            <div class="col-sm text-center">
                <asp:Button ID="BtnAceptar" CssClass="btn btn-primary" Text="Aceptar" runat="server" OnClick="BtnAceptar_Click" />
                &nbsp;&nbsp;
                <asp:Button ID="BtnCancelar" CssClass="btn btn-danger" Text="Cancelar" runat="server" CausesValidation="false" OnClick="BtnCancelar_Click" />
            </div>
        </div>
        <br />

    </div>
</asp:Content>
