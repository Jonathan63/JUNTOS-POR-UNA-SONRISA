using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Ficha_Medica
{
    public partial class DesarrolloSicomotor : System.Web.UI.Page
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
                Models.DESARROLLO_PSICOMOTOR p = bd.DESARROLLO_PSICOMOTOR.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                if (Modo != "C" && Modo != "E")
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

                        TxtCabeza.Text = p.PSI_SOSTUVO_CABEZA;
                        TxtSonrio.Text = p.PSI_SONRIO;
                        TxtBalbuceo.Text = p.PSI_BALBUCEO;
                        TxtSento.Text = p.PSI_SENTO;
                        TxtGateo.Text = p.PSI_GATEO;
                        TxtCaminoA.Text = p.PSI_CAMINO_AYUDA;
                        TxtCaminoS.Text = p.PSI_CAMINO_SOLO;
                        ChkEscuela.SelectedValue = p.PSI_DESEMPENHO_ESCOLAR;

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
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.DESARROLLO_PSICOMOTOR p = new Models.DESARROLLO_PSICOMOTOR();
            if (Modo == "E")
            {
                p = bd.DESARROLLO_PSICOMOTOR.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                if (p == null) return;
            }

            p.ID_FICHA_MEDICA = int.Parse(FM);
            p.PSI_SOSTUVO_CABEZA = TxtCabeza.Text;
            p.PSI_SONRIO = TxtSonrio.Text;
            p.PSI_BALBUCEO = TxtBalbuceo.Text;
            p.PSI_SENTO =TxtSento.Text;
            p.PSI_GATEO = TxtGateo.Text;
            p.PSI_CAMINO_AYUDA = TxtCaminoA.Text;
            p.PSI_CAMINO_SOLO = TxtCaminoS.Text;
            p.PSI_DESEMPENHO_ESCOLAR = ChkEscuela.SelectedValue;

            if (this.Modo == "C") bd.DESARROLLO_PSICOMOTOR.Add(p);
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

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
        }

    }
}