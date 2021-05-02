using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;


namespace JuntosPorUnaSonrisa.Sistema.Antecedentes
{
    public partial class ListarAntecedentesFamiliares : System.Web.UI.Page
    {
        protected void Seleccionar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ANTECEDENTE_FAMILIAR ss = new Models.ANTECEDENTE_FAMILIAR();

            var q = from a in bd.ANTECEDENTE_FAMILIAR
                    join C in bd.FICHA_MEDICA
                    on a.ID_FICHA_MEDICA equals C.ID_FICHA_MEDICA
                    join per in bd.PERSONA
                    on C.ID_PERSONA equals per.ID_PERSONA
                    where a.ID_FICHA_MEDICA.ToString() == FM
                    select new
                    {

                        a.ANT_NOMBRE,
                        per.ID_PERSONA,
                        a.ID_FICHA_MEDICA,
                        per.PER_APELLIDO_PATERNO,
                        per.PER_APELLIDO_MATERNO,
                        per.PER_NOMBRES
                        
                    }

                    ;

            GriListado.DataSource = q.ToList();
            // Todo control que va a mostrar informacion se debe usar el data bind
            GriListado.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)

            {
                Seleccionar();



            }


        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnListarTodo.Visible = true;
            BaseDatosEntities bd = new BaseDatosEntities();
            if (string.IsNullOrEmpty(TxtBuscar.Text) == false)
            {

                var q = from a in bd.ANTECEDENTE_FAMILIAR
                        join C in bd.FICHA_MEDICA
                        on a.ID_FICHA_MEDICA equals C.ID_FICHA_MEDICA
                        join per in bd.PERSONA
                        on C.ID_PERSONA equals per.ID_PERSONA
                        where a.ANT_NOMBRE.ToString().Contains(TxtBuscar.Text) 
                        select new
                        {
                            a.ANT_NOMBRE,
                            per.ID_PERSONA,
                            a.ID_FICHA_MEDICA,
                            per.PER_APELLIDO_PATERNO,
                            per.PER_APELLIDO_MATERNO,
                            per.PER_NOMBRES



                        }

                    ;
                GriListado.DataSource = q.ToList();
            }
            else
            {
                var q = from a in bd.ANTECEDENTE_FAMILIAR
                        join C in bd.FICHA_MEDICA
                        on a.ID_FICHA_MEDICA equals C.ID_FICHA_MEDICA
                        join per in bd.PERSONA
                        on C.ID_PERSONA equals per.ID_PERSONA
                        where a.ID_FICHA_MEDICA.ToString() == FM
                        select new
                        {
                            a.ANT_NOMBRE,
                            per.ID_PERSONA,
                            a.ID_FICHA_MEDICA,
                            per.PER_APELLIDO_PATERNO,
                            per.PER_APELLIDO_MATERNO,
                            per.PER_NOMBRES



                        }

                     ;

                GriListado.DataSource = q.ToList();
            }
            GriListado.DataBind();
        }


        protected void GriListado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar" && R == "1")
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteFamiliar.aspx?Modo=E&A=" + e.CommandArgument + "&FM=" + FM + "&R=" + R);

            }
            else if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteFamiliar.aspx?Modo=E&A=" + e.CommandArgument + "&FM=" + FM);

            }
            else if (e.CommandName == "Borrar")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "abrir();", true);
                LblEstado.Text = e.CommandArgument.ToString();
            }
        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            if (R == "1")
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteFamiliar.aspx?Modo=C&FM=" + FM + "&R=" + R);
            }
            else
            {

                Response.Redirect("~/Sistema/Antecedentes/AntecedenteFamiliar.aspx?Modo=C&FM=" + FM);
            }

        }
        private string A { get { string parametro = Request.QueryString["A"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }

        private string FM { get { string parametro = Request.QueryString["FM"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }

        protected void Regresar_Click(object sender, ImageClickEventArgs e)
        {
            if (R == "1")
            {
                Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
            }
            else
            {

                Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx");
            }
        }

        protected void GriListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GriListado.PageIndex = e.NewPageIndex;
            Seleccionar();
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ANTECEDENTE_FAMILIAR p = bd.ANTECEDENTE_FAMILIAR.FirstOrDefault(x => x.ANT_NOMBRE == LblEstado.Text && x.ID_FICHA_MEDICA.ToString() == FM);
            if (p != null)
            {
                bd.ANTECEDENTE_FAMILIAR.Remove(p);
                try
                {
                    bd.SaveChanges();
                    Seleccionar();
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
            Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx?FM=" + FM + "&R=" + R);
        }

        protected void BtnListarTodo_Click(object sender, ImageClickEventArgs e)
        {
            TxtBuscar.Text = "";
            Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx?FM=" + FM + "&R=" + R);
            BtnListarTodo.Visible = false;
        }
    }
}