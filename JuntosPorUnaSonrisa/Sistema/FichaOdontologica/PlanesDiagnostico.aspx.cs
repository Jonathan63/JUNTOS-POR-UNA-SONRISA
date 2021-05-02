using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class PlanesDiagnostico : System.Web.UI.Page
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
                Models.PLANES_DIAGNOSTICO p = bd.PLANES_DIAGNOSTICO.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
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

                        TxtBiometria.InnerText = p.BIOMETRIA;
                        TxtSanguinea.InnerText = p.QUIMICA_SANGUINEA;
                        TxtRayos.InnerText = p.RAYOS_X;
                        TxtEspecifique.InnerText = p.ESPECIFIQUE;

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
            Models.PLANES_DIAGNOSTICO p = new Models.PLANES_DIAGNOSTICO();

            if (Modo == "E")
            {
                p = bd.PLANES_DIAGNOSTICO.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
                if (p == null) return;
            }
            p.ID_ODONTO = int.Parse(FO);
            p.BIOMETRIA = TxtBiometria.InnerText;
            p.QUIMICA_SANGUINEA = TxtSanguinea.InnerText;
            p.RAYOS_X = TxtRayos.InnerText;
            p.ESPECIFIQUE = TxtEspecifique.InnerText;

            if (this.Modo == "C") bd.PLANES_DIAGNOSTICO.Add(p);
            try
            {
                bd.SaveChanges();
                Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
            }
            catch (Exception ex)
            {
                Response.Write("Ya Existe un registro con este numero de identificacion");
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
        }
    }
}