using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Antecedentes
{
    public partial class Frecuencia : System.Web.UI.Page
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
        private string M { get { string parametro = Request.QueryString["M"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private void Recuperar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA pk = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == pk.ID_PERSONA);
            LblFichaMedica.Text = "Nº Ficha Medica: " + FM;
            LblPersona.Text = "Cedula: " + p.PER_CEDULA;
            LblPerNombres.Text = "Nombre: " + p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;

        }
        private void Seleccionar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FRECUENCIA v = bd.FRECUENCIA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
            //Frutas
            if (v.FRUTAS[0].ToString() == "T") { FA1.Checked = true; }
            if (v.FRUTAS[1].ToString() == "T") { FA2.Checked = true; }
            if (v.FRUTAS[2].ToString() == "T") { FA3.Checked = true; }
            if (v.FRUTAS[3].ToString() == "T") { FB1.Checked = true; }
            if (v.FRUTAS[4].ToString() == "T") { FB2.Checked = true; }
            if (v.FRUTAS[5].ToString() == "T") { FB3.Checked = true; }
            if (v.FRUTAS[6].ToString() == "T") { FC1.Checked = true; }
            if (v.FRUTAS[7].ToString() == "T") { FC2.Checked = true; }
            if (v.FRUTAS[8].ToString() == "T") { FC3.Checked = true; }
            if (v.FRUTAS[9].ToString() == "T") { FC4.Checked = true; }
            //Verduraas
            if (v.VERDURAS[0].ToString() == "T") { VA1.Checked = true; }
            if (v.VERDURAS[1].ToString() == "T") { VA2.Checked = true; }
            if (v.VERDURAS[2].ToString() == "T") { VA3.Checked = true; }
            if (v.VERDURAS[3].ToString() == "T") { VB1.Checked = true; }
            if (v.VERDURAS[4].ToString() == "T") { VB2.Checked = true; }
            if (v.VERDURAS[5].ToString() == "T") { VB3.Checked = true; }
            if (v.VERDURAS[6].ToString() == "T") { VC1.Checked = true; }
            if (v.VERDURAS[7].ToString() == "T") { VC2.Checked = true; }
            if (v.VERDURAS[8].ToString() == "T") { VC3.Checked = true; }
            if (v.VERDURAS[9].ToString() == "T") { VC4.Checked = true; }
            //LECHE ENTERA
            if (v.LECHEENTERA[0].ToString() == "T") { LA1.Checked = true; }
            if (v.LECHEENTERA[1].ToString() == "T") { LA2.Checked = true; }
            if (v.LECHEENTERA[2].ToString() == "T") { LA3.Checked = true; }
            if (v.LECHEENTERA[3].ToString() == "T") { LB1.Checked = true; }
            if (v.LECHEENTERA[4].ToString() == "T") { LB2.Checked = true; }
            if (v.LECHEENTERA[5].ToString() == "T") { LB3.Checked = true; }
            if (v.LECHEENTERA[6].ToString() == "T") { LC1.Checked = true; }
            if (v.LECHEENTERA[7].ToString() == "T") { LC2.Checked = true; }
            if (v.LECHEENTERA[8].ToString() == "T") { LC3.Checked = true; }
            if (v.LECHEENTERA[9].ToString() == "T") { LC4.Checked = true; }
            //LECHE DESLACTOSADA
            if (v.LECHEDESLACTOSADA[0].ToString() == "T") { LDA1.Checked = true; }
            if (v.LECHEDESLACTOSADA[1].ToString() == "T") { LDA2.Checked = true; }
            if (v.LECHEDESLACTOSADA[2].ToString() == "T") { LDA3.Checked = true; }
            if (v.LECHEDESLACTOSADA[3].ToString() == "T") { LDB1.Checked = true; }
            if (v.LECHEDESLACTOSADA[4].ToString() == "T") { LDB2.Checked = true; }
            if (v.LECHEDESLACTOSADA[5].ToString() == "T") { LDB3.Checked = true; }
            if (v.LECHEDESLACTOSADA[6].ToString() == "T") { LDC1.Checked = true; }
            if (v.LECHEDESLACTOSADA[7].ToString() == "T") { LDC2.Checked = true; }
            if (v.LECHEDESLACTOSADA[8].ToString() == "T") { LDC3.Checked = true; }
            if (v.LECHEDESLACTOSADA[9].ToString() == "T") { LDC4.Checked = true; }
            //YOGURT
            if (v.YOGURT[0].ToString() == "T") { YA1.Checked = true; }
            if (v.YOGURT[1].ToString() == "T") { YA2.Checked = true; }
            if (v.YOGURT[2].ToString() == "T") { YA3.Checked = true; }
            if (v.YOGURT[3].ToString() == "T") { YB1.Checked = true; }
            if (v.YOGURT[4].ToString() == "T") { YB2.Checked = true; }
            if (v.YOGURT[5].ToString() == "T") { YB3.Checked = true; }
            if (v.YOGURT[6].ToString() == "T") { YC1.Checked = true; }
            if (v.YOGURT[7].ToString() == "T") { YC2.Checked = true; }
            if (v.YOGURT[8].ToString() == "T") { YC3.Checked = true; }
            if (v.YOGURT[9].ToString() == "T") { YC4.Checked = true; }
            //YOGURT FRUTAS
            if (v.YOGURTFRUTAS[0].ToString() == "T") { YFA1.Checked = true; }
            if (v.YOGURTFRUTAS[1].ToString() == "T") { YFA2.Checked = true; }
            if (v.YOGURTFRUTAS[2].ToString() == "T") { YFA3.Checked = true; }
            if (v.YOGURTFRUTAS[3].ToString() == "T") { YFB1.Checked = true; }
            if (v.YOGURTFRUTAS[4].ToString() == "T") { YFB2.Checked = true; }
            if (v.YOGURTFRUTAS[5].ToString() == "T") { YFB3.Checked = true; }
            if (v.YOGURTFRUTAS[6].ToString() == "T") { YFC1.Checked = true; }
            if (v.YOGURTFRUTAS[7].ToString() == "T") { YFC2.Checked = true; }
            if (v.YOGURTFRUTAS[8].ToString() == "T") { YFC3.Checked = true; }
            if (v.YOGURTFRUTAS[9].ToString() == "T") { YFC4.Checked = true; }
            //QUESO
            if (v.QUESO[0].ToString() == "T") { QA1.Checked = true; }
            if (v.QUESO[1].ToString() == "T") { QA2.Checked = true; }
            if (v.QUESO[2].ToString() == "T") { QA3.Checked = true; }
            if (v.QUESO[3].ToString() == "T") { QB1.Checked = true; }
            if (v.QUESO[4].ToString() == "T") { QB2.Checked = true; }
            if (v.QUESO[5].ToString() == "T") { QB3.Checked = true; }
            if (v.QUESO[6].ToString() == "T") { QC1.Checked = true; }
            if (v.QUESO[7].ToString() == "T") { QC2.Checked = true; }
            if (v.QUESO[8].ToString() == "T") { QC3.Checked = true; }
            if (v.QUESO[9].ToString() == "T") { QC4.Checked = true; }
            //QUESO ALTO
            if (v.QUESOA[0].ToString() == "T") { QAA1.Checked = true; }
            if (v.QUESOA[1].ToString() == "T") { QAA2.Checked = true; }
            if (v.QUESOA[2].ToString() == "T") { QAA3.Checked = true; }
            if (v.QUESOA[3].ToString() == "T") { QAB1.Checked = true; }
            if (v.QUESOA[4].ToString() == "T") { QAB2.Checked = true; }
            if (v.QUESOA[5].ToString() == "T") { QAB3.Checked = true; }
            if (v.QUESOA[6].ToString() == "T") { QAC1.Checked = true; }
            if (v.QUESOA[7].ToString() == "T") { QAC2.Checked = true; }
            if (v.QUESOA[8].ToString() == "T") { QAC3.Checked = true; }
            if (v.QUESOA[9].ToString() == "T") { QAC4.Checked = true; }
            //EMBUTIDOS
            if (v.EMBUTIDOS[0].ToString() == "T") { EA1.Checked = true; }
            if (v.EMBUTIDOS[1].ToString() == "T") { EA2.Checked = true; }
            if (v.EMBUTIDOS[2].ToString() == "T") { EA3.Checked = true; }
            if (v.EMBUTIDOS[3].ToString() == "T") { EB1.Checked = true; }
            if (v.EMBUTIDOS[4].ToString() == "T") { EB2.Checked = true; }
            if (v.EMBUTIDOS[5].ToString() == "T") { EB3.Checked = true; }
            if (v.EMBUTIDOS[6].ToString() == "T") { EC1.Checked = true; }
            if (v.EMBUTIDOS[7].ToString() == "T") { EC2.Checked = true; }
            if (v.EMBUTIDOS[8].ToString() == "T") { EC3.Checked = true; }
            if (v.EMBUTIDOS[9].ToString() == "T") { EC4.Checked = true; }
            //POLLO
            if (v.POLLO[0].ToString() == "T") { PA1.Checked = true; }
            if (v.POLLO[1].ToString() == "T") { PA2.Checked = true; }
            if (v.POLLO[2].ToString() == "T") { PA3.Checked = true; }
            if (v.POLLO[3].ToString() == "T") { PB1.Checked = true; }
            if (v.POLLO[4].ToString() == "T") { PB2.Checked = true; }
            if (v.POLLO[5].ToString() == "T") { PB3.Checked = true; }
            if (v.POLLO[6].ToString() == "T") { PC1.Checked = true; }
            if (v.POLLO[7].ToString() == "T") { PC2.Checked = true; }
            if (v.POLLO[8].ToString() == "T") { PC3.Checked = true; }
            if (v.POLLO[9].ToString() == "T") { PC4.Checked = true; }
            //LEGUMINOSA
            if (v.LEGUMINOSAS[0].ToString() == "T") { JA1.Checked = true; }
            if (v.LEGUMINOSAS[1].ToString() == "T") { JA2.Checked = true; }
            if (v.LEGUMINOSAS[2].ToString() == "T") { JA3.Checked = true; }
            if (v.LEGUMINOSAS[3].ToString() == "T") { JB1.Checked = true; }
            if (v.LEGUMINOSAS[4].ToString() == "T") { JB2.Checked = true; }
            if (v.LEGUMINOSAS[5].ToString() == "T") { JB3.Checked = true; }
            if (v.LEGUMINOSAS[6].ToString() == "T") { JC1.Checked = true; }
            if (v.LEGUMINOSAS[7].ToString() == "T") { JC2.Checked = true; }
            if (v.LEGUMINOSAS[8].ToString() == "T") { JC3.Checked = true; }
            if (v.LEGUMINOSAS[9].ToString() == "T") { JC4.Checked = true; }
            //HUEVO 
            if (v.HUEVO[0].ToString() == "T") { HA1.Checked = true; }
            if (v.HUEVO[1].ToString() == "T") { HA2.Checked = true; }
            if (v.HUEVO[2].ToString() == "T") { HA3.Checked = true; }
            if (v.HUEVO[3].ToString() == "T") { HB1.Checked = true; }
            if (v.HUEVO[4].ToString() == "T") { HB2.Checked = true; }
            if (v.HUEVO[5].ToString() == "T") { HB3.Checked = true; }
            if (v.HUEVO[6].ToString() == "T") { HC1.Checked = true; }
            if (v.HUEVO[7].ToString() == "T") { HC2.Checked = true; }
            if (v.HUEVO[8].ToString() == "T") { HC3.Checked = true; }
            if (v.HUEVO[9].ToString() == "T") { HC4.Checked = true; }
            //RES
            if (v.RES[0].ToString() == "T") { RA1.Checked = true; }
            if (v.RES[1].ToString() == "T") { RA2.Checked = true; }
            if (v.RES[2].ToString() == "T") { RA3.Checked = true; }
            if (v.RES[3].ToString() == "T") { RB1.Checked = true; }
            if (v.RES[4].ToString() == "T") { RB2.Checked = true; }
            if (v.RES[5].ToString() == "T") { RB3.Checked = true; }
            if (v.RES[6].ToString() == "T") { RC1.Checked = true; }
            if (v.RES[7].ToString() == "T") { RC2.Checked = true; }
            if (v.RES[8].ToString() == "T") { RC3.Checked = true; }
            if (v.RES[9].ToString() == "T") { RC4.Checked = true; }
            //CERDO
            if (v.CERDO[0].ToString() == "T") { CA1.Checked = true; }
            if (v.CERDO[1].ToString() == "T") { CA2.Checked = true; }
            if (v.CERDO[2].ToString() == "T") { CA3.Checked = true; }
            if (v.CERDO[3].ToString() == "T") { CB1.Checked = true; }
            if (v.CERDO[4].ToString() == "T") { CB2.Checked = true; }
            if (v.CERDO[5].ToString() == "T") { CB3.Checked = true; }
            if (v.CERDO[6].ToString() == "T") { CC1.Checked = true; }
            if (v.CERDO[7].ToString() == "T") { CC2.Checked = true; }
            if (v.CERDO[8].ToString() == "T") { CC3.Checked = true; }
            if (v.CERDO[9].ToString() == "T") { CC4.Checked = true; }
            //MARISCOS
            if (v.MARISCOS[0].ToString() == "T") { MA1.Checked = true; }
            if (v.MARISCOS[1].ToString() == "T") { MA2.Checked = true; }
            if (v.MARISCOS[2].ToString() == "T") { MA3.Checked = true; }
            if (v.MARISCOS[3].ToString() == "T") { MB1.Checked = true; }
            if (v.MARISCOS[4].ToString() == "T") { MB2.Checked = true; }
            if (v.MARISCOS[5].ToString() == "T") { MB3.Checked = true; }
            if (v.MARISCOS[6].ToString() == "T") { MC1.Checked = true; }
            if (v.MARISCOS[7].ToString() == "T") { MC2.Checked = true; }
            if (v.MARISCOS[8].ToString() == "T") { MC3.Checked = true; }
            if (v.MARISCOS[9].ToString() == "T") { MC4.Checked = true; }
            //VISERAS
            if (v.VISCERAS[0].ToString() == "T") { SA1.Checked = true; }
            if (v.VISCERAS[1].ToString() == "T") { SA2.Checked = true; }
            if (v.VISCERAS[2].ToString() == "T") { SA3.Checked = true; }
            if (v.VISCERAS[3].ToString() == "T") { SB1.Checked = true; }
            if (v.VISCERAS[4].ToString() == "T") { SB2.Checked = true; }
            if (v.VISCERAS[5].ToString() == "T") { SB3.Checked = true; }
            if (v.VISCERAS[6].ToString() == "T") { SC1.Checked = true; }
            if (v.VISCERAS[7].ToString() == "T") { SC2.Checked = true; }
            if (v.VISCERAS[8].ToString() == "T") { SC3.Checked = true; }
            if (v.VISCERAS[9].ToString() == "T") { SC4.Checked = true; }
            //AGUA
            if (v.AGUA[0].ToString() == "T") { AA1.Checked = true; }
            if (v.AGUA[1].ToString() == "T") { AA2.Checked = true; }
            if (v.AGUA[2].ToString() == "T") { AA3.Checked = true; }
            if (v.AGUA[3].ToString() == "T") { AB1.Checked = true; }
            if (v.AGUA[4].ToString() == "T") { AB2.Checked = true; }
            if (v.AGUA[5].ToString() == "T") { AB3.Checked = true; }
            if (v.AGUA[6].ToString() == "T") { AC1.Checked = true; }
            if (v.AGUA[7].ToString() == "T") { AC2.Checked = true; }
            if (v.AGUA[8].ToString() == "T") { AC3.Checked = true; }
            if (v.AGUA[9].ToString() == "T") { AC4.Checked = true; }
            //BEBIDAS
            if (v.BEBIDASA[0].ToString() == "T") { BA1.Checked = true; }
            if (v.BEBIDASA[1].ToString() == "T") { BA2.Checked = true; }
            if (v.BEBIDASA[2].ToString() == "T") { BA3.Checked = true; }
            if (v.BEBIDASA[3].ToString() == "T") { BB1.Checked = true; }
            if (v.BEBIDASA[4].ToString() == "T") { BB2.Checked = true; }
            if (v.BEBIDASA[5].ToString() == "T") { BB3.Checked = true; }
            if (v.BEBIDASA[6].ToString() == "T") { BC1.Checked = true; }
            if (v.BEBIDASA[7].ToString() == "T") { BC2.Checked = true; }
            if (v.BEBIDASA[8].ToString() == "T") { BC3.Checked = true; }
            if (v.BEBIDASA[9].ToString() == "T") { BC4.Checked = true; }
            //SNACK DULSE
            if (v.SNACKD[0].ToString() == "T") { KA1.Checked = true; }
            if (v.SNACKD[1].ToString() == "T") { KA2.Checked = true; }
            if (v.SNACKD[2].ToString() == "T") { KA3.Checked = true; }
            if (v.SNACKD[3].ToString() == "T") { KB1.Checked = true; }
            if (v.SNACKD[4].ToString() == "T") { KB2.Checked = true; }
            if (v.SNACKD[5].ToString() == "T") { KB3.Checked = true; }
            if (v.SNACKD[6].ToString() == "T") { KC1.Checked = true; }
            if (v.SNACKD[7].ToString() == "T") { KC2.Checked = true; }
            if (v.SNACKD[8].ToString() == "T") { KC3.Checked = true; }
            if (v.SNACKD[9].ToString() == "T") { KC4.Checked = true; }
            //SNACK SALADO
            if (v.SNACKS[0].ToString() == "T") { NA1.Checked = true; }
            if (v.SNACKS[1].ToString() == "T") { NA2.Checked = true; }
            if (v.SNACKS[2].ToString() == "T") { NA3.Checked = true; }
            if (v.SNACKS[3].ToString() == "T") { NB1.Checked = true; }
            if (v.SNACKS[4].ToString() == "T") { NB2.Checked = true; }
            if (v.SNACKS[5].ToString() == "T") { NB3.Checked = true; }
            if (v.SNACKS[6].ToString() == "T") { NC1.Checked = true; }
            if (v.SNACKS[7].ToString() == "T") { NC2.Checked = true; }
            if (v.SNACKS[8].ToString() == "T") { NC3.Checked = true; }
            if (v.SNACKS[9].ToString() == "T") { NC4.Checked = true; }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.FRECUENCIA v = bd.FRECUENCIA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
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
                        Seleccionar();
                    }
                }
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FRECUENCIA p = new Models.FRECUENCIA();

            if (Modo == "E")
            {
                p = bd.FRECUENCIA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                if (p == null) return;
            }
            p.ID_FICHA_MEDICA = int.Parse(FM);
            p.FRUTAS =
                FA1.Checked.ToString()[0].ToString() +
                FA2.Checked.ToString()[0].ToString() +
                FA3.Checked.ToString()[0].ToString() +
                FB1.Checked.ToString()[0].ToString() +
                FB2.Checked.ToString()[0].ToString() +
                FB3.Checked.ToString()[0].ToString() +
                FC1.Checked.ToString()[0].ToString() +
                FC2.Checked.ToString()[0].ToString() +
                FC3.Checked.ToString()[0].ToString() +
                FC4.Checked.ToString()[0];

            p.VERDURAS =
                VA1.Checked.ToString()[0].ToString() +
                VA2.Checked.ToString()[0].ToString() +
                VA3.Checked.ToString()[0].ToString() +
                VB1.Checked.ToString()[0].ToString() +
                VB2.Checked.ToString()[0].ToString() +
                VB3.Checked.ToString()[0].ToString() +
                VC1.Checked.ToString()[0].ToString() +
                VC2.Checked.ToString()[0].ToString() +
                VC3.Checked.ToString()[0].ToString() +
                VC4.Checked.ToString()[0];
            p.LECHEENTERA =
                LA1.Checked.ToString()[0].ToString() +
                LA2.Checked.ToString()[0].ToString() +
                LA3.Checked.ToString()[0].ToString() +
                LB1.Checked.ToString()[0].ToString() +
                LB2.Checked.ToString()[0].ToString() +
                LB3.Checked.ToString()[0].ToString() +
                LC1.Checked.ToString()[0].ToString() +
                LC2.Checked.ToString()[0].ToString() +
                LC3.Checked.ToString()[0].ToString() +
                LC4.Checked.ToString()[0];
            p.LECHEDESLACTOSADA =
               LDA1.Checked.ToString()[0].ToString() +
               LDA2.Checked.ToString()[0].ToString() +
               LDA3.Checked.ToString()[0].ToString() +
               LDB1.Checked.ToString()[0].ToString() +
               LDB2.Checked.ToString()[0].ToString() +
               LDB3.Checked.ToString()[0].ToString() +
               LDC1.Checked.ToString()[0].ToString() +
               LDC2.Checked.ToString()[0].ToString() +
               LDC3.Checked.ToString()[0].ToString() +
               LDC4.Checked.ToString()[0];
            p.YOGURT =
               YA1.Checked.ToString()[0].ToString() +
               YA2.Checked.ToString()[0].ToString() +
               YA3.Checked.ToString()[0].ToString() +
               YB1.Checked.ToString()[0].ToString() +
               YB2.Checked.ToString()[0].ToString() +
               YB3.Checked.ToString()[0].ToString() +
               YC1.Checked.ToString()[0].ToString() +
               YC2.Checked.ToString()[0].ToString() +
               YC3.Checked.ToString()[0].ToString() +
               YC4.Checked.ToString()[0];
            p.YOGURTFRUTAS =
               YFA1.Checked.ToString()[0].ToString() +
               YFA2.Checked.ToString()[0].ToString() +
               YFA3.Checked.ToString()[0].ToString() +
               YFB1.Checked.ToString()[0].ToString() +
               YFB2.Checked.ToString()[0].ToString() +
               YFB3.Checked.ToString()[0].ToString() +
               YFC1.Checked.ToString()[0].ToString() +
               YFC2.Checked.ToString()[0].ToString() +
               YFC3.Checked.ToString()[0].ToString() +
               YFC4.Checked.ToString()[0];
            p.QUESO =
               QA1.Checked.ToString()[0].ToString() +
               QA2.Checked.ToString()[0].ToString() +
               QA3.Checked.ToString()[0].ToString() +
               QB1.Checked.ToString()[0].ToString() +
               QB2.Checked.ToString()[0].ToString() +
               QB3.Checked.ToString()[0].ToString() +
               QC1.Checked.ToString()[0].ToString() +
               QC2.Checked.ToString()[0].ToString() +
               QC3.Checked.ToString()[0].ToString() +
               QC4.Checked.ToString()[0];
            p.QUESOA =
               QAA1.Checked.ToString()[0].ToString() +
               QAA2.Checked.ToString()[0].ToString() +
               QAA3.Checked.ToString()[0].ToString() +
               QAB1.Checked.ToString()[0].ToString() +
               QAB2.Checked.ToString()[0].ToString() +
               QAB3.Checked.ToString()[0].ToString() +
               QAC1.Checked.ToString()[0].ToString() +
               QAC2.Checked.ToString()[0].ToString() +
               QAC3.Checked.ToString()[0].ToString() +
               QAC4.Checked.ToString()[0];
            p.EMBUTIDOS =
               EA1.Checked.ToString()[0].ToString() +
               EA2.Checked.ToString()[0].ToString() +
               EA3.Checked.ToString()[0].ToString() +
               EB1.Checked.ToString()[0].ToString() +
               EB2.Checked.ToString()[0].ToString() +
               EB3.Checked.ToString()[0].ToString() +
               EC1.Checked.ToString()[0].ToString() +
               EC2.Checked.ToString()[0].ToString() +
               EC3.Checked.ToString()[0].ToString() +
               EC4.Checked.ToString()[0];
            p.HUEVO =
               HA1.Checked.ToString()[0].ToString() +
               HA2.Checked.ToString()[0].ToString() +
               HA3.Checked.ToString()[0].ToString() +
               HB1.Checked.ToString()[0].ToString() +
               HB2.Checked.ToString()[0].ToString() +
               HB3.Checked.ToString()[0].ToString() +
               HC1.Checked.ToString()[0].ToString() +
               HC2.Checked.ToString()[0].ToString() +
               HC3.Checked.ToString()[0].ToString() +
               HC4.Checked.ToString()[0];
            p.POLLO =
               PA1.Checked.ToString()[0].ToString() +
               PA2.Checked.ToString()[0].ToString() +
               PA3.Checked.ToString()[0].ToString() +
               PB1.Checked.ToString()[0].ToString() +
               PB2.Checked.ToString()[0].ToString() +
               PB3.Checked.ToString()[0].ToString() +
               PC1.Checked.ToString()[0].ToString() +
               PC2.Checked.ToString()[0].ToString() +
               PC3.Checked.ToString()[0].ToString() +
               PC4.Checked.ToString()[0];
            p.RES =
               RA1.Checked.ToString()[0].ToString() +
               RA2.Checked.ToString()[0].ToString() +
               RA3.Checked.ToString()[0].ToString() +
               RB1.Checked.ToString()[0].ToString() +
               RB2.Checked.ToString()[0].ToString() +
               RB3.Checked.ToString()[0].ToString() +
               RC1.Checked.ToString()[0].ToString() +
               RC2.Checked.ToString()[0].ToString() +
               RC3.Checked.ToString()[0].ToString() +
               RC4.Checked.ToString()[0];
            p.CERDO =
               CA1.Checked.ToString()[0].ToString() +
               CA2.Checked.ToString()[0].ToString() +
               CA3.Checked.ToString()[0].ToString() +
               CB1.Checked.ToString()[0].ToString() +
               CB2.Checked.ToString()[0].ToString() +
               CB3.Checked.ToString()[0].ToString() +
               CC1.Checked.ToString()[0].ToString() +
               CC2.Checked.ToString()[0].ToString() +
               CC3.Checked.ToString()[0].ToString() +
               CC4.Checked.ToString()[0];
            p.MARISCOS =
               MA1.Checked.ToString()[0].ToString() +
               MA2.Checked.ToString()[0].ToString() +
               MA3.Checked.ToString()[0].ToString() +
               MB1.Checked.ToString()[0].ToString() +
               MB2.Checked.ToString()[0].ToString() +
               MB3.Checked.ToString()[0].ToString() +
               MC1.Checked.ToString()[0].ToString() +
               MC2.Checked.ToString()[0].ToString() +
               MC3.Checked.ToString()[0].ToString() +
               MC4.Checked.ToString()[0];
            p.VISCERAS =
               SA1.Checked.ToString()[0].ToString() +
               SA2.Checked.ToString()[0].ToString() +
               SA3.Checked.ToString()[0].ToString() +
               SB1.Checked.ToString()[0].ToString() +
               SB2.Checked.ToString()[0].ToString() +
               SB3.Checked.ToString()[0].ToString() +
               SC1.Checked.ToString()[0].ToString() +
               SC2.Checked.ToString()[0].ToString() +
               SC3.Checked.ToString()[0].ToString() +
               SC4.Checked.ToString()[0];
            p.LEGUMINOSAS =
               JA1.Checked.ToString()[0].ToString() +
               JA2.Checked.ToString()[0].ToString() +
               JA3.Checked.ToString()[0].ToString() +
               JB1.Checked.ToString()[0].ToString() +
               JB2.Checked.ToString()[0].ToString() +
               JB3.Checked.ToString()[0].ToString() +
               JC1.Checked.ToString()[0].ToString() +
               JC2.Checked.ToString()[0].ToString() +
               JC3.Checked.ToString()[0].ToString() +
               JC4.Checked.ToString()[0];
            p.AGUA =
               AA1.Checked.ToString()[0].ToString() +
               AA2.Checked.ToString()[0].ToString() +
               AA3.Checked.ToString()[0].ToString() +
               AB1.Checked.ToString()[0].ToString() +
               AB2.Checked.ToString()[0].ToString() +
               AB3.Checked.ToString()[0].ToString() +
               AC1.Checked.ToString()[0].ToString() +
               AC2.Checked.ToString()[0].ToString() +
               AC3.Checked.ToString()[0].ToString() +
               AC4.Checked.ToString()[0];
            p.BEBIDASA =
               BA1.Checked.ToString()[0].ToString() +
               BA2.Checked.ToString()[0].ToString() +
               BA3.Checked.ToString()[0].ToString() +
               BB1.Checked.ToString()[0].ToString() +
               BB2.Checked.ToString()[0].ToString() +
               BB3.Checked.ToString()[0].ToString() +
               BC1.Checked.ToString()[0].ToString() +
               BC2.Checked.ToString()[0].ToString() +
               BC3.Checked.ToString()[0].ToString() +
               BC4.Checked.ToString()[0];
            p.SNACKD =
               KA1.Checked.ToString()[0].ToString() +
               KA2.Checked.ToString()[0].ToString() +
               KA3.Checked.ToString()[0].ToString() +
               KB1.Checked.ToString()[0].ToString() +
               KB2.Checked.ToString()[0].ToString() +
               KB3.Checked.ToString()[0].ToString() +
               KC1.Checked.ToString()[0].ToString() +
               KC2.Checked.ToString()[0].ToString() +
               KC3.Checked.ToString()[0].ToString() +
               KC4.Checked.ToString()[0];
            p.SNACKS =
               NA1.Checked.ToString()[0].ToString() +
               NA2.Checked.ToString()[0].ToString() +
               NA3.Checked.ToString()[0].ToString() +
               NB1.Checked.ToString()[0].ToString() +
               NB2.Checked.ToString()[0].ToString() +
               NB3.Checked.ToString()[0].ToString() +
               NC1.Checked.ToString()[0].ToString() +
               NC2.Checked.ToString()[0].ToString() +
               NC3.Checked.ToString()[0].ToString() +
               NC4.Checked.ToString()[0];

            if (this.Modo == "C") bd.FRECUENCIA.Add(p);
            try
            {
                bd.SaveChanges();
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteNutricional.aspx?Modo=E&FM=" + FM);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteNutricional.aspx?Modo=E&FM=" + FM);
           
        }
    }
}