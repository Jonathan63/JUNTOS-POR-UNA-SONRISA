using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;
namespace JuntosPorUnaSonrisa.Sistema.Personas
{
    public partial class Historial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DisplayData();
            }
        }

        
        protected void GriListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GriListado.PageIndex = e.NewPageIndex;
            DisplayData();
        }
        protected void DisplayData()
        {

            BaseDatosEntities bd = new BaseDatosEntities();
            var q = from per in bd.HISTORIALFICHASCEE
                   
                    select new
                    {
                        per.ID,
                        per.USUARIO,
                        per.FECHA,
                        per.ACCION,
                        per.NUMERO
                    };
            GriListado.DataSource = q.ToList();
            GriListado.DataBind();
        }

        protected void BtnListarTodo_Click(object sender, ImageClickEventArgs e)
        {
            TxtBuscar.Text = "";
            DisplayData();
            BtnListarTodo.Visible = false;
        }

        protected void BtnBuscar_Click(object sender, ImageClickEventArgs e)
        {
            BtnListarTodo.Visible = true;
            BaseDatosEntities bd = new BaseDatosEntities();

            if (string.IsNullOrEmpty(TxtBuscar.Text) == false)
            {
                var q = from h in bd.HISTORIALFICHASCEE
                        where h.USUARIO.ToString().Contains(TxtBuscar.Text)
                        select h;
                GriListado.DataSource = q.ToList();
            }
            GriListado.DataBind();
        }
    }
}