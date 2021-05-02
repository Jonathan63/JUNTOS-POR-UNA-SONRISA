using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class IndicadoresSaludBucal : System.Web.UI.Page
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
                Models.INDICADORES_SALUDB p = bd.INDICADORES_SALUDB.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
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

                        Chk16.Checked = bool.Parse(p.PD_16);
                        Chk17.Checked = bool.Parse(p.PD_17);
                        Chk55.Checked = bool.Parse(p.PD_55);
                        Chk11.Checked = bool.Parse(p.PD_11);
                        Chk21.Checked = bool.Parse(p.PD_21);
                        Chk51.Checked = bool.Parse(p.PD_51);
                        Chk26.Checked = bool.Parse(p.PD_26);
                        Chk27.Checked = bool.Parse(p.PD_27);
                        Chk65.Checked = bool.Parse(p.PD_65);
                        Chk36.Checked = bool.Parse(p.PD_36);
                        Chk37.Checked = bool.Parse(p.PD_37);
                        Chk75.Checked = bool.Parse(p.PD_75);
                        Chk31.Checked = bool.Parse(p.PD_31);
                        Chk41.Checked = bool.Parse(p.PD_41);
                        Chk71.Checked = bool.Parse(p.PD_71);
                        Chk46.Checked = bool.Parse(p.PD_46);
                        Chk47.Checked = bool.Parse(p.PD_47);
                        Chk85.Checked = bool.Parse(p.PD_85);
                        //Txt de Placa
                        TxtPlaca16_55.Text = p.PLACA16_55;
                        TxtPlaca11_51.Text = p.PLACA11_51;
                        TxtPlaca26_65.Text = p.PLACA26_65;
                        TxtPlaca36_75.Text = p.PLACA36_75;
                        TxtPlaca31_71.Text = p.PLACA31_71;
                        TxtPlaca46_85.Text = p.PLACA46_85;
                        //TxtdeCadulo
                        TxtCalculo16_55.Text = p.CALDULO16_55;
                        TxtCalculo11_51.Text = p.CALCULO11_51;
                        TxtCalculo26_65.Text = p.CALCULO26_65;
                        TxtCalculo36_75.Text = p.CALCULO36_75;
                        TxtCalculo31_71.Text = p.CALCULO31_71;
                        TxtCalculo46_85.Text = p.CALCULO46_85;
                        //txt de Gingivitis
                        TxtGingivitis16_55.Text = p.GINGIVITIS16_55;
                        TxtGingivitis11_51.Text = p.GINGIVITIS11_55;
                        TxtGingivitis26_65.Text = p.GINGIVITIS26_65;
                        TxtGingivitis36_75.Text = p.GINGIVITIS36_75;
                        TxtGingivitis31_71.Text = p.GINGIVITIS31_71;
                        TxtGingivitis46_85.Text = p.GINGIVITIS46_85;
                        //Totales
                        TxtTotalCalculo.Text = p.TOTALCALCULO;
                        TxtTotalPlac.Text = p.TOTALPLACA;
                        TxtTotalGingivitis.Text = p.TOTALGINGIVITIS;
                        //ENFERMEDADES BUCALES
                        CmbEnfPeridontal.SelectedValue = p.ENF_PERIDONTAL;
                        CmbMalOclusion.SelectedValue = p.MAL_OCLUSION;
                        CmbFluorosis.SelectedValue = p.FLOUROSIS;



                        //INDICES CPO-ceo
                        TxtDC.Text = p.DC.ToString();
                        TxtDO.Text = p.DO.ToString();
                        TxtDP.Text = p.DP.ToString();
                        Txtc.Text = p.C.ToString();
                        Txte.Text = p.E.ToString();
                        Txto.Text = p.O.ToString();
                        TxtTotalceo.Text = p.TOTALCEO.ToString();
                        TexTotalCPO.Text = p.TOTALCPO.ToString();
                        ReEcuperar();
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
            Rellenar();
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.INDICADORES_SALUDB p = new Models.INDICADORES_SALUDB();
            if (Modo == "E")
            {
                p = bd.INDICADORES_SALUDB.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
                if (p == null) return;
            }
            p.ID_ODONTO = int.Parse(FO);
            p.PD_16 = Chk16.Checked.ToString();
            p.PD_17 = Chk17.Checked.ToString();
            p.PD_55 = Chk55.Checked.ToString();
            p.PD_11 = Chk11.Checked.ToString();
            p.PD_21 = Chk21.Checked.ToString();
            p.PD_51 = Chk51.Checked.ToString();
            p.PD_26 = Chk26.Checked.ToString();
            p.PD_27 = Chk27.Checked.ToString();
            p.PD_65 = Chk65.Checked.ToString();
            p.PD_36 = Chk36.Checked.ToString();
            p.PD_37 = Chk37.Checked.ToString();
            p.PD_75 = Chk75.Checked.ToString();
            p.PD_31 = Chk31.Checked.ToString();
            p.PD_41 = Chk41.Checked.ToString();
            p.PD_71 = Chk71.Checked.ToString();
            p.PD_46 = Chk46.Checked.ToString();
            p.PD_47 = Chk47.Checked.ToString();
            p.PD_85 = Chk85.Checked.ToString();
            //Placa
            p.PLACA16_55 = TxtPlaca16_55.Text;
            p.PLACA11_51 = TxtPlaca11_51.Text;
            p.PLACA26_65 = TxtPlaca26_65.Text;
            p.PLACA36_75 = TxtPlaca36_75.Text;
            p.PLACA31_71 = TxtPlaca31_71.Text;
            p.PLACA46_85 = TxtPlaca46_85.Text;
            //Calculo
            p.CALDULO16_55 = TxtCalculo16_55.Text;
            p.CALCULO11_51 = TxtCalculo11_51.Text;
            p.CALCULO26_65 = TxtCalculo26_65.Text;
            p.CALCULO36_75 = TxtCalculo36_75.Text;
            p.CALCULO31_71 = TxtCalculo31_71.Text;
            p.CALCULO46_85 = TxtCalculo46_85.Text;
            //Gingivitis
            p.GINGIVITIS16_55 = TxtGingivitis16_55.Text;
            p.GINGIVITIS11_55 = TxtGingivitis11_51.Text;
            p.GINGIVITIS26_65 = TxtGingivitis26_65.Text;
            p.GINGIVITIS36_75 = TxtGingivitis36_75.Text;
            p.GINGIVITIS31_71 = TxtGingivitis31_71.Text;
            p.GINGIVITIS46_85 = TxtGingivitis46_85.Text;
            //Totales
            p.TOTALPLACA = TxtTotalPlac.Text;
            p.TOTALCALCULO = TxtTotalCalculo.Text;
            p.TOTALGINGIVITIS = TxtTotalGingivitis.Text;
            //Enfermedades Bucales 
            p.ENF_PERIDONTAL = CmbEnfPeridontal.SelectedValue;
            p.MAL_OCLUSION = CmbEnfPeridontal.SelectedValue;
            p.FLOUROSIS = CmbFluorosis.SelectedValue;
            //Indices CPO-ceo
            p.DC = int.Parse(TxtDC.Text);
            p.DP = int.Parse(TxtDP.Text);
            p.DO = int.Parse(TxtDO.Text);

            p.C = int.Parse(Txtc.Text);
            p.E = int.Parse(Txte.Text);
            p.O = int.Parse(Txto.Text);
            p.TOTALCEO = int.Parse(TxtTotalceo.Text);
            p.TOTALCPO = int.Parse(TexTotalCPO.Text);

            if (this.Modo == "C") bd.INDICADORES_SALUDB.Add(p);
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
        private void Rellenar()
        {
            if (TxtPlaca16_55.Text == "") TxtPlaca16_55.Text = "0";
            if (TxtPlaca11_51.Text == "") TxtPlaca11_51.Text = "0";
            if (TxtPlaca26_65.Text == "") TxtPlaca26_65.Text = "0";
            if (TxtPlaca36_75.Text == "") TxtPlaca36_75.Text = "0";
            if (TxtPlaca31_71.Text == "") TxtPlaca31_71.Text = "0";
            if (TxtPlaca46_85.Text == "") TxtPlaca46_85.Text = "0";
            //Calculo
            if (TxtCalculo16_55.Text == "") TxtCalculo16_55.Text = "0";
            if (TxtCalculo11_51.Text == "") TxtCalculo11_51.Text = "0";
            if (TxtCalculo26_65.Text == "") TxtCalculo26_65.Text = "0";
            if (TxtCalculo36_75.Text == "") TxtCalculo36_75.Text = "0";
            if (TxtCalculo31_71.Text == "") TxtCalculo31_71.Text = "0";
            if (TxtCalculo46_85.Text == "") TxtCalculo46_85.Text = "0";
            //Gingivitis
            if (TxtGingivitis16_55.Text == "") TxtGingivitis16_55.Text = "0";
            if (TxtGingivitis11_51.Text == "") TxtGingivitis11_51.Text = "0";
            if (TxtGingivitis26_65.Text == "") TxtGingivitis26_65.Text = "0";
            if (TxtGingivitis36_75.Text == "") TxtGingivitis36_75.Text = "0";
            if (TxtGingivitis31_71.Text == "") TxtGingivitis31_71.Text = "0";
            if (TxtGingivitis46_85.Text == "") TxtGingivitis46_85.Text = "0";

            if (TxtDC.Text == "") TxtDC.Text = "0";
            if (TxtDP.Text == "") TxtDP.Text = "0";
            if (TxtDO.Text == "") TxtDO.Text = "0";
            if (Txtc.Text == "") Txtc.Text = "0";
            if (Txte.Text == "") Txte.Text = "0";
            if (Txto.Text == "") Txto.Text = "0";
            if (TxtTotalceo.Text == "") TxtTotalceo.Text = "0";
            if (TexTotalCPO.Text == "") TexTotalCPO.Text = "0";
        }
        private void ReEcuperar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.INDICADORES_SALUDB p = bd.INDICADORES_SALUDB.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);

            if (p.PLACA16_55 == "0") TxtPlaca16_55.Text = "";
            if (p.PLACA11_51 == "0") TxtPlaca11_51.Text = "";
            if (p.PLACA26_65 == "0") TxtPlaca26_65.Text = "";
            if (p.PLACA36_75 == "0") TxtPlaca36_75.Text = "";
            if (p.PLACA31_71 == "0") TxtPlaca31_71.Text = "";
            if (p.PLACA46_85 == "0") TxtPlaca46_85.Text = "";
            //Calculo
            if (p.CALDULO16_55 == "0") TxtCalculo16_55.Text = "";
            if (p.CALCULO11_51 == "0") TxtCalculo11_51.Text = "";
            if (p.CALCULO26_65 == "0") TxtCalculo26_65.Text = "";
            if (p.CALCULO36_75 == "0") TxtCalculo36_75.Text = "";
            if (p.CALCULO31_71 == "0") TxtCalculo31_71.Text = "";
            if (p.CALCULO46_85 == "0") TxtCalculo46_85.Text = "";
           
            //Gingivitis
            if (p.GINGIVITIS16_55 == "0") TxtGingivitis16_55.Text = "";
            if (p.GINGIVITIS11_55 == "0") TxtGingivitis11_51.Text = "";
            if (p.GINGIVITIS26_65 == "0") TxtGingivitis26_65.Text = "";
            if (p.GINGIVITIS36_75 == "0") TxtGingivitis36_75.Text = "";
            if (p.GINGIVITIS31_71 == "0") TxtGingivitis31_71.Text = "";
            if (p.GINGIVITIS46_85 == "0") TxtGingivitis46_85.Text = "";

            
        }

    }
}