using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Antecedentes
{
    public partial class AntecedentesNeuropsicologico : System.Web.UI.Page
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
                Models.ANTECEDENTE_NEUROPSICOLOGICO p = bd.ANTECEDENTE_NEUROPSICOLOGICO.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
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
                        ChkNeuConductaCasa.SelectedValue = p.NEU_CONDUCTACASA;
                        TxtNeuCasaEdad.Text = p.NEU_CCASAEDAD;
                        ChkNeuConductaEscuela.SelectedValue = p.NEU_CONDUCTAESCUELA;
                        TxtNeuConductaEscuelaEdad.Text = p.NEU_CESCUELAEDAD;
                        ChkNeuAprovechamiento.SelectedValue = p.NEU_APROVECHAMIENTO;
                        TxtNeuAprovechaientoEdad.Text = p.NEU_AEDAD;
                        ChkNeuPierdeEquilibrio.SelectedValue = p.NEU_PIERDEEQUILIBRIO;
                        TxtNeuPierdeEquilibrioEdad.Text = p.NEU_EQUILIBRIOEDAD;
                        ChkNeuDifHablar.SelectedValue = p.NEU_DHABLAR;
                        TxtNeuDifHablarEdad.Text = p.NEU_DHEDAD;
                        ChkNeuConsiliarSueno.SelectedValue = p.NEU_CSUENO;
                        TxtNeuConsiliarSuenoEdad.Text = p.NEU_CSUENOEDAD;
                        ChkNeuDespiertaNoche.SelectedValue = p.NEU_DNOCHE;
                        TxtNeuDespiertaNocheEdad.Text = p.NEU_DNOCHEEDAD;
                        ChkNeuDesmayo.SelectedValue = p.NEU_DESMAYO;
                        TxtNeuDesmayoEdad.Text = p.NEU_DESMAYOEDAD;
                        ChkNeuComoVe.SelectedValue = p.NEU_VE;
                        TxtNeuComoVeEdad.Text = p.NEU_VEEDAD;
                        ChkNeuComoOye.SelectedValue = p.NEU_OYE;
                        TxtNeuComoOyeEdad.Text = p.NEU_OYEEDAD;
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
            Models.ANTECEDENTE_NEUROPSICOLOGICO p = new Models.ANTECEDENTE_NEUROPSICOLOGICO();

            if (Modo == "E")
            {
                p = bd.ANTECEDENTE_NEUROPSICOLOGICO.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                if (p == null) return;
            }
            p.ID_FICHA_MEDICA = int.Parse(FM);
            p.NEU_CONDUCTACASA = ChkNeuConductaCasa.SelectedValue;
            p.NEU_CCASAEDAD = TxtNeuCasaEdad.Text;
            p.NEU_CONDUCTAESCUELA = ChkNeuConductaEscuela.SelectedValue;
            p.NEU_CESCUELAEDAD = TxtNeuConductaEscuelaEdad.Text;
            p.NEU_APROVECHAMIENTO = ChkNeuAprovechamiento.SelectedValue;
            p.NEU_AEDAD = TxtNeuAprovechaientoEdad.Text;
            p.NEU_PIERDEEQUILIBRIO = ChkNeuPierdeEquilibrio.SelectedValue;
            p.NEU_EQUILIBRIOEDAD = TxtNeuPierdeEquilibrioEdad.Text;
            p.NEU_DHABLAR = ChkNeuDifHablar.SelectedValue;
            p.NEU_DHEDAD = TxtNeuDifHablarEdad.Text;
            p.NEU_CSUENO = ChkNeuConsiliarSueno.SelectedValue;
            p.NEU_CSUENOEDAD = TxtNeuConsiliarSuenoEdad.Text;
            p.NEU_DNOCHE = ChkNeuDespiertaNoche.SelectedValue;
            p.NEU_DNOCHEEDAD = TxtNeuDespiertaNocheEdad.Text;
            p.NEU_DESMAYO = ChkNeuDesmayo.SelectedValue;
            p.NEU_DESMAYOEDAD = TxtNeuDesmayoEdad.Text;
            p.NEU_VE = ChkNeuComoVe.SelectedValue;
            p.NEU_VEEDAD = TxtNeuComoVeEdad.Text;
            p.NEU_OYE = ChkNeuComoOye.SelectedValue;
            p.NEU_OYEEDAD = TxtNeuComoOyeEdad.Text;

            if (this.Modo == "C") bd.ANTECEDENTE_NEUROPSICOLOGICO.Add(p);
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