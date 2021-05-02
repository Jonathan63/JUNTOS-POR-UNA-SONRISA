using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class Diagnostico : System.Web.UI.Page
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

        private string FO { get { string parametro = Request.QueryString["FO"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private void Recuperar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_ODONTOLOGICA pk = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == pk.ID_PERSONA);
            LblFichaMedica.Text = "Nº Ficha Odontologica: " + FO;
            LblPersona.Text = "Cedula: " + p.PER_CEDULA;
            LblPerNombres.Text = "Nombre: " + p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.DIAGNOSTICO_BUCAL p = bd.DIAGNOSTICO_BUCAL.FirstOrDefault(x => x.ID_DIAGNOSTICO.ToString() == R && x.ID_ODONTO.ToString() == FO);
                if (Modo != "E" && Modo != "C")
                {
                    Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx");
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
                        TxtIDDiagnostico.Text = p.ID_DIAGNOSTICO.ToString();
                        LblDescrip.InnerText = p.DESCRIPCION;
                        TxtCie.Text = p.CIE;
                        TxtPre.Text = p.PRE;
                        TxtDef.Text = p.DEF;
                        TxtIDDiagnostico.Enabled = false;

                    }
                    else
                    {
                        Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx");
                    }

                }
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.DIAGNOSTICO_BUCAL p = new Models.DIAGNOSTICO_BUCAL();

                if (Modo == "E")
                {
                    p = bd.DIAGNOSTICO_BUCAL.FirstOrDefault(x => x.ID_DIAGNOSTICO.ToString() == R && x.ID_ODONTO.ToString() == FO);
                    if (p == null) return;
                }

                p.ID_ODONTO = int.Parse(FO);
                p.ID_DIAGNOSTICO = int.Parse(TxtIDDiagnostico.Text);
                p.DESCRIPCION = LblDescrip.InnerText;
                p.CIE = TxtCie.Text;
                p.PRE = TxtPre.Text;
                p.DEF = TxtDef.Text;

                if (this.Modo == "C") bd.DIAGNOSTICO_BUCAL.Add(p);
                try
                {
                    bd.SaveChanges();
                    Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx?FO=" + FO);
                }
                catch (Exception ex)
                {
                    Existe();
                }
            }

        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx?FO=" + FO);
        }
        private bool ValidarCampos()
        {
            if (TxtIDDiagnostico.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El Numero de Secion es Requerido')</script>");

                return false;
            }
            

            return true;
        }
        private void Existe()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya existe un registro con este Numero de Diagnostico')</script>");
            TxtIDDiagnostico.Text = "";


        }
    }
}