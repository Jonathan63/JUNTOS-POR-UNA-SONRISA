using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class ListarOdontograma : System.Web.UI.Page
    {
        private string FO { get { string parametro = Request.QueryString["FO"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }

        protected void DisplayData()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            var q = from a in bd.ODONTOGRAMA
                    join C in bd.FICHA_ODONTOLOGICA
                    on a.ID_ODONTO equals C.ID_ODONTO
                    where a.ID_ODONTO.ToString() == FO
                    select new
                    {
                        a.IDDIENTE,
                        //a.ID_ODONTO,
                        a.NDIENTE,
                        a.DESCRIPCION,
                        a.ENFERMEDAD
                    }

                    ;

            GriPersonas.DataSource = q.ToList();
            // Todo control que va a mostrar informacion se debe usar el data bind
            GriPersonas.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                DisplayData();
            }
        }

        protected void Regresar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/Odont.aspx?Modo=C&FO=" + FO);
        }

        protected void GriPersonas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Sistema/FichaOdontologica/Odont.aspx?Modo=E&R=" + e.CommandArgument + "&FO=" + FO);

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

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/ListarOdontograma.aspx?FO=" + FO);
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ODONTOGRAMA p = bd.ODONTOGRAMA.FirstOrDefault(x => x.IDDIENTE.ToString() == LblEstado.Text && x.ID_ODONTO.ToString() == FO);
            if (p != null)
            {
                bd.ODONTOGRAMA.Remove(p);
                try
                {
                    bd.SaveChanges();
                    //Las siguientes 3 lineas sirve para refrescar la grilla
                    DisplayData();
                    ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "Eliminado();", true);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }
    }
}