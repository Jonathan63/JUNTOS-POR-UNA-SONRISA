using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Personas
{
    public partial class ListarPersonas : System.Web.UI.Page
    {
        private string FM { get { string parametro = Request.QueryString["FM"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string FO { get { string parametro = Request.QueryString["FO"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        protected void DisplayData()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            var q = from x in bd.PERSONA select x;
            GriPersonas.DataSource = q.ToList();
            // Todo control que va a mostrar informacion se debe usar el data bind
            GriPersonas.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (R == "1" || R == "2")
            {
                GriPersonas.Columns[1].Visible = false;
            }
            else GriPersonas.Columns[0].Visible = false;
            if (Page.IsPostBack == false)
            {
                DisplayData();

            }
        }
        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnListarTodo.Visible = true;
            
            BaseDatosEntities bd = new BaseDatosEntities();
            if (string.IsNullOrEmpty(TxtBuscar.Text) == false)
            {
                var q = from x in bd.PERSONA
                        where x.ID_PERSONA.ToString().Contains(TxtBuscar.Text) ||
                              x.PER_APELLIDO_PATERNO.Contains(TxtBuscar.Text) ||
                              x.PER_CEDULA.Contains(TxtBuscar.Text)
                        select x;
                GriPersonas.DataSource = q.ToList();
            }
            
            GriPersonas.DataBind();
        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            //Creacion de Estado y envio de parametros
            Response.Redirect("~/Sistema/Personas/ProcesarPersonas.aspx?Modo=C&FM=" + FM + "&R=" + R);
        }

        protected void GriPersonas_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Sistema/Personas/ProcesarPersonas.aspx?Modo=E&ID_PERSONA=" + e.CommandArgument);

            }

            if (e.CommandName == "Retornar")
            {
                if (R == "1")
                {
                    Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=C&A=" + e.CommandArgument + "&FM=" + FM);
                }
                else
                {
                    Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=C&A=" + e.CommandArgument + "&FO=" + FM);
                }
            }

            else if (e.CommandName == "Borrar")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "abrir();", true);
                LblEstado.Text = e.CommandArgument.ToString();
            }
        }

        protected void GriPersonas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GriPersonas.PageIndex = e.NewPageIndex;
            DisplayData();
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == LblEstado.Text);
            if (p != null)
            {
                bd.PERSONA.Remove(p);
                try
                {
                    bd.SaveChanges();
                    //Las siguientes 3 lineas sirve para refrescar la grilla
                    var q = from x in bd.PERSONA select x;
                    GriPersonas.DataSource = q.ToList();
                    // Todo control que va a mostrar informacion se debe usar el data bind
                    GriPersonas.DataBind();
                    ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "Eliminado();", true);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx");
        }

        protected void BtnListarTodo_Click(object sender, ImageClickEventArgs e)
        {
            if (R == "1")
            {
                Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx?&FM=" + FM + "&R=" + 1);
            }
            else if (R == "2")
            {
                Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx?&FM=" + FO + "&R=" + 1);
            }
            else
            {
                TxtBuscar.Text = "";
                Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx");
                BtnListarTodo.Visible = false;
            }
        }
    }
}