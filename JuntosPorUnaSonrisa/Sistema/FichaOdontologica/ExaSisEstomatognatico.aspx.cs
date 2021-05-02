using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class ExaSisEstomatognatico : System.Web.UI.Page
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
                Models.EXA_SYS_ESTOMATOGMATICO p = bd.EXA_SYS_ESTOMATOGMATICO.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
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
                        
                        TxtLabios.InnerText = p.LABIOS;
                        TxtMejillas.InnerText = p.MEJILLAS;
                        TxtSuperior.InnerText = p.MAXILAR_SUPERIOR;
                        TxtInferior.InnerText = p.MAXILAR_INFERIOR;
                        TxtLengua.InnerText = p.LENGUA;
                        TxtPaladar.InnerText = p.PALADAR;
                        TxtPiso.InnerText = p.PISO;
                        TxtCarrillos.InnerText = p.CARRILLOS;
                        TxtSalivales.InnerText = p.GLANDULAS_SALIVALES;
                        TxtFaringe.InnerText = p.ORO_FARINGE;
                        TxtATM.InnerText = p.ATM;
                        TxtGanglios.InnerText = p.GANGLIOS;
                        RecuperarValidacion();
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
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.EXA_SYS_ESTOMATOGMATICO p = new Models.EXA_SYS_ESTOMATOGMATICO();

                if (Modo == "E")
                {
                    p = bd.EXA_SYS_ESTOMATOGMATICO.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
                    if (p == null) return;
                }

                p.ID_ODONTO = int.Parse(FO);
                p.LABIOS = TxtLabios.InnerText;
                p.MEJILLAS = TxtMejillas.InnerText;
                p.MAXILAR_SUPERIOR = TxtSuperior.InnerText;
                p.MAXILAR_INFERIOR = TxtInferior.InnerText;
                p.LENGUA = TxtLengua.InnerText;
                p.PALADAR = TxtPaladar.InnerText;
                p.PISO = TxtPiso.InnerText;
                p.CARRILLOS = TxtCarrillos.InnerText;
                p.GLANDULAS_SALIVALES = TxtSalivales.InnerText;
                p.ORO_FARINGE = TxtFaringe.InnerText;
                p.ATM = TxtATM.InnerText;
                p.GANGLIOS = TxtGanglios.InnerText;



                if (this.Modo == "C") bd.EXA_SYS_ESTOMATOGMATICO.Add(p);
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
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
        }
        private bool ValidarCampos()
        {
            if (ChkLabios.SelectedValue == "N" && TxtLabios.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('LABIOS Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkLabios.SelectedValue == "S" && TxtLabios.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('LABIOS Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkMejillas.SelectedValue == "N" && TxtMejillas.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('MEJILLAS Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkMejillas.SelectedValue == "S" && TxtMejillas.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('MEJILLAS Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkSuperior.SelectedValue == "N" && TxtSuperior.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('MAXILAR SUPERIOR Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkSuperior.SelectedValue == "S" && TxtSuperior.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('MAXILAR SUPERIOR Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkInferior.SelectedValue == "N" && TxtInferior.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('MAXILAR INFERIOR Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkInferior.SelectedValue == "S" && TxtInferior.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('MAXILAR INFERIOR Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkLengua.SelectedValue == "N" && TxtLengua.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('LENGUA Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkLengua.SelectedValue == "S" && TxtLengua.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('LENGUA Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkPaladar.SelectedValue == "N" && TxtPaladar.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('PALADAR Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkPaladar.SelectedValue == "S" && TxtPaladar.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('PALADAR Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkPiso.SelectedValue == "N" && TxtPiso.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('PISO Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkPiso.SelectedValue == "S" && TxtPiso.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('PISO Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkCarrillos.SelectedValue == "N" && TxtCarrillos.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('CARRILLOS Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkCarrillos.SelectedValue == "S" && TxtCarrillos.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('CARRILLOS Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkSalivales.SelectedValue == "N" && TxtSalivales.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('GLANDULAS SALIVALES Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkSalivales.SelectedValue == "S" && TxtSalivales.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('GLANDULAS SALIVALES Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkFaringe.SelectedValue == "N" && TxtFaringe.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('ORO FARINGE Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkFaringe.SelectedValue == "S" && TxtFaringe.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('ORO FARINGE Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkATM.SelectedValue == "N" && TxtATM.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('ATM Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkATM.SelectedValue == "S" && TxtATM.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('ATM Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkGanglios.SelectedValue == "N" && TxtGanglios.InnerText != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('GANGLIOS Al Seleccionar NO','El campo de especificacion debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkGanglios.SelectedValue == "S" && TxtGanglios.InnerText == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('GANGLIOS Al Seleccionar SI','El campo de especificacion NO debe estar vacio','warning')</script>");
                return false;
            }
            return true;
        }
        protected void RecuperarValidacion()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.EXA_SYS_ESTOMATOGMATICO p = bd.EXA_SYS_ESTOMATOGMATICO.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);

            if (p.LABIOS != "")
            {
                ChkLabios.SelectedValue = "S";
            }
            else if (p.LABIOS == "")
            {
                ChkLabios.SelectedValue = "N";
            }

            if (p.MEJILLAS != "")
            {
                ChkMejillas.SelectedValue = "S";
            }
            else if (p.MEJILLAS == "")
            {
                ChkMejillas.SelectedValue = "N";
            }

            if (p.MAXILAR_SUPERIOR != "")
            {
                ChkSuperior.SelectedValue = "S";
            }
            else if (p.MAXILAR_SUPERIOR == "")
            {
                ChkSuperior.SelectedValue = "N";
            }

            if (p.MAXILAR_INFERIOR != "")
            {
                ChkInferior.SelectedValue = "S";
            }
            else if (p.MAXILAR_INFERIOR == "")
            {
                ChkInferior.SelectedValue = "N";
            }
            if (p.LENGUA != "")
            {
                ChkLengua.SelectedValue = "S";
            }
            else if (p.LENGUA == "")
            {
                ChkLengua.SelectedValue = "N";
            }
            if (p.PALADAR != "")
            {
                ChkPaladar.SelectedValue = "S";
            }
            else if (p.PALADAR == "")
            {
                ChkPaladar.SelectedValue = "N";
            }
            if (p.PISO != "")
            {
                ChkPiso.SelectedValue = "S";
            }
            else if (p.PISO == "")
            {
                ChkPiso.SelectedValue = "N";
            }
            if (p.CARRILLOS != "")
            {
                ChkCarrillos.SelectedValue = "S";
            }
            else if (p.CARRILLOS == "")
            {
                ChkCarrillos.SelectedValue = "N";
            }
            if (p.GLANDULAS_SALIVALES != "")
            {
                ChkSalivales.SelectedValue = "S";
            }
            else if (p.GLANDULAS_SALIVALES == "")
            {
                ChkSalivales.SelectedValue = "N";
            }
            if (p.ORO_FARINGE != "")
            {
                ChkFaringe.SelectedValue = "S";
            }
            else if (p.ORO_FARINGE == "")
            {
                ChkFaringe.SelectedValue = "N";
            }
            if (p.ATM != "")
            {
                ChkATM.SelectedValue = "S";
            }
            else if (p.ATM == "")
            {
                ChkATM.SelectedValue = "N";
            }
            if (p.GANGLIOS != "")
            {
                ChkGanglios.SelectedValue = "S";
            }
            else if (p.GANGLIOS == "")
            {
                ChkGanglios.SelectedValue = "N";
            }
        }

    }
}