using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class ListarFichaOdontologica : System.Web.UI.Page
    {
        private string FO { get { string parametro = Request.QueryString["FO"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }

        protected void DisplayData()
        {

            BaseDatosEntities bd = new BaseDatosEntities();
            var q = from per in bd.PERSONA
                    join fm in bd.FICHA_ODONTOLOGICA
                    on per.ID_PERSONA equals fm.ID_PERSONA
                    select new
                    {
                        fm.ID_ODONTO,
                        per.PER_CEDULA,
                        per.PER_APELLIDO_PATERNO,
                        per.PER_APELLIDO_MATERNO,
                        per.PER_NOMBRES,
                        per.PER_SEXO,
                        per.PER_EDAD
                    };
            GriListado.DataSource = q.ToList();
            GriListado.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                DisplayData();
            }


        }


        protected void GriListado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + e.CommandArgument);

            }
            else if (e.CommandName == "Borrar")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "abrir();", true);
                LblEstado.Text = e.CommandArgument.ToString();


            }
        }

        protected void GriListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GriListado.PageIndex = e.NewPageIndex;
            DisplayData();
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnListarTodo.Visible = true;
            BaseDatosEntities bd = new BaseDatosEntities();
            if (string.IsNullOrEmpty(TxtBuscar.Text) == false)
            {
                var q = from per in bd.PERSONA
                        join fm in bd.FICHA_ODONTOLOGICA
                        on per.ID_PERSONA equals fm.ID_PERSONA
                        where fm.ID_ODONTO.ToString() == TxtBuscar.Text || per.ID_PERSONA.ToString() == TxtBuscar.Text || per.PER_APELLIDO_PATERNO.ToString() == TxtBuscar.Text
                        select new
                        {
                            fm.ID_ODONTO,
                            per.PER_CEDULA,
                            per.PER_APELLIDO_PATERNO,
                            per.PER_APELLIDO_MATERNO,
                            per.PER_NOMBRES,
                            per.PER_SEXO,
                            per.PER_EDAD
                        };
                GriListado.DataSource = q.ToList();
            }
            GriListado.DataBind();
        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=C");
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx?S=" + 1);
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_ODONTOLOGICA p = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO.ToString() == LblEstado.Text);
            if (p != null)
            {
                bd.FICHA_ODONTOLOGICA.Remove(p);
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

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/ListarFichaOdontologica.aspx");
        }

        protected void BtnListarTodo_Click(object sender, ImageClickEventArgs e)
        {
            TxtBuscar.Text = "";
            Response.Redirect("~/Sistema/FichaOdontologica/ListarFichaOdontologica.aspx");
            BtnListarTodo.Visible = false;
        }
    }
}