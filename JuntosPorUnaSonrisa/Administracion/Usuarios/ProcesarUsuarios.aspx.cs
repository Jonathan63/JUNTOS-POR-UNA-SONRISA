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
    public partial class ProcesarUsuarios : System.Web.UI.Page
    {
        private string Modo
        {
            get
            {
                string Parametro = Request.QueryString["Modo"];
                if (string.IsNullOrEmpty(Parametro) == true)
                {
                    return "";
                }
                return Parametro;
            }
        }

        private string Cuenta
        {
            get
            {
                string Parametro = Request.QueryString["Cuenta"];
                if (string.IsNullOrEmpty(Parametro) == true)
                {
                    return "";
                }
                return Parametro;
            }
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
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtCuenta.Enabled = false;
            if (ValidarUsuarioRol())
            {
                if (Page.IsPostBack == false)
                {
                    if (Modo != "C" && Modo != "E")
                    {
                        Response.Redirect("~/Administracion/Usuarios/ListarUsuarios.aspx");
                    }
                    //if (Modo == "C" && Modo == "E")
                    //{
                    //    CmbRol.Items.RemoveAt(1);
                    //}
                    //if (HttpContext.Current.User.Identity.IsAuthenticated)
                    //{

                    //    if (HttpContext.Current.User.Identity is FormsIdentity)
                    //    {
                    //        FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
                    //        BaseDatosEntities bd = new BaseDatosEntities();
                    //        USUARIO_SIS u = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID == id.Name);
                    //        string[] roles = new string[] { u.USR_ROLES };
                    //        HttpContext.Current.User = new GenericPrincipal(id, roles);
                    //        if (u.USR_ROLES == "X" && u.USR_ROLES == "Y")
                    //        {
                    //            CmbRol.Items.RemoveAt ('0');
                    //        }


                    //    }

                    //}
                    if (Modo == "E")
                    {

                        BaseDatosEntities bd = new BaseDatosEntities();
                        Models.USUARIO_SIS u = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID == Cuenta);
                        if (u != null)
                        {
                            TxtCuenta.Text = u.USR_ID;
                            TxtFirstName.Text = u.USR_FIRSTNAME;
                            TxtSecondName.Text = u.USR_SECONDNAME;
                            TxtApellidoP.Text = u.USR_APELLIDOP;
                            TxtApellidoM.Text = u.USR_APELLIDOM;
                            TxtCedula.Text = u.USR_CEDULA;
                            CmbRol.SelectedValue = u.USR_ROLES;
                            CmbEstado.SelectedValue = u.USR_ESTADO;


                        }
                        else
                        {
                            Response.Redirect("~/Administracion/Usuarios/ListarUsuarios.aspx");
                        }
                    }

                }
            }
        }


        protected void History(string ID_FICHAMEDICA)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.HISTORIALUSUARIOS hf = new Models.HISTORIALUSUARIOS();
            int cont = bd.HISTORIALUSUARIOS.Count();
            int a = 0;
            int valor = 0;
            do
            {
                Models.HISTORIALUSUARIOS q = bd.HISTORIALUSUARIOS.FirstOrDefault(x => x.ID == cont);

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
            if (Modo == "C")
            {
                hf.ACCION = "Creacion";
            }
            else if (Modo == "E")
            {
                hf.ACCION = "Edicion";
            }

            hf.FECHA = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToString("H:mm:ss");
            hf.USUARIO = u.USR_FIRSTNAME + " " + u.USR_SECONDNAME + " " + u.USR_APELLIDOP + " " + u.USR_APELLIDOM;
            hf.NUMERO = "Usuario ' " + ID_FICHAMEDICA.ToString()+ " '";

            bd.HISTORIALUSUARIOS.Add(hf);
            try
            {
                bd.SaveChanges();
            }
            catch
            {

            }
        }
        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (ValidarUsuario())
                {
                    BaseDatosEntities bd = new BaseDatosEntities();
                    Models.USUARIO_SIS u = new Models.USUARIO_SIS();

                    if (Modo == "E")
                    {
                        u = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID == Cuenta);
                        if (u == null) return;
                    }

                    u.USR_ID = TxtCuenta.Text;
                    u.USR_FIRSTNAME = TxtFirstName.Text;
                    u.USR_SECONDNAME = TxtSecondName.Text;
                    u.USR_APELLIDOP = TxtApellidoP.Text;
                    u.USR_APELLIDOM = TxtApellidoM.Text;
                    u.USR_CEDULA = TxtCedula.Text;
                    u.USR_ROLES = CmbRol.SelectedValue;
                    u.USR_ESTADO = CmbEstado.SelectedValue;


                    if (this.Modo == "C")
                    {
                        //condicionar el manejo de la contrasenha
                        u.USR_CONTRASENA = TxtCedula.Text;
                        bd.USUARIO_SIS.Add(u);
                    }
                    try
                    {
                        History(TxtCuenta.Text);
                        bd.SaveChanges();
                        Response.Redirect("~/Administracion/Usuarios/ListarUsuarios.aspx");
                    }
                    catch (Exception ex)
                    {
                        YaExiste();
                    }
                }
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Administracion/Usuarios/ListarUsuarios.aspx");
        }
        
        protected bool ValidarCampos()
        {
            if (TxtFirstName.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Validacion','El Primer Nombre es Requerido','error',) </script>");
                return false;
            }
            if (TxtSecondName.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Validacion','El Segundo Nombre es Requerido','error',) </script>");
                return false;
            }
            if (TxtApellidoP.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Validacion','El Apellido Paterno es Requerido','error',) </script>");
                return false;
            }
            if (TxtApellidoM.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Validacion','El Apellido Materno es Requerido','error',) </script>");
                return false;
            }
            if (TxtCedula.Text.Length < 10 && TxtCedula.Text.Length > 10)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Validacion','La Cedula debe contener unicamente 10 caracteres','error',) </script>");
                return false;
            }
            if (TxtCedula.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Validacion','La Cedula es de caracter obligatorio','error',) </script>");
                return false;
            }


            return true;

        }
        public bool ValidarUsuario()
        {
            if (TxtCuenta.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Validacion','Debera Crear el Usuario','error',) </script>");
                return false;
            }
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {

                if (HttpContext.Current.User.Identity is FormsIdentity)
                {
                    FormsIdentity id = (FormsIdentity)HttpContext.Current.User.Identity;
                    BaseDatosEntities bd = new BaseDatosEntities();
                    USUARIO_SIS u = bd.USUARIO_SIS.FirstOrDefault(x => x.USR_ID == id.Name);
                    string[] roles = new string[] { u.USR_ROLES };
                    HttpContext.Current.User = new GenericPrincipal(id, roles);
                    if (u.USR_ROLES == "X" && u.USR_ROLES == "Y" || CmbRol.SelectedValue == "A")
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Error','No Puede crear un usuario Administrador','error',) </script>");
                        return false;
                    }


                }

            }

            return true;
        }
        private void YaExiste()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El Usuario " + TxtCuenta.Text + " ?','Ya Existe','error',) </script>");


        }

        protected void BtnGenerarUsu_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                TxtCuenta.Text = ((TxtFirstName.Text[0]).ToString() + (TxtSecondName.Text[0]).ToString() + TxtApellidoP.Text + TxtApellidoM.Text[0]).ToLower() + TxtCedula.Text[8] + TxtCedula.Text[9];
            }
        }
    }
}