using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Ficha_Medica
{
    public partial class ValoracionFuncional : System.Web.UI.Page
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
                Models.VALORACION_FUNCIONAL p = bd.VALORACION_FUNCIONAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
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
                        
                        ChkValApoyoEspecial.SelectedValue = p.VAL_APOYO_ESPECIAL;
                        ChkAuditivo.SelectedValue = p.VAL_AUDITIVO;
                        ChkMotor.SelectedValue = p.VAL_MOTOR;
                        ChkVisual.SelectedValue = p.VAL_VISUAL;
                        ChkIdioma.SelectedValue = p.VAL_IDIOMA;
                        ChkOtro.SelectedValue = p.VAL_OTRO;
                        TxtEspecificacion.Text = p.VAL_ESPECIFICACION;

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
                Models.VALORACION_FUNCIONAL p = new Models.VALORACION_FUNCIONAL();
                if (Modo == "E")
                {
                    p = bd.VALORACION_FUNCIONAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (p == null) return;
                }
                p.ID_FICHA_MEDICA = int.Parse(FM);
                p.VAL_APOYO_ESPECIAL = ChkValApoyoEspecial.SelectedValue;
                p.VAL_AUDITIVO = ChkAuditivo.SelectedValue;
                p.VAL_MOTOR = ChkMotor.SelectedValue;
                p.VAL_VISUAL = ChkVisual.SelectedValue;
                p.VAL_IDIOMA = ChkIdioma.SelectedValue;
                p.VAL_OTRO = ChkOtro.SelectedValue;
                p.VAL_ESPECIFICACION = TxtEspecificacion.Text;

                if (this.Modo == "C") bd.VALORACION_FUNCIONAL.Add(p);
                try
                {
                    bd.SaveChanges();
                    Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
        }
        private bool ValidarCampos()
        {
           
            if (ChkOtro.SelectedValue == "N" && TxtEspecificacion.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo ESPECIFICACION debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkOtro.SelectedValue == "S" && TxtEspecificacion.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo ESPECIFICACION no debe estar vacio','warning')</script>");
                return false;
            }
           
            return true;
        }
    }
}
