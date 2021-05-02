using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Brigada
{
    public partial class ListarHorarios : System.Web.UI.Page
    {
        private string H { get { string parametro = Request.QueryString["F"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        protected void DisplayData()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            var q = from x in bd.HORARIO select x;
            GriListado.DataSource = q.ToList();
            // Todo control que va a mostrar informacion se debe usar el data bind
            GriListado.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (R == "1")
            {
                GriListado.Columns[1].Visible = false;
            }
            else GriListado.Columns[0].Visible = false;
            if (Page.IsPostBack == false)
            {
                DisplayData();

            }
        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/Brigada/Horarios_Especialidad.aspx?Modo=C&R=" + 'B');
        }

        protected void GriListado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Sistema/Brigada/Horarios_Especialidad.aspx?Modo=E&H=" + e.CommandArgument + "&R=" + 'B');

            }

            if (e.CommandName == "Retornar")
            {
                Response.Redirect("~/Sistema/Brigada/Horarios_Especialidad.aspx?Modo=E&F=" + e.CommandArgument);
            }

            else if (e.CommandName == "Borrar")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "abrir();", true);
                LblEstado.Text = e.CommandArgument.ToString();
            }
        }
    }
}