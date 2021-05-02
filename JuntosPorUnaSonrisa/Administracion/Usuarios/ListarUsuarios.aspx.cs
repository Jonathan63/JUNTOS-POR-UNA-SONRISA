using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Administracion.Usuarios
{
    public partial class ListarUsuarios : System.Web.UI.Page
    {
        protected void DisplayData()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            var q = from x in bd.USUARIO_SIS select x;
            GriUsuarios.DataSource = q.ToList();
            // Todo control que va a mostrar informacion se debe usar el data bind
            GriUsuarios.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
               if(ValidarUsuarioRol())
                {
                    DisplayData();
                }

            }
        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Administracion/Usuarios/ProcesarUsuarios.aspx?Modo=C");
        }

        protected void BtnBuscar_Click(object sender, EventArgs e)
        {
            BtnListarTodo.Visible = true;
            BaseDatosEntities bd = new BaseDatosEntities();
            if (string.IsNullOrEmpty(TxtBuscar.Text) == false)
            {
                var q = from x in bd.USUARIO_SIS
                        where x.USR_ID.ToString().Contains(TxtBuscar.Text) ||
                              x.USR_APELLIDOP.Contains(TxtBuscar.Text)
                        select x;
                GriUsuarios.DataSource = q.ToList();
            }
            else
            {
                var q = from x in bd.USUARIO_SIS select x;
                GriUsuarios.DataSource = q.ToList();
            }
            GriUsuarios.DataBind();
        }

        protected void GriUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Administracion/Usuarios/ProcesarUsuarios.aspx?Modo=E&Cuenta=" + e.CommandArgument);

            }
            else if (e.CommandName == "Borrar")
            {
                if (ValidarUsuario(e.CommandArgument.ToString()))
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "abrir();", true);
                    LblEstado.Text = e.CommandArgument.ToString();
                }
            }

        }



        protected void IdNuevoB_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administracion/Usuarios/ProcesarUsuarios.aspx?Modo=C");
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {

            BaseDatosEntities bd = new BaseDatosEntities();
            Models.USUARIO_SIS p = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID.ToString() == LblEstado.Text);
            if (p != null)
            {
                bd.USUARIO_SIS.Remove(p);
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
            Response.Redirect("~/Administracion/Usuarios/ListarUsuarios.aspx");
        }



        protected void GriUsuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GriUsuarios.PageIndex = e.NewPageIndex;
            DisplayData();
        }
        protected bool ValidarUsuario(string e)
        {

            FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
            BaseDatosEntities bd = new BaseDatosEntities();
            USUARIO_SIS u = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID == id.Name);
            if (u.USR_ID == e)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('No puedes Auto eliminarte.')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "CambiarColor();", true);
                return false;
            }
            else if (e == "Administrador")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('No puedes eliminar al Administrador.')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "CambiarColor();", true);
                return false;
            }


            return true;

        }
       
        protected bool ValidarUsuarioRol()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {

                if (HttpContext.Current.User.Identity is FormsIdentity)
                {
                    FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
                    BaseDatosEntities bd = new BaseDatosEntities();
                    USUARIO_SIS u = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID == id.Name);
                    string[] roles = new string[] { u.USR_ROLES };
                    HttpContext.Current.User = new GenericPrincipal(id, roles);
                    if (u.USR_ROLES != "A" && u.USR_ROLES != "X" && u.USR_ROLES != "Y")
                    {
                        Response.Redirect("~/Default.aspx");
                        return false;
                    }
                    
                }

            }
            else
            {
                Response.Redirect("~/Default.aspx");
                return false;
            }

            return true;

        }

        
        protected void BtnListarTodo_Click(object sender, ImageClickEventArgs e)
        {
            TxtBuscar.Text = "";
            Response.Redirect("~/Administracion/Usuarios/ListarUsuarios.aspx");
            BtnListarTodo.Visible = false;
        }
    }
}