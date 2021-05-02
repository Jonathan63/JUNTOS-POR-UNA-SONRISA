using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;
using System.Web.Security;
using System.Web.Mvc;
using Rotativa;
using JuntosPorUnaSonrisa.Controllers;
//using System.Windows.Forms;
//using System.Web.UI.HtmlControls;

namespace JuntosPorUnaSonrisa.Sistema.Ficha_Medica
{
    public partial class ListarFichaMedica : System.Web.UI.Page
    {
        protected void DisplayData()
        {

            BaseDatosEntities bd = new BaseDatosEntities();
            var q = from per in bd.PERSONA
                    join fm in bd.FICHA_MEDICA
                    on per.ID_PERSONA equals fm.ID_PERSONA
                    select new
                    {
                        fm.ID_FICHA_MEDICA,
                        per.ID_PERSONA,
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

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnListarTodo.Visible = true;
            BaseDatosEntities bd = new BaseDatosEntities();

            if (string.IsNullOrEmpty(TxtBuscar.Text) == false)
            {
                var q = from per in bd.PERSONA
                        join fm in bd.FICHA_MEDICA
                        on per.ID_PERSONA equals fm.ID_PERSONA
                        where fm.ID_FICHA_MEDICA.ToString() == TxtBuscar.Text || per.PER_CEDULA.ToString() == TxtBuscar.Text
                        || per.PER_APELLIDO_PATERNO.ToString() == TxtBuscar.Text
                        || per.PER_APELLIDO_MATERNO.ToString() == TxtBuscar.Text
                        || per.PER_NOMBRES.ToString() == TxtBuscar.Text
                        select new
                        {
                            fm.ID_FICHA_MEDICA,
                            per.ID_PERSONA,
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



        protected void GriListado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + e.CommandArgument);

            }
            else if (e.CommandName == "Borrar")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "abrir();", true);
                LblEstado.Text = e.CommandArgument.ToString();


            }
            else if (e.CommandName == "Imprimir")
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                var q = from fm in bd.HISTORIAL_FICHA
                        where e.CommandArgument.ToString() == fm.ID_FICHA_MEDICA.ToString()
                        select new
                        {
                            fm.ID_HISTORIAL,
                            fm.FIC_MED_FECHA

                        };

                object Lista = (GriListado.DataSource = q.ToList());
                string B = Lista.ToString();
                                Response.Redirect("../../Home/Print?A=" + e.CommandArgument );
            }
        }

        protected void Eliminado(int ID_FICHAMEDICA)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.HISTORIALFICHASCEE hf = new Models.HISTORIALFICHASCEE();
            int cont = bd.HISTORIALFICHASCEE.Count();
            int a = 0;
            int valor = 0;
            do
            {
                Models.HISTORIALFICHASCEE q = bd.HISTORIALFICHASCEE.FirstOrDefault(x => x.ID == cont);

                if (q != null)
                {
                    cont = cont + 1;
                    valor = cont;
                    a = 1;
                }
                else if (q == null)
                {
                    if (cont == 0)
                    {
                        cont = cont + 1;
                        valor = cont;
                        a = 2;
                    }
                    else if (cont != 0)
                    {
                        valor = cont;
                        a = 2;
                    }
                }

            } while (a != 2);
            FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
            USUARIO_SIS u = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID == id.Name);

            hf.ID = valor;
            hf.ACCION = "Eliminado";
            hf.FECHA = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToString("H:mm:ss");
            hf.USUARIO = u.USR_FIRSTNAME + " " + u.USR_SECONDNAME + " " + u.USR_APELLIDOP + " " + u.USR_APELLIDOM;
            hf.NUMERO = "Ficha Nº " + ID_FICHAMEDICA.ToString();


            try
            {
                bd.HISTORIALFICHASCEE.Add(hf);
                bd.SaveChanges();
            }
            catch
            {

            }
        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=C");
        }
        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            //Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx?S=" + 1);
            Models.FICHA_MEDICA p = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == LblEstado.Text);



            if (p != null)
            {
                bd.FICHA_MEDICA.Remove(p);

                try
                {
                    bd.SaveChanges();
                    //Las siguientes 3 lineas sirve para refrescar la grilla
                    DisplayData();
                    ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "Eliminado();", true);
                    Eliminado(p.ID_FICHA_MEDICA);
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }

        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx");

        }



        protected void GriListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GriListado.PageIndex = e.NewPageIndex;
            DisplayData();
        }

        protected void BtnListarTodo_Click(object sender, ImageClickEventArgs e)
        {

            TxtBuscar.Text = "";
            Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx");
            BtnListarTodo.Visible = false;
        }


    }
}