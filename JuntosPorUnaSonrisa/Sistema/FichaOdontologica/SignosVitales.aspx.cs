using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class SignosVitales : System.Web.UI.Page
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
        private void Recuperar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_ODONTOLOGICA pk = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == pk.ID_PERSONA);
            LblFichaMedica.Text = "Nº Ficha Medica: " + FO;
            LblPersona.Text = "Cedula: " + p.PER_CEDULA;
            LblPerNombres.Text = "Nombre: " + p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.SIGNOS_VITALES p = bd.SIGNOS_VITALES.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
                if (Modo != "E" && Modo != "C")
                {
                    Response.Redirect("~/Sistema/FichaOdontologica/ListarFichaOdontologica.aspx");
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
                        TxtPresionArterial.Text = p.PRESION_ARTERIAL;
                        TxtFrecuenciaCardiaca.Text = p.FRECUENCIA_CARDIACA;
                        TxtTemperatura.Text = p.TEMPERATURA;
                        TxtFRespiratoria.Text = p.F_RESPIRATORIA;
                    }
                    else
                    {
                        Response.Redirect("~/Sistema/FichaOdontologica/ListarFichaOdontologica.aspx");
                    }
                }
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.SIGNOS_VITALES p = new Models.SIGNOS_VITALES();

            if (Modo == "E")
            {
                p = bd.SIGNOS_VITALES.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
                if (p == null) return;
            }

            p.ID_ODONTO = int.Parse(FO);
            p.PRESION_ARTERIAL = TxtPresionArterial.Text;
            p.FRECUENCIA_CARDIACA = TxtFrecuenciaCardiaca.Text;
            p.TEMPERATURA = TxtTemperatura.Text;
            p.F_RESPIRATORIA = TxtFRespiratoria.Text;

            if (this.Modo == "C") bd.SIGNOS_VITALES.Add(p);
            try
            {
                bd.SaveChanges();
                Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO="+FO);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
        }
    }
}