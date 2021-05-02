using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class FichaOdontologica : System.Web.UI.Page
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
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string FO { get { string parametro = Request.QueryString["FO"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string A { get { string parametro = Request.QueryString["A"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private void LimpiarDatos()
        {
            BtnAceptar.Visible = false;
            BtnCancelar.Text = "Limpiar Datos";

        }
        protected void Recuperar1()
        {
            BaseDatosEntities bds = new BaseDatosEntities();
            Models.PERSONA p = bds.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == A);
            LblPerNombres.Text = p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;
            TxtFichaOdontologica.Enabled = false;
            BtnBuscarFO.Visible = false;
            BtnGenerarFO.Visible = false;
            TxtFichaOdontologica.Text = FO;
            TxtPersona.Text = A;
            TxtCedula.Text = p.PER_CEDULA;
            BtnBuscarP.Visible = true;

        }
        protected void Recuperar()
        {
            BaseDatosEntities bds = new BaseDatosEntities();
            Models.FICHA_ODONTOLOGICA fm = bds.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
            Models.PERSONA p = bds.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == fm.ID_PERSONA);
            LblPerNombres.Text = p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;
            TxtFichaOdontologica.Text = fm.ID_ODONTO.ToString();
            TxtPersona.Text = p.ID_PERSONA;
            TxtCedula.Text = p.PER_CEDULA.ToString();

        }
        protected void ActivarDesactivarFO(Char Modo)
        {
            if (Modo == 'C')
            {

                LblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
                TxtPersona.Enabled = false;
                BtnBuscarP.Visible = false;
                BtnAceptar.Visible = false;
                BtnEditarPersona.Visible = false;
                ContenidoSecundario.Visible = false;
            }
            if (Modo == 'E')
            {
                LblFecha.Text = DateTime.Today.ToString("dd/MM/yyyy");
                TxtPersona.Enabled = false;
                BtnBuscarP.Visible = false;
                BtnGenerarFO.Visible = false;
                TxtFichaOdontologica.Enabled = false;
                BtnBuscarFO.Visible = false;

            }

        }
        protected void Validacion()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA p = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaOdontologica.Text);
            Models.FICHA_ODONTOLOGICA q = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO.ToString() == TxtFichaOdontologica.Text);

            if (q != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya Existe una Ficha Odontologica Con Este Numero') </script>");
                BtnAceptar.Visible = false;

            }
            else if (q == null && p == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ficha Odontologica Inexistente') </script>");
                BtnBuscarP.Visible = true;
                BtnBuscarFO.Visible = false;
                BtnGenerarFO.Visible = false;
                BtnAceptar.Visible = false;
                TxtFichaOdontologica.Enabled = false;
            }
            else if (q == null && p != null)
            {
                Models.PERSONA per = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA == p.ID_PERSONA);
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El paciente no dispone de un registro Odontologico, Pero cuenta con un registro medico') </script>");
                TxtPersona.Text = per.ID_PERSONA;
                LblPerNombres.Text = per.PER_APELLIDO_PATERNO + " " + per.PER_APELLIDO_MATERNO + " " + per.PER_NOMBRES;
                BtnAceptar.Visible = true;
                TxtFichaOdontologica.Enabled = false;
                BtnBuscarFO.Visible = false;
                BtnCancelar.Text = "Limpiar Datos";

            }



        }
        protected void ValidacionPersona()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_ODONTOLOGICA per = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_PERSONA == TxtPersona.Text);
            //Models.FICHA_MEDICA pe = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_PERSONA == TxtPersona.Text);
            //if (pe != null)
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('" + LblPerNombres.Text + " ?','Tiene Informacion Relacionada con el Registro " + pe.ID_FICHA_MEDICA + "','error',) </script>");
            //    LimpiarDatos();
            //    BtnAceptar.Visible = false;
            //}
             if (per != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('" + LblPerNombres.Text + " ?','Tiene asignada la ficha Odontologica Nº "+per.ID_ODONTO+"','error',) </script>");
                LimpiarDatos();
                BtnAceptar.Visible = false;
            }
            else
            {
                BtnAceptar.Visible = true;
                BtnCancelar.Text = "Limpiar Datos";
            }
        }
        private bool ValidarCampos()
        {
            if (TxtFichaOdontologica.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El numero de ficha Odontologica es Requerida')</script>");
                return false;
            }
            
            return true;
        }
        private bool ValidarEmbarazo()
        {
            if (ChkEmbarazada.SelectedValue == "E" && ChkInfAdicional.SelectedIndex <= 3 && ChkInfAdicional.SelectedValue != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El Embarazo no Se puede Producir a Temprana Edad')</script>");
                return false;
            }

            return true;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Modo != "C" && Modo != "E")
            {
                Response.Redirect("~/Sistema/FichaOdontologica/ListarFichaOdontologica.aspx");
            }
            if (Modo == "C")
            {
                ActivarDesactivarFO('C');


                if (FO != "")
                {
                    Recuperar1();
                    ValidacionPersona();
                }

            }
            if (Modo == "E")
            {
                if (Page.IsPostBack == false)
                {
                    ActivarDesactivarFO('E');
                    BaseDatosEntities bd = new BaseDatosEntities();
                    Models.FICHA_ODONTOLOGICA p = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
                    if (p != null)
                    {
                        Recuperar();
                        //TxtFechaFM.Text = p.FIC_MED_FECHA.ToString();
                        ChkInfAdicional.SelectedValue = p.PERSONAINFOADICIONAL;
                        TextMotivoConsulta.InnerText = p.MOTIVOCONSULTA;
                        TextEnfermedadActual.InnerText = p.ENFERMEDADACTUAL;
                        ChkEmbarazada.SelectedValue = p.EMBARAZO;

                    }
                }
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarEmbarazo())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.FICHA_ODONTOLOGICA p = new Models.FICHA_ODONTOLOGICA();
                //Models.FICHA_MEDICA per = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_PERSONA == TxtPersona.Text);
                if (Modo == "E")
                {
                    p = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
                    if (p == null) return;
                }

                p.ID_ODONTO = int.Parse(TxtFichaOdontologica.Text);
                p.ID_PERSONA = TxtPersona.Text;
                p.PERSONAINFOADICIONAL = ChkInfAdicional.SelectedValue;
                p.MOTIVOCONSULTA = TextMotivoConsulta.InnerText;
                p.ENFERMEDADACTUAL = TextEnfermedadActual.InnerText;
                p.EMBARAZO = ChkEmbarazada.SelectedValue;

                if (this.Modo == "C") bd.FICHA_ODONTOLOGICA.Add(p);
                try
                {
                    bd.SaveChanges();
                    if (Modo == "C")
                    {
                        Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + TxtFichaOdontologica.Text);

                    }
                    if (Modo == "E")
                    {
                        Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx");
                    }


                }
                catch (Exception ex)
                {
                    LimpiarDatos();
                }
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (Modo == "C" && TxtPersona.Text != "" && TxtFichaOdontologica.Text != "") Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=C");
            else Response.Redirect("~/Sistema/FichaOdontologica/ListarFichaOdontologica.aspx?");

        }

        protected void BtnBuscarFO_Click(object sender, ImageClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Validacion();
            }
        }

        protected void BtnBuscarP_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx?&FM=" + TxtFichaOdontologica.Text + "&R=" + 2);
        }


        protected void BtnSignosVitales_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.SIGNOS_VITALES v = bd.SIGNOS_VITALES.FirstOrDefault(x => x.ID_ODONTO.ToString() == TxtFichaOdontologica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/SignosVitales.aspx?Modo=E&FO=" + FO);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/SignosVitales.aspx?Modo=C&FO=" + FO);
            }
        }

        protected void BtnOdontograma_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("~/Sistema/FichaOdontologica/ListarOdontograma.aspx?Modo=C&FO=" + FO);
            

        }

        protected void BtnIndSaludBucal_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.INDICADORES_SALUDB v = bd.INDICADORES_SALUDB.FirstOrDefault(x => x.ID_ODONTO.ToString() == TxtFichaOdontologica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/IndicadoresSaludBucal.aspx?Modo=E&FO=" + FO);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/IndicadoresSaludBucal.aspx?Modo=C&FO=" + FO);
            }
        }

        protected void BtnPlanesDiagnostico_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.PLANES_DIAGNOSTICO v = bd.PLANES_DIAGNOSTICO.FirstOrDefault(x => x.ID_ODONTO.ToString() == TxtFichaOdontologica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/PlanesDiagnostico.aspx?Modo=E&FO=" + FO);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/PlanesDiagnostico.aspx?Modo=C&FO=" + FO);
            }
        }

        protected void BtnDiagnostico_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx?&FO=" + FO);

        }

        protected void BtnEstogmatogmatico_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.EXA_SYS_ESTOMATOGMATICO v = bd.EXA_SYS_ESTOMATOGMATICO.FirstOrDefault(x => x.ID_ODONTO.ToString() == TxtFichaOdontologica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/ExaSisEstomatognatico.aspx?Modo=E&FO=" + FO);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/ExaSisEstomatognatico.aspx?Modo=C&FO=" + FO);
            }
        }

        protected void BtnAnteceFamilia_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ANTECEDENTE_ODONTO_FAMILIAR v = bd.ANTECEDENTE_ODONTO_FAMILIAR.FirstOrDefault(x => x.ID_ODONTO.ToString() == TxtFichaOdontologica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/AntecedenteOdontologico.aspx?Modo=E&FO=" + FO);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/FichaOdontologica/AntecedenteOdontologico.aspx?Modo=C&FO=" + FO);
            }
        }

        protected void BtnTratamiento_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/Sistema/FichaOdontologica/ListarTratamiento.aspx?&FO=" + FO);

        }

        protected void BtnGenerarFO_Click(object sender, ImageClickEventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_ODONTOLOGICA p = new Models.FICHA_ODONTOLOGICA();
            int cont = bd.FICHA_ODONTOLOGICA.Count();
            BtnBuscarP.Visible = true;
            BtnGenerarFO.Visible = false;
            BtnBuscarFO.Visible = false;

            int a = 0;
            do
            {
                Models.FICHA_ODONTOLOGICA q = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO == cont);

                if (q != null)
                {
                    cont = cont + 1;
                    TxtFichaOdontologica.Text = cont.ToString();
                    a = 1;
                }
                else if (q == null)
                {
                    if (cont == 0)
                    {
                        cont = cont + 1;
                        TxtFichaOdontologica.Text = cont.ToString();
                        a = 2;
                    }
                    else if (cont != 0)
                    {
                        TxtFichaOdontologica.Text = cont.ToString();
                        a = 2;
                    }
                }

            } while (a != 2);

        }

        protected void BtnEditarPersona_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/Personas/ProcesarPersonas.aspx?Modo=E&ID_PERSONA=" + TxtPersona.Text + "&R=" + 4 + "&FO=" + FO);
        }
    }
}