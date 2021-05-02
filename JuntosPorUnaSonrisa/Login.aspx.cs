using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;
using System.Web.Security;

namespace JuntosPorUnaSonrisa
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            USUARIO_SIS u = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID == TxtUsuario.Text);
            if (u != null)
            {
                if (u.USR_CONTRASENA == TxtKey.Text)
                {
                    Session["Administrador"] = u;
                    FormsAuthentication.RedirectFromLoginPage(u.USR_ID, false);

                }
                else if (u.USR_CONTRASENA == TxtKey.Text)
                {
                    Session["Usuario"] = u;
                    FormsAuthentication.RedirectFromLoginPage(u.USR_ID, false);
                }
                else
                {
                    LblError.Text = "Usuario o Contraseña Incorrecto";
                }
            }
            else
            {
                LblError.Text = "Usuario o Contraseña Incorrecto";
            }


        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }

        
    }
}