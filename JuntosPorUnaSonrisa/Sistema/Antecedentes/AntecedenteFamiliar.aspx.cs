using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Antecedentes
{
    public partial class AntecedenteFamiliar : System.Web.UI.Page
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


        protected void Page_Load(object sender, EventArgs e)
        {


            if (Page.IsPostBack == false)
            {

                if (Modo != "C" && Modo != "E")
                {
                    Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx");
                }
                else if (Modo == "C")
                {
                    Recuperar();


                }
                if (Modo == "E")
                {
                    BaseDatosEntities bd = new BaseDatosEntities();
                    Models.ANTECEDENTE_FAMILIAR p = bd.ANTECEDENTE_FAMILIAR.FirstOrDefault(x => x.ANT_NOMBRE.ToString() == A);

                    Recuperar();

                    if (p != null)
                    {


                        CmbParentesco.SelectedValue = p.ANT_FAMILIAR;
                        TxtAntecedentesN.Text = p.ANT_NOMBRE;
                        ChkSano.SelectedValue = p.ANT_SANO;
                        TxtAntEnfermedad.Text = p.ANT_ENFERMEDAD;
                        ChkFallecido.SelectedValue = p.ANT_FALLECIDO;
                        TxtAntCausa.Text = p.ANT_CAUSA;
                        ChkFuma.SelectedValue = p.ANT_FUMA;
                        ChkToma.SelectedValue = p.ANT_TOMA;
                        ChkDrogas.SelectedValue = p.ANT_DROGA;
                    }
                    else
                    {
                        Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx");
                    }
                }
            }

        }
        protected void Recuperar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA pk = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
            Models.ANTECEDENTE_FAMILIAR v = bd.ANTECEDENTE_FAMILIAR.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == pk.ID_PERSONA);

            Per.Text = p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO;
            TXTNombres.Text = p.PER_NOMBRES;
        }
        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.ANTECEDENTE_FAMILIAR p = new Models.ANTECEDENTE_FAMILIAR();


                if (Modo == "E")
                {
                    p = bd.ANTECEDENTE_FAMILIAR.FirstOrDefault(x => x.ANT_NOMBRE.ToString() == A);
                    if (p == null) return;
                }

                if (Modo == "C")
                {
                    p.ID_FICHA_MEDICA = int.Parse(FM);

                }
                p.ANT_FAMILIAR = CmbParentesco.SelectedValue;
                p.ANT_NOMBRE = TxtAntecedentesN.Text;
                p.ANT_SANO = ChkSano.SelectedValue;
                p.ANT_ENFERMEDAD = TxtAntEnfermedad.Text;
                p.ANT_FALLECIDO = ChkFallecido.SelectedValue;
                p.ANT_CAUSA = TxtAntCausa.Text;
                p.ANT_FUMA = ChkFuma.SelectedValue;
                p.ANT_TOMA = ChkToma.SelectedValue;
                p.ANT_DROGA = ChkDrogas.SelectedValue;


                if (this.Modo == "C") bd.ANTECEDENTE_FAMILIAR.Add(p);
                try
                {
                    bd.SaveChanges();
                    if (R == "1")
                    {
                        Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx?FM=" + FM + "&R=" + R);
                    }
                    else
                    {

                        Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx");
                    }
                }
                catch (Exception ex)
                {
                    Existe();
                }
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (R == "1")
            {
                Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx?FM=" + FM + "&R=" + R);
            }
            else
            {

                Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx?");
            }

        }

        private string A { get { string parametro = Request.QueryString["A"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }

        private string FM { get { string parametro = Request.QueryString["FM"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private bool ValidarCampos()
        {
            if (TxtAntecedentesN.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El Nombre del Pariente es Requerido')</script>");

                return false;
            }
            if (ChkSano.SelectedValue == "S" && TxtAntEnfermedad.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo ENFERMEDAD debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkSano.SelectedValue == "N" && TxtAntEnfermedad.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo ENFERMEDAD no debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkFallecido.SelectedValue == "N" && TxtAntCausa.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo CAUSA debe estar vacio','warning')</script>");
                return false;
            } else if (ChkFallecido.SelectedValue == "S" && TxtAntCausa.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo CAUSA no debe estar vacio','warning')</script>");
                return false;
            }
            return true;
        }
        private void Existe()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya existe un registro con este Nombre de ser necesario ingrese los nombres completos')</script>");
            TxtAntecedentesN.Text = "";


        }

    }
}