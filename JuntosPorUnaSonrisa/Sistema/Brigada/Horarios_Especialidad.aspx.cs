using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Brigada
{
    public partial class Horarios_Especialidad : System.Web.UI.Page
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
        private string R
        {
            get
            {
                string Parametro = Request.QueryString["R"];
                if (string.IsNullOrEmpty(Parametro) == true)
                {
                    return "";
                }
                return Parametro;
            }
        }
        private string F { get { string parametro = Request.QueryString["F"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string H { get { string parametro = Request.QueryString["H"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Modo != "C" && Modo != "E")
                {
                    Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx");
                }
                if (R == "A")
                {
                    Horarios.Visible = false;
                    if (Modo == "E")
                    {
                        BaseDatosEntities bd = new BaseDatosEntities();
                        Models.ESPECIALIDAD p = bd.ESPECIALIDAD.FirstOrDefault(x => x.TCON_ID.ToString() == F);
                        if (p != null)
                        {

                            TxtEspecialidad.Text = p.TCON_ID.ToString();
                            TxtEspecialidaName.Text = p.TCON_NOMBRE;
                        }
                    }
                }
                if (R == "B")
                {
                    Especialidad.Visible = false;
                    if (Modo == "E")
                    {
                        BaseDatosEntities bd = new BaseDatosEntities();
                        Models.HORARIO p = bd.HORARIO.FirstOrDefault(x => x.HORA_ID.ToString() == H);
                        if (p != null)
                        {

                            TxtIdHorario.Text = p.HORA_ID.ToString();
                            TxtDias.Text = p.HORA_DIAS;
                            TxtIngreso.Text = p.HORA_INGRESO;
                            Txtsalida.Text = p.HORA_SALIDA;
                        }
                    }
                }

            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            if (R == "A")
            {
                Models.ESPECIALIDAD p = new Models.ESPECIALIDAD();
                if (Modo == "E")
                {
                    p = bd.ESPECIALIDAD.FirstOrDefault(x => x.TCON_ID.ToString() == F);
                    if (p == null) return;
                }
                p.TCON_ID = int.Parse(TxtEspecialidad.Text);
                p.TCON_NOMBRE = TxtEspecialidaName.Text;
                if (this.Modo == "C") bd.ESPECIALIDAD.Add(p);
                try
                {
                    bd.SaveChanges();
                    Response.Redirect("~/Sistema/Brigada/ListarEspecialidad.aspx");
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('" + TxtEspecialidad.Text + " ?','Ya existe un registro con esta identificacion','error') </script>");
                }
            }
            if (R == "B")
            {
                Models.HORARIO p = new Models.HORARIO();
                if (Modo == "E")
                {
                    p = bd.HORARIO.FirstOrDefault(x => x.HORA_ID.ToString() == H);
                    if (p == null) return;
                }
                p.HORA_ID = int.Parse(TxtIdHorario.Text);
                p.HORA_DIAS = TxtDias.Text;
                p.HORA_INGRESO = TxtIngreso.Text;
                p.HORA_SALIDA = Txtsalida.Text;
                if (this.Modo == "C") bd.HORARIO.Add(p);
                try
                {
                    bd.SaveChanges();
                    Response.Redirect("~/Sistema/Brigada/ListarHorarios.aspx");
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('" + TxtEspecialidad.Text + " ?','Ya existe un registro con esta identificacion','error') </script>");
                }
            }




        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (R == "A")
            {
                Response.Redirect("~/Sistema/Brigada/ListarEspecialidad.aspx");
            }
            if (R == "B")
            {
                Response.Redirect("~/Sistema/Brigada/ListarHorarios.aspx");
            }
        }
    }
}