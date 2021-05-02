using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Ficha_Medica
{
    public partial class ExploracionFisica : System.Web.UI.Page
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
                Models.EXPLORACION_FISICA v = bd.EXPLORACION_FISICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
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
                    if (v != null)
                    {
                        TxtTA.Text = v.EXPFIS_TA;
                        TxtTemperatura.Text = v.EXPFIS_TEMPERATURA;
                        TxtFreCardiaca.Text = v.EXPFIS_FRECUENCARD;
                        TxtPulso.Text = v.EXPFIS_PULSO;
                        TxtFreRespiratoria.Text = v.EXPFIS_RESPIRATORIA;

                        LblObsCabeza.InnerText = v.EXPFIS_CABEZA;
                        LblObsCuello.InnerText = v.EXPFIS_CUELLO;
                        LblObsTorax.InnerText = v.EXPFIS_TORAX;
                        LblObsAbdomen.InnerText = v.EXPFIS_ABDOMEN;
                        LblObsGenitales.InnerText = v.EXPFIS_GENITALES;
                        LblObsNeurologica.InnerText = v.EXPFIS_NEUROLOGICO;
                        LblObsExamenRectal.InnerText = v.EXPFIS_EXAMENRECTAL;
                        LblObsPelvico.InnerText = v.EXPFIS_PELVICO;
                        LblobsExtremidades.InnerText = v.EXPFIS_EXTREMIDADES;
                        RecuperarValidacion();
                    }
                }
            }
        }


        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.EXPLORACION_FISICA p = new Models.EXPLORACION_FISICA();

                if (Modo == "E")
                {
                    p = bd.EXPLORACION_FISICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (p == null) return;
                }
                if (Modo == "C") p.ID_FICHA_MEDICA = int.Parse(FM);
                p.EXPFIS_TA = TxtTA.Text;
                p.EXPFIS_TEMPERATURA = TxtTemperatura.Text;
                p.EXPFIS_FRECUENCARD = TxtFreCardiaca.Text;
                p.EXPFIS_PULSO = TxtPulso.Text;
                p.EXPFIS_RESPIRATORIA = TxtFreRespiratoria.Text;
                p.EXPFIS_CABEZA = LblObsCabeza.InnerText;
                p.EXPFIS_CUELLO = LblObsCuello.InnerText;
                p.EXPFIS_TORAX = LblObsCuello.InnerText;
                p.EXPFIS_ABDOMEN = LblObsAbdomen.InnerText;
                p.EXPFIS_GENITALES = LblObsGenitales.InnerText;
                p.EXPFIS_NEUROLOGICO = LblObsNeurologica.InnerText;
                p.EXPFIS_EXAMENRECTAL = LblObsExamenRectal.InnerText;
                p.EXPFIS_PELVICO = LblObsPelvico.InnerText;
                p.EXPFIS_EXTREMIDADES = LblobsExtremidades.InnerText;



                if (this.Modo == "C") bd.EXPLORACION_FISICA.Add(p);

                try
                {
                    bd.SaveChanges();
                    Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
                }
                catch (Exception ex)
                {
                    Response.Write("Ya Existe un registro con este numero de identificacion");
                }

            }
        }
        private bool ValidarCampos()
        {
            if (RbCabeza.SelectedValue == "N" && LblObsCabeza.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA DE CABEZA debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbCabeza.SelectedValue == "S" && LblObsCabeza.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA DE CABEZA no debe estar vacio','warning')</script>");
                return false;
            }
            if (RbCuello.SelectedValue == "N" && LblObsCuello.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA DE CUELLO debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbCuello.SelectedValue == "S" && LblObsCuello.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA DE CUELLO no debe estar vacio','warning')</script>");
                return false;
            }
            if (RbExpTorax.SelectedValue == "N" && LblObsTorax.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA DE TORAX debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbExpTorax.SelectedValue == "S" && LblObsTorax.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA DE TORAX no debe estar vacio','warning')</script>");
                return false;
            }
            if (RbAbdomen.SelectedValue == "N" && LblObsAbdomen.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA DE ABDOMEN debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbAbdomen.SelectedValue == "S" && LblObsAbdomen.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA DE ABDOMEN no debe estar vacio','warning')</script>");
                return false;
            }
            if (RbGenitales.SelectedValue == "N" && LblObsGenitales.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA DE GENITALES debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbGenitales.SelectedValue == "S" && LblObsGenitales.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA DE GENITALES no debe estar vacio','warning')</script>");
                return false;
            }
            if (RbExtremidades.SelectedValue == "N" && LblobsExtremidades.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA DE EXTREMIDADES debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbExtremidades.SelectedValue == "S" && LblobsExtremidades.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA DE EXTREMIDADES no debe estar vacio','warning')</script>");
                return false;
            }
            if (RbNeurologica.SelectedValue == "N" && LblObsNeurologica.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA NEUROLOGICA debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbNeurologica.SelectedValue == "S" && LblObsNeurologica.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA NEUROLOGICA no debe estar vacio','warning')</script>");
                return false;
            }
            if (RbExamenRectal.SelectedValue == "N" && LblObsExamenRectal.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA RECTAL debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbExamenRectal.SelectedValue == "S" && LblObsExamenRectal.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA RECTAL no debe estar vacio','warning')</script>");
                return false;
            }
            if (RbPelvico.SelectedValue == "N" && LblObsPelvico.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El campo EXPLORACION FISICA PELVICA debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbPelvico.SelectedValue == "S" && LblObsPelvico.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El campo EXPLORACION FISICA PELVICA no debe estar vacio','warning')</script>");
                return false;
            }
            return true;
        }
        protected void RecuperarValidacion()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.EXPLORACION_FISICA p = bd.EXPLORACION_FISICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);

            if (p.EXPFIS_CABEZA != "")
            {
                RbCabeza.SelectedValue = "S";
            }
            else if (p.EXPFIS_CABEZA == "")
            {
                RbCabeza.SelectedValue = "N";
            }
            if (p.EXPFIS_CUELLO != "")
            {
                RbCuello.SelectedValue = "S";
            }
            else if (p.EXPFIS_CUELLO == "")
            {
                RbCuello.SelectedValue = "N";
            }
            if (p.EXPFIS_TORAX != "")
            {
                RbExpTorax.SelectedValue = "S";
            }
            else if (p.EXPFIS_TORAX == "")
            {
                RbExpTorax.SelectedValue = "N";
            }
            if (p.EXPFIS_ABDOMEN != "")
            {
                RbAbdomen.SelectedValue = "S";
            }
            else if (p.EXPFIS_ABDOMEN == "")
            {
                RbAbdomen.SelectedValue = "N";
            }
            if (p.EXPFIS_GENITALES != "")
            {
                RbGenitales.SelectedValue = "S";
            }
            else if (p.EXPFIS_GENITALES == "")
            {
                RbGenitales.SelectedValue = "N";
            }
            if (p.EXPFIS_EXTREMIDADES != "")
            {
                RbExtremidades.SelectedValue = "S";
            }
            else if (p.EXPFIS_EXTREMIDADES == "")
            {
                RbExtremidades.SelectedValue = "N";
            }
            if (p.EXPFIS_NEUROLOGICO != "")
            {
                RbNeurologica.SelectedValue = "S";
            }
            else if (p.EXPFIS_NEUROLOGICO == "")
            {
                RbNeurologica.SelectedValue = "N";
            }
            if (p.EXPFIS_EXAMENRECTAL != "")
            {
                RbExamenRectal.SelectedValue = "S";
            }
            else if (p.EXPFIS_EXAMENRECTAL == "")
            {
                RbExamenRectal.SelectedValue = "N";
            }
            if (p.EXPFIS_PELVICO != "")
            {
                RbPelvico.SelectedValue = "S";
            }
            else if (p.EXPFIS_PELVICO == "")
            {
                RbPelvico.SelectedValue = "N";
            }
        }
    }
}