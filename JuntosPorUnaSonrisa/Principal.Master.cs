using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using JuntosPorUnaSonrisa.Models;

using System.Security.Principal;

namespace JuntosPorUnaSonrisa
{
    public partial class Principal : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.User != null)
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
                        if (u.USR_ROLES == "A")
                        {
                            Administrador.Visible = true;
                            Publico.Visible = false;
                            return;
                        }
                        else if (u.USR_ROLES == "M")
                        {
                            Medico.Visible = true;
                            Publico.Visible = false;
                            return;
                        }

                        else if (u.USR_ROLES == "O")
                        {
                            Odontologo.Visible = true;
                            Publico.Visible = false;
                            return;
                        }
                        else if (u.USR_ROLES == "X")
                        {
                            TutorM.Visible = true;
                            Publico.Visible = false;
                            return;
                        }

                        else if (u.USR_ROLES == "Y")
                        {
                            TutorO.Visible = true;
                            Publico.Visible = false;
                            return;
                        }

                    }
                }
            }
        }
        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void BtnLogo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }
    }
}