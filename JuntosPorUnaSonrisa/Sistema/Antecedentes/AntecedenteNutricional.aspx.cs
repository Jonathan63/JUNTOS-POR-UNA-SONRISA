using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Antecedentes
{
    public partial class AntecedenteNutricional : System.Web.UI.Page
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
        private string M { get { string parametro = Request.QueryString["M"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
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
                Models.ANTECEDENTE_NUTRICIONAL v = bd.ANTECEDENTE_NUTRICIONAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
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
                        TxtPeso.Text = v.ANT_NUT_PESO;
                        TxtEstatura.Text = v.ANT_NUT_ESTATURA;
                        TxtIndiceM.Text = v.ANT_NUT_IMC;
                        TxtComidaSolida.Text = v.ANT_NUT_COMSOLIEDAD;
                        ChkTipoComida.SelectedValue = v.ANT_NUT_TIPO_COMIDA;
                        RbDieta.SelectedValue = v.ANT_NUT_DIETA_ESPECIAL;
                        TxtCual.Text = v.ANT_NUT_TIPO_DIETA;
                        TxtOtros.Text = v.ANT_NUT_COMIDA;
                    }
                }
            }
        }
        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.ANTECEDENTE_NUTRICIONAL p = new Models.ANTECEDENTE_NUTRICIONAL();

                if (Modo == "E")
                {
                    p = bd.ANTECEDENTE_NUTRICIONAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (p == null) return;
                }
                p.ID_FICHA_MEDICA = int.Parse(FM);
                p.ANT_NUT_PESO = TxtPeso.Text;
                p.ANT_NUT_ESTATURA = TxtEstatura.Text;
                p.ANT_NUT_IMC = TxtIndiceM.Text;
                p.ANT_NUT_COMSOLIEDAD = TxtComidaSolida.Text;
                p.ANT_NUT_TIPO_COMIDA = ChkTipoComida.SelectedValue;
                p.ANT_NUT_DIETA_ESPECIAL = RbDieta.SelectedValue;
                p.ANT_NUT_TIPO_DIETA = TxtCual.Text;
                p.ANT_NUT_COMIDA = TxtOtros.Text;
                if (this.Modo == "C") bd.ANTECEDENTE_NUTRICIONAL.Add(p);
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

            if (RbDieta.SelectedValue == "N" && TxtCual.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo ESPECIFICACION debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbDieta.SelectedValue == "S" && TxtCual.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo ESPECIFICACION no debe estar vacio','warning')</script>");
                return false;
            }

            if (ChkTipoComida.SelectedValue == "O" && TxtOtros.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar Otros','El Campo Otros NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkTipoComida.SelectedValue != "O" && TxtOtros.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('','El Campo Otros NO debe Contener texto','warning')</script>");
                return false;
            }
            return true;
        }

        protected void BtnFrecuencia_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.ANTECEDENTE_NUTRICIONAL p = new Models.ANTECEDENTE_NUTRICIONAL();

                if (Modo == "E")
                {
                    p = bd.ANTECEDENTE_NUTRICIONAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (p == null) return;
                }
                p.ID_FICHA_MEDICA = int.Parse(FM);
                p.ANT_NUT_PESO = TxtPeso.Text;
                p.ANT_NUT_ESTATURA = TxtEstatura.Text;
                p.ANT_NUT_IMC = TxtIndiceM.Text;
                p.ANT_NUT_COMSOLIEDAD = TxtComidaSolida.Text;
                p.ANT_NUT_TIPO_COMIDA = ChkTipoComida.SelectedValue;
                p.ANT_NUT_DIETA_ESPECIAL = RbDieta.SelectedValue;
                p.ANT_NUT_TIPO_DIETA = TxtCual.Text;
                p.ANT_NUT_COMIDA = TxtOtros.Text;
                

                if (this.Modo == "C") bd.ANTECEDENTE_NUTRICIONAL.Add(p);
                try
                {
                    bd.SaveChanges();

                    BaseDatosEntities bp = new BaseDatosEntities();
                    Models.FRECUENCIA v = bp.FRECUENCIA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (v != null)
                    {
                        Response.Redirect("~/Sistema/Antecedentes/Frecuencia.aspx?Modo=E&FM=" + FM + "&M=" + Modo);
                    }
                    if (v == null)
                    {
                        Response.Redirect("~/Sistema/Antecedentes/Frecuencia.aspx?Modo=C&FM=" + FM + "&M=" + Modo);
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
           
        }
    }
}