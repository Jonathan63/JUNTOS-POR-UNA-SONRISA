using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class Tratamiento : System.Web.UI.Page
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
            LblFichaMedica.Text = "Nº Ficha Medica: " + FO;
            LblPersona.Text = "Cedula: " + p.PER_CEDULA;
            LblPerNombres.Text = "Nombre: " + p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                
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
                    BaseDatosEntities bd = new BaseDatosEntities();
                    Models.TRATAMIENTO p = bd.TRATAMIENTO.FirstOrDefault(x => x.ID_SECION.ToString() == R && x.ID_ODONTO.ToString() == FO);

                    Recuperar();
                    if (p != null)
                    {
                        TxtIDSecion.Text = p.ID_SECION.ToString();
                        TxtFecha.Text = p.FECHA.ToString();
                        LblDiagnosti.InnerText = p.DIAGNOSTICO;
                        LblProsedimient.InnerText = p.PROCEDIMIENTOS;
                        LblPrescrip.InnerText = p.PRESCRIPCIONESA;
                        TxtCodigo.Text = p.DIAGNOSTICO;
                        TxtFirma.Text = p.FIRMA;
                        TxtZona.InnerText = p.ZONA;

                    }
                    else
                    {
                        Response.Redirect("~/Sistema/FichaOdontologica/ListarTratamiento.aspx");
                    }
                }
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/ListarTratamiento.aspx?FO="+FO);
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.TRATAMIENTO p = new Models.TRATAMIENTO();

                if (Modo == "E")
                {
                    p = bd.TRATAMIENTO.FirstOrDefault(x => x.ID_SECION.ToString() == R && x.ID_ODONTO.ToString() == FO);
                    if (p == null) return;
                }
                p.ID_ODONTO = int.Parse(FO);
                p.ID_SECION = int.Parse(TxtIDSecion.Text);
                p.FECHA = DateTime.Parse(TxtFecha.Text);
                p.DIAGNOSTICO = LblDiagnosti.InnerText;
                p.PROCEDIMIENTOS = LblProsedimient.InnerText;
                p.PRESCRIPCIONESA = LblPrescrip.InnerText;
                p.CODIGO = TxtCodigo.Text;
                p.FIRMA = TxtFirma.Text;
                p.ZONA = TxtZona.InnerText;

                if (this.Modo == "C") bd.TRATAMIENTO.Add(p);
                try
                {
                    bd.SaveChanges();
                    Response.Redirect("~/Sistema/FichaOdontologica/ListarTratamiento.aspx?FO=" + FO);
                }
                catch (Exception ex)
                {
                    Existe();
                }

            }
        }
        private bool ValidarCampos()
        {
            if (TxtIDSecion.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El Numero de Secion es Requerido')</script>");

                return false;
            }
            if (TxtFecha.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('La Fecha de Secion es Requerida')</script>");

                return false;
            }

            return true;
        }
        private void Existe()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya existe un registro con este Numero de secion')</script>");
            TxtIDSecion.Text = "";


        }
    }
}