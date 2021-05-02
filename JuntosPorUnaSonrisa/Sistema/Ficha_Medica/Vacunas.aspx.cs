using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Ficha_Medica
{
    public partial class Vacunas : System.Web.UI.Page
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
                Models.VACUNA v = bd.VACUNA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
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
                        RbTuberculosis.SelectedValue = v.VAC_TUBERCULOSIS;
                        RbVaricela.SelectedValue = v.VAC_VARICELA;
                        RbNeumococo.SelectedValue = v.VAC_NEUMOCOCOS;
                        RbHepatitis.SelectedValue = v.VAC_HEPATITIS;
                        RbInfluenza.SelectedValue = v.VAC_INFLUENZA;
                        RbRotavirus.SelectedValue = v.VAC_ROTAVIRUS;

                        if (v.VAC_POLIOCUANTAS != "")
                        {
                            RbPolio.SelectedValue = "S";
                            TxtPolioCuantas.Text = v.VAC_POLIOCUANTAS;
                        }

                        if (v.VAC_PENTAVALENTECUANTAS != "")
                        {
                            RbPentavelente.SelectedValue = "S";
                            TxtPentavelenteCuantas.Text = v.VAC_PENTAVALENTECUANTAS;
                        }

                        if (v.VAC_TRIPLEVIRALCUANTAS != "")
                        {
                            RbTripeViral.SelectedValue = "S";
                            TxtTripeViralCuantas.Text = v.VAC_TRIPLEVIRALCUANTAS;
                        }

                        if (v.VAC_OTRASESPECIFIQUE != "")
                        {
                            RbOtras.SelectedValue = "S";
                            TxtEspecifique.Text = v.VAC_OTRASESPECIFIQUE;
                        }
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
                Models.VACUNA p = new Models.VACUNA();

                if (Modo == "E")
                {
                    p = bd.VACUNA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (p == null) return;
                }
                p.ID_FICHA_MEDICA = int.Parse(FM);
                p.VAC_TUBERCULOSIS = RbTuberculosis.SelectedValue;
                p.VAC_VARICELA = RbVaricela.SelectedValue;
                p.VAC_NEUMOCOCOS = RbNeumococo.SelectedValue;
                p.VAC_HEPATITIS = RbHepatitis.SelectedValue;
                p.VAC_INFLUENZA = RbInfluenza.SelectedValue;
                p.VAC_ROTAVIRUS = RbRotavirus.SelectedValue;
                p.VAC_POLIOCUANTAS = TxtPolioCuantas.Text;
                p.VAC_PENTAVALENTECUANTAS = TxtPentavelenteCuantas.Text;
                p.VAC_TRIPLEVIRALCUANTAS = TxtTripeViralCuantas.Text;
                p.VAC_OTRASESPECIFIQUE = TxtEspecifique.Text;

                if (this.Modo == "C") bd.VACUNA.Add(p);
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

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
        }
        private bool ValidarCampos()
        {
            if (RbOtras.SelectedValue == "N" && TxtEspecifique.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo ESPECIFICACION debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbOtras.SelectedValue == "S" && TxtEspecifique.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo ESPECIFICACION no debe estar vacio','warning')</script>");
                return false;
            }

            if (RbPentavelente.SelectedValue == "N" && TxtPentavelenteCuantas.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo PENTAVELENTE debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbPentavelente.SelectedValue == "S" && TxtPentavelenteCuantas.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo PENTAVELENTE no debe estar vacio','warning')</script>");
                return false;
            }

            if (RbPolio.SelectedValue == "N" && TxtPolioCuantas.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo POLIO debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbPolio.SelectedValue == "S" && TxtPolioCuantas.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo POLIO no debe estar vacio','warning')</script>");
                return false;
            }

            if (RbTripeViral.SelectedValue == "N" && TxtTripeViralCuantas.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo TRIPLE VIRAL debe estar vacio','warning')</script>");
                return false;
            }
            else if (RbTripeViral.SelectedValue == "S" && TxtTripeViralCuantas.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo TRIPLE VIRAL no debe estar vacio','warning')</script>");
                return false;
            }
            return true;
        }
        private void Existe()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya existe un registro con esta Especificacion')</script>");
        }
    }
}