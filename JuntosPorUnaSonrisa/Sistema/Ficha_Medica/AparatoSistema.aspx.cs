using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Ficha_Medica
{
    public partial class AparatoSistema : System.Web.UI.Page
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
                Models.INT_APARATO_SISTEMA p = bd.INT_APARATO_SISTEMA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
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
                        ChkDigestivo.SelectedValue = p.APA_DIGESTIVO;
                        TxtDigestivo.InnerText = p.APA_DIGESTIVOESPECF;
                        ChkCardiovascular.SelectedValue = p.APA_CARDIOVASCULAR;
                        TxtCardiovascular.InnerText = p.APA_CARDIOESPECIF;
                        ChkPulmonar.SelectedValue = p.APA_PULMONAR;
                        TxtPulmonar.InnerText = p.APA_PULMONARESPECIF;
                        ChkEndocrino.SelectedValue = p.APA_ENDOCRINO;
                        TxtEndocrino.InnerText = p.APA_ENDOCRINOESPECIF;
                        ChkUrinario.SelectedValue = p.APA_URINARIO;
                        TxtUrinario.InnerText = p.APA_URINARIOESPECIF;
                        ChkGenital.SelectedValue = p.APA_GENITAL;
                        TxtGenital.InnerText = p.APA_GENITALESPECIF;
                        LblMenarca.InnerText = p.APA_GINECOLOMENARCA;
                        LblFum.InnerText = p.APA_GINECOLOFUM;
                        ChkRitmo.SelectedValue = p.APA_GINECOLORITMO;
                        TxtRitmo.InnerText = p.APA_GINECOLOESPECIF;
                        ChkEsqueletico.SelectedValue = p.APA_MUSCOESQUELATICO;
                        ChkNervioso.SelectedValue = p.APA_NERVIOSO;
                        TxtNervioso.InnerText = p.APA_NERVIOSOESPECIF;
                        ChkPsiquiatrico.SelectedValue = p.APA_PSIQUIATRICO;
                        TxtPsiquiatrico.InnerText = p.APA_PSIQUIATRICOESPECIF;
                        TxtEsqueletico.InnerText = p.APA_MESQUELEESPECIF;

                    }
                    else
                    {
                        // Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx");
                    }
                }
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.INT_APARATO_SISTEMA p = new Models.INT_APARATO_SISTEMA();

            if (Modo == "E")
            {
                p = bd.INT_APARATO_SISTEMA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                if (p == null) return;
            }
            p.ID_FICHA_MEDICA = int.Parse(FM);
            p.APA_DIGESTIVO = ChkDigestivo.SelectedValue;
            p.APA_DIGESTIVOESPECF = TxtDigestivo.InnerText;
            p.APA_CARDIOVASCULAR = ChkCardiovascular.SelectedValue;
            p.APA_CARDIOESPECIF = TxtCardiovascular.InnerText;
            p.APA_PULMONAR = ChkPulmonar.SelectedValue;
            p.APA_PULMONARESPECIF = TxtPulmonar.InnerText;
            p.APA_ENDOCRINO = ChkEndocrino.SelectedValue;
            p.APA_ENDOCRINOESPECIF = TxtEndocrino.InnerText;
            p.APA_URINARIO = ChkUrinario.SelectedValue;
            p.APA_URINARIOESPECIF = TxtUrinario.InnerText;
            p.APA_GENITAL = ChkGenital.SelectedValue;
            p.APA_GENITALESPECIF = TxtGenital.InnerText;
            p.APA_GINECOLOMENARCA = LblMenarca.InnerText;
            p.APA_GINECOLOFUM = LblFum.InnerText;
            p.APA_GINECOLORITMO = ChkRitmo.SelectedValue;
            p.APA_GINECOLOESPECIF = TxtRitmo.InnerText;
            p.APA_MUSCOESQUELATICO = ChkEsqueletico.SelectedValue;
            p.APA_MESQUELEESPECIF = TxtEsqueletico.InnerText;
            p.APA_NERVIOSO = ChkNervioso.SelectedValue;
            p.APA_NERVIOSOESPECIF = TxtNervioso.InnerText;
            p.APA_PSIQUIATRICO = ChkPsiquiatrico.SelectedValue;
            p.APA_PSIQUIATRICOESPECIF = TxtPsiquiatrico.InnerText;
            
            

            if (this.Modo == "C") bd.INT_APARATO_SISTEMA.Add(p);
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

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
        }
    }
}