using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class ListarDiagnostico : System.Web.UI.Page
    {
        private string FO { get { string parametro = Request.QueryString["FO"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }

        protected void DisplayData()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.DIAGNOSTICO_BUCAL ss = new Models.DIAGNOSTICO_BUCAL();

            var q = from a in bd.DIAGNOSTICO_BUCAL
                    join C in bd.FICHA_ODONTOLOGICA
                    on a.ID_ODONTO equals C.ID_ODONTO
                    where a.ID_ODONTO.ToString() == FO
                    select new
                    {
                        a.ID_DIAGNOSTICO,
                        a.DESCRIPCION,
                        a.CIE,
                        a.PRE,
                        a.DEF
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

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnListarTodo.Visible = true;
            BaseDatosEntities bd = new BaseDatosEntities();
            if (string.IsNullOrEmpty(TxtBuscar.Text) == false)
            {
                var q = from a in bd.DIAGNOSTICO_BUCAL
                        join C in bd.FICHA_ODONTOLOGICA
                        on a.ID_ODONTO equals C.ID_ODONTO
                        where a.ID_DIAGNOSTICO.ToString() == TxtBuscar.Text && C.ID_ODONTO.ToString() == FO
                        select new
                        {
                            a.ID_DIAGNOSTICO,
                            a.DESCRIPCION,
                            a.CIE,
                            a.PRE,
                            a.DEF
                        }

                    ;
                GriPersonas.DataSource = q.ToList();
            }
            else
            {
                var q = from x in bd.DIAGNOSTICO_BUCAL select x;
                GriPersonas.DataSource = q.ToList();
            }
            GriPersonas.DataBind();
        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            //Creacion de Estado y envio de parametros
            Response.Redirect("~/Sistema/FichaOdontologica/Diagnostico.aspx?Modo=C&FO=" + FO);
        }

        protected void GriPersonas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Sistema/FichaOdontologica/Diagnostico.aspx?Modo=E&R=" + e.CommandArgument + "&FO=" + FO);

            }
            else if (e.CommandName == "Borrar")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "abrir();", true);
                LblEstado.Text = e.CommandArgument.ToString();
                
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.DIAGNOSTICO_BUCAL p = bd.DIAGNOSTICO_BUCAL.FirstOrDefault(x => x.ID_DIAGNOSTICO.ToString() == LblEstado.Text && x.ID_ODONTO.ToString() == FO);
            if (p != null)
            {
                bd.DIAGNOSTICO_BUCAL.Remove(p);
                try
                {
                    bd.SaveChanges();
                    DisplayData();
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
            Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx?FO="+FO);
        }

        protected void Regresar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
        }

        protected void GriPersonas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GriPersonas.PageIndex = e.NewPageIndex;
            DisplayData();
        }

        protected void BtnListarTodo_Click(object sender, ImageClickEventArgs e)
        {
            TxtBuscar.Text = "";
            Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx?FO=" + FO);
            BtnListarTodo.Visible = false;
        }
    }
}