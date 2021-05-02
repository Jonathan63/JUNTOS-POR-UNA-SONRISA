using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class AntecedenteOdontologico : System.Web.UI.Page
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
                Models.ANTECEDENTE_ODONTO_FAMILIAR p = bd.ANTECEDENTE_ODONTO_FAMILIAR.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
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
                        TextAlergiaAntibiotico.InnerText = p.ALERGIAANTIBIOTICO;
                        TextAlergiaAnestecia.InnerText = p.ALERGIAANESTECIA;
                        TextHemorragias.InnerText = p.HEMORRAGIAS;
                        TextVIH.InnerText = p.VIH;
                        TextTuberculosis.InnerText = p.TUBERCULOSIS;
                        TextAsma.InnerText = p.ASMA;
                        TextDiabetes.InnerText = p.DIABETES;
                        TextHipertencion.InnerText = p.HIPERTENCION;
                        TextEnfCardiaca.InnerText = p.ENFCARDIACA;
                        TextEspecifique.InnerText = p.ESPECIFIQUE;
                        
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
            Models.ANTECEDENTE_ODONTO_FAMILIAR p = new Models.ANTECEDENTE_ODONTO_FAMILIAR();

            if (Modo == "E")
            {
                p = bd.ANTECEDENTE_ODONTO_FAMILIAR.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
                if (p == null) return;
            }
            p.ID_ODONTO = int.Parse(FO);
            p.ALERGIAANTIBIOTICO = TextAlergiaAntibiotico.InnerText;
            p.ALERGIAANESTECIA = TextAlergiaAnestecia.InnerText;
            p.HEMORRAGIAS = TextHemorragias.InnerText;
            p.VIH = TextVIH.InnerText;
            p.TUBERCULOSIS = TextTuberculosis.InnerText;
            p.ASMA = TextAsma.InnerText;
            p.DIABETES = TextDiabetes.InnerText;
            p.HIPERTENCION = TextHipertencion.InnerText;
            p.ENFCARDIACA = TextEnfCardiaca.InnerText;
            p.ESPECIFIQUE = TextEspecifique.InnerText;

            if (this.Modo == "C") bd.ANTECEDENTE_ODONTO_FAMILIAR.Add(p);
            try
            {
                bd.SaveChanges();
                Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
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