using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Antecedentes
{
    public partial class AntecedenteQuirurgico : System.Web.UI.Page
    {

        private string Modo
        {
            get
            {
                string Parametro = Request.QueryString["Modo"];
                if (string.IsNullOrEmpty(Parametro) == true)
                {
                    return "";
                }
                return Parametro;
            }
        }
        private string FM { get { string parametro = Request.QueryString["FM"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private void Recuperar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA pk = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == pk.ID_PERSONA);
            LblFichaMedica.Text = "Nº Ficha Medica: " + FM;
            LblPersona.Text = "Cedula: " + p.PER_CEDULA;
            LblPerNombres.Text = "Nombre: " + p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.ANTECEDENTE_QUIRURGICO p = bd.ANTECEDENTE_QUIRURGICO.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                if (Modo != "E" && Modo != "C")
                {
                    Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx");
                }
                if (Modo == "C")
                {
                    Recuperar();
                }
                if (Modo == "E")
                {
                    Recuperar();
                    if (p != null)
                    {
                        CmbReflujo.SelectedValue = p.ANT_QUIREFLUJO;
                        CmbTiroideas.SelectedValue = p.ANT_QUITIROIDEAS;
                        CmbEstrenimiento.SelectedValue = p.ANT_QUIESTRENIMIENTO;
                        CmbDiarrea.SelectedValue = p.ANT_QUIDIARREA;
                        CmbNeumonia.SelectedValue = p.ANT_QUINEUMONIA;
                        CmbBronquitis.SelectedValue = p.ANT_QUIBRONQUIOLITIS;
                        CmbCrup.SelectedValue = p.ANT_QUICRUP;
                        CmbIVUrinarias.SelectedValue = p.ANT_QUIINFEVISURINARIAS;
                        CmbVaricela.SelectedValue = p.ANT_QUIVARICELA;
                        CmbEscarlatina.SelectedValue = p.ANT_QUIESCARLATINA;
                        CmbDCabeza.SelectedValue = p.ANT_QUIDOLORCABEZA;
                        CmbNerviosismo.SelectedValue = p.ANT_QUINERVIOCISMO;
                        CmbCombulsiones.SelectedValue = p.ANT_QUICONVULCIONES;
                        CmbTransfuciones.SelectedValue = p.ANT_QUITRANSFUCIONES;
                        TxtEspecifique.InnerText = p.ANT_QUIALERGIAS;
                        TxtEspecifique1.InnerText = p.ANT_QUIFRACTURAS;
                        TxtEspecifique2.InnerText = p.ANT_QUIACCIDENTES;
                        TxtEspecifique3.InnerText = p.ANT_QUICANCER;
                        TxtEspecifique4.InnerText = p.ANT_HOSPITALIZACION;
                        TxtEspecificar5.InnerText = p.CIRUGIAS;
                        RecuperarValidacion();
                    }
                    else
                    {
                        Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx");
                    }
                }
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.ANTECEDENTE_QUIRURGICO p = new Models.ANTECEDENTE_QUIRURGICO();
                if (Modo == "E")
                {
                    p = bd.ANTECEDENTE_QUIRURGICO.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (p == null) return;
                }

                p.ID_FICHA_MEDICA = int.Parse(FM);

                p.ANT_QUIREFLUJO = CmbReflujo.SelectedValue;
                p.ANT_QUITIROIDEAS = CmbTiroideas.SelectedValue;
                p.ANT_QUIESTRENIMIENTO = CmbEstrenimiento.SelectedValue;
                p.ANT_QUIDIARREA = CmbDiarrea.SelectedValue;
                p.ANT_QUINEUMONIA = CmbNeumonia.SelectedValue;
                p.ANT_QUIBRONQUIOLITIS = CmbBronquitis.SelectedValue;
                p.ANT_QUICRUP = CmbCrup.SelectedValue;
                p.ANT_QUIINFEVISURINARIAS = CmbIVUrinarias.SelectedValue;
                p.ANT_QUIVARICELA = CmbVaricela.SelectedValue;
                p.ANT_QUIESCARLATINA = CmbEscarlatina.SelectedValue;
                p.ANT_QUIDOLORCABEZA = CmbDCabeza.SelectedValue;
                p.ANT_QUINERVIOCISMO = CmbNerviosismo.SelectedValue;
                p.ANT_QUICONVULCIONES = CmbCombulsiones.SelectedValue;
                p.ANT_QUITRANSFUCIONES = CmbTransfuciones.SelectedValue;
                p.ANT_QUIALERGIAS = TxtEspecifique.InnerText;
                p.ANT_QUIFRACTURAS = TxtEspecifique1.InnerText;
                p.ANT_QUIACCIDENTES = TxtEspecifique2.InnerText;
                p.ANT_QUICANCER = TxtEspecifique3.InnerText;
                p.ANT_HOSPITALIZACION = TxtEspecifique4.InnerText;
                p.CIRUGIAS = TxtEspecificar5.InnerText;

                if (this.Modo == "C") bd.ANTECEDENTE_QUIRURGICO.Add(p);
                try
                {
                    bd.SaveChanges();
                    Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
                }
                catch (Exception ex)
                {
                    Existe();
                }
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
        }
        private bool ValidarCampos()
        {
            if (ChkReflujo.SelectedValue == "N" && CmbReflujo.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('REFLUJO Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkReflujo.SelectedValue == "S" && CmbReflujo.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('REFLUJO Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkETiroideas.SelectedValue == "N" && CmbTiroideas.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('TIROIDES Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkETiroideas.SelectedValue == "S" && CmbTiroideas.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('TIROIDES Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkEstrenimiento.SelectedValue == "N" && CmbEstrenimiento.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('ESTREÑIMIENTO Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkEstrenimiento.SelectedValue == "S" && CmbEstrenimiento.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('ESTREÑIMIENTO Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkDiarrea.SelectedValue == "N" && CmbDiarrea.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('DIARREA Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkDiarrea.SelectedValue == "S" && CmbDiarrea.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('DIARREA Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkNeumonia.SelectedValue == "N" && CmbNeumonia.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('NEUMONIA Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkNeumonia.SelectedValue == "S" && CmbNeumonia.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('NEUMONIA Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkBronquitis.SelectedValue == "N" && CmbBronquitis.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('BRONQUIOLITIS Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkBronquitis.SelectedValue == "S" && CmbBronquitis.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('BRONQUIOLITIS Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkCrup.SelectedValue == "N" && CmbCrup.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('CRUP Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkCrup.SelectedValue == "S" && CmbCrup.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('CRUP Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkIVUrinarias.SelectedValue == "N" && CmbIVUrinarias.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('INFECCIONES EN VIAS URINARIAS Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkIVUrinarias.SelectedValue == "S" && CmbIVUrinarias.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('INFECCIONES EN VIAS URINARIAS Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkVaricela.SelectedValue == "N" && CmbVaricela.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('VARICELA Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>"); ;
                return false;
            }
            else if (ChkVaricela.SelectedValue == "S" && CmbVaricela.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('VARICELA Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkEscarlatina.SelectedValue == "N" && CmbEscarlatina.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('ESCARLATINA Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkEscarlatina.SelectedValue == "S" && CmbEscarlatina.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('ESCARLATINA Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkDCabeza.SelectedValue == "N" && CmbDCabeza.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('DOLOR DE CABEZA  Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkDCabeza.SelectedValue == "S" && CmbDCabeza.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('DOLOR DE CABEZA  Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkNerviosismo.SelectedValue == "N" && CmbNerviosismo.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('NERVIOCISMO Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkNerviosismo.SelectedValue == "S" && CmbNerviosismo.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('NERVIOCISMO Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkCombulsiones.SelectedValue == "N" && CmbCombulsiones.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('CONVULCIONES Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkCombulsiones.SelectedValue == "S" && CmbCombulsiones.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('CONVULCIONES Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkTransfusiones.SelectedValue == "N" && CmbTransfuciones.SelectedIndex != 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('TRANSFUCIONES Al Seleccionar NO','NO Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            else if (ChkTransfusiones.SelectedValue == "S" && CmbTransfuciones.SelectedIndex == 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('TRANSFUCIONES Al Seleccionar SI','Debe Seleccionar el Numero de Veces','warning')</script>");
                return false;
            }
            if (ChkAlergia.SelectedValue == "N" && TxtEspecifique.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','EL Contenedor de ALERGIAS Debe Estar Vacío','warning')</script>");
                return false;
            }
            else if (ChkAlergia.SelectedValue == "S" && TxtEspecifique.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','EL Contenedor de ALERGIAS NO Debe Estar Vacío','warning')</script>");
                return false;
            }
            if (ChkFracturas.SelectedValue == "N" && TxtEspecifique1.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','EL Contenedor de FRACTURAS Debe Estar Vacío','warning')</script>");
                return false;
            }
            else if (ChkFracturas.SelectedValue == "S" && TxtEspecifique1.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','EL Contenedor de FRACTURAS NO Debe Estar Vacío','warning')</script>");
                return false;
            }
            if (ChkAccidente.SelectedValue == "N" && TxtEspecifique2.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','EL Contenedor de ACCIDENTES Debe Estar Vacío','warning')</script>");
                return false;
            }
            else if (ChkAccidente.SelectedValue == "S" && TxtEspecifique2.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','EL Contenedor de ACCIDENTES NO Debe Estar Vacío','warning')</script>");
                return false;
            }
            if (ChkCancer.SelectedValue == "N" && TxtEspecifique3.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','EL Contenedor de CANCER Debe Estar Vacío','warning')</script>");
                return false;
            }
            else if (ChkCancer.SelectedValue == "S" && TxtEspecifique3.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','EL Contenedor de CANCER NO Debe Estar Vacío','warning')</script>");
                return false;
            }
            if (ChkHospitalizacines.SelectedValue == "N" && TxtEspecifique4.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','EL Contenedor de HOSPITALIZACION Debe Estar Vacío','warning')</script>");
                return false;
            }
            else if (ChkHospitalizacines.SelectedValue == "S" && TxtEspecifique4.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','EL Contenedor de HOSPITALIZACION NO Debe Estar Vacío','warning')</script>");
                return false;
            }
            if (ChkCirugias.SelectedValue == "N" && TxtEspecificar5.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','EL Contenedor de CIRUGIAS Debe Estar Vacío','warning')</script>");
                return false;
            }
            else if (ChkCirugias.SelectedValue == "S" && TxtEspecificar5.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','EL Contenedor de CIRUGIAS NO Debe Estar Vacío','warning')</script>");
                return false;
            }



            return true;
        }
        protected void RecuperarValidacion()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ANTECEDENTE_QUIRURGICO p = bd.ANTECEDENTE_QUIRURGICO.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);

            if (p.ANT_QUIREFLUJO != "S")
            {
                ChkReflujo.SelectedValue = "S";
            }
            else if (p.ANT_QUIREFLUJO == "S")
            {
                ChkReflujo.SelectedValue = "N";
            }

            if (p.ANT_QUITIROIDEAS != "S")
            {
                ChkETiroideas.SelectedValue = "S";
            }
            else if (p.ANT_QUITIROIDEAS == "S")
            {
                ChkETiroideas.SelectedValue = "N";
            }

            if (p.ANT_QUIESTRENIMIENTO != "S")
            {
                ChkEstrenimiento.SelectedValue = "S";
            }
            else if (p.ANT_QUIESTRENIMIENTO == "S")
            {
                ChkEstrenimiento.SelectedValue = "N";
            }

            if (p.ANT_QUIDIARREA != "S")
            {
                ChkDiarrea.SelectedValue = "S";
            }
            else if (p.ANT_QUIDIARREA == "S")
            {
                ChkDiarrea.SelectedValue = "N";
            }
            if (p.ANT_QUINEUMONIA != "S")
            {
                ChkNeumonia.SelectedValue = "S";
            }
            else if (p.ANT_QUINEUMONIA == "S")
            {
                ChkNeumonia.SelectedValue = "N";
            }
            if (p.ANT_QUIBRONQUIOLITIS != "S")
            {
                ChkBronquitis.SelectedValue = "S";
            }
            else if (p.ANT_QUIBRONQUIOLITIS == "S")
            {
                ChkBronquitis.SelectedValue = "N";
            }
            if (p.ANT_QUICRUP != "S")
            {
                ChkCrup.SelectedValue = "S";
            }
            else if (p.ANT_QUICRUP == "S")
            {
                ChkCrup.SelectedValue = "N";
            }
            if (p.ANT_QUIINFEVISURINARIAS != "S")
            {
                ChkIVUrinarias.SelectedValue = "S";
            }
            else if (p.ANT_QUIINFEVISURINARIAS == "S")
            {
                ChkIVUrinarias.SelectedValue = "N";
            }
            if (p.ANT_QUIVARICELA != "S")
            {
                ChkVaricela.SelectedValue = "S";
            }
            else if (p.ANT_QUIVARICELA == "S")
            {
                ChkVaricela.SelectedValue = "N";
            }
            if (p.ANT_QUIESCARLATINA != "S")
            {
                ChkEscarlatina.SelectedValue = "S";
            }
            else if (p.ANT_QUIESCARLATINA == "S")
            {
                ChkEscarlatina.SelectedValue = "N";
            }
            if (p.ANT_QUIDOLORCABEZA != "S")
            {
                ChkDCabeza.SelectedValue = "S";
            }
            else if (p.ANT_QUIDOLORCABEZA == "S")
            {
                ChkDCabeza.SelectedValue = "N";
            }
            if (p.ANT_QUINERVIOCISMO != "S")
            {
                ChkNerviosismo.SelectedValue = "S";
            }
            else if (p.ANT_QUINERVIOCISMO == "S")
            {
                ChkNerviosismo.SelectedValue = "N";
            }
            if (p.ANT_QUICONVULCIONES != "S")
            {
                ChkCombulsiones.SelectedValue = "S";
            }
            else if (p.ANT_QUICONVULCIONES == "S")
            {
                ChkCombulsiones.SelectedValue = "N";
            }
            if (p.ANT_QUITRANSFUCIONES != "S")
            {
                ChkTransfusiones.SelectedValue = "S";
            }
            else if (p.ANT_QUITRANSFUCIONES == "S")
            {
                ChkTransfusiones.SelectedValue = "N";
            }
            if (p.ANT_QUIALERGIAS != "")
            {
                ChkAlergia.SelectedValue = "S";
            }
            else if (p.ANT_QUIALERGIAS == "")
            {
                ChkAlergia.SelectedValue = "N";
            }
            if (p.ANT_QUIFRACTURAS != "")
            {
                ChkFracturas.SelectedValue = "S";
            }
            else if (p.ANT_QUIFRACTURAS == "")
            {
                ChkFracturas.SelectedValue = "N";
            }
            if (p.ANT_QUIACCIDENTES != "")
            {
                ChkAccidente.SelectedValue = "S";
            }
            else if (p.ANT_QUIACCIDENTES == "")
            {
                ChkAccidente.SelectedValue = "N";
            }
            if (p.ANT_QUICANCER != "")
            {
                ChkCancer.SelectedValue = "S";
            }
            else if (p.ANT_QUICANCER == "")
            {
                ChkCancer.SelectedValue = "N";
            }
            if (p.ANT_HOSPITALIZACION != "")
            {
                ChkHospitalizacines.SelectedValue = "S";
            }
            else if (p.ANT_HOSPITALIZACION == "")
            {
                ChkHospitalizacines.SelectedValue = "N";
            }
            if (p.CIRUGIAS != "")
            {
                ChkCirugias.SelectedValue = "S";
            }
            else if (p.CIRUGIAS == "")
            {
                ChkCirugias.SelectedValue = "N";
            }


        }
        private void Existe()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya existe un registro con esta Especificacion')</script>");
        }
       
    }
}