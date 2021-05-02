using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Personas
{
    public partial class ProcesarPersonas : System.Web.UI.Page
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
        private string ID_PERSONA
        {
            get
            {
                string Parametro = Request.QueryString["ID_PERSONA"];
                if (string.IsNullOrEmpty(Parametro) == true)
                {
                    return "";
                }
                return Parametro;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)
            {
                if (Modo != "C" && Modo != "E")
                {
                    Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx");
                }
                if(Modo == "C")
                {
                    BtnGenerar_Click(sender, e);
                }
                if (Modo == "E")
                {
                    BaseDatosEntities bd = new BaseDatosEntities();
                    Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == ID_PERSONA);
                    if (p != null)
                    {
                        TxtIdentificador.Text = p.ID_PERSONA.ToString();
                        TxtIDPersona.Text = p.PER_CEDULA.ToString();
                        TxtApellidoP.Text = p.PER_APELLIDO_PATERNO;
                        TxtApellidoM.Text = p.PER_APELLIDO_MATERNO;
                        TxtNombres.Text = p.PER_NOMBRES;
                        TxtEdad.Text = p.PER_EDAD;
                        CmbGenero.SelectedValue = p.PER_SEXO;
                        TxtReligion.Text = p.PER_RELIGION;
                        TxtMedicoT.Text = p.PER_MEDICO_TRATANTE;
                        TxtNombresM.Text = p.PER_NOMBRE_MADRE;
                        TxtEdadM.Text = p.EDAD_MADRE;
                        TxtNombresP.Text = p.PER_NOMBRE_PADRE;
                        TxtEdadP.Text = p.PER_EDAD_PADRE;
                        
                        //TxtIDPersona.Enabled = false;
                        BtnGenerar.Visible = false;
                        if (p.EDAD_MADRE.ToString() == "0") TxtEdadM.Text = "";
                        if (p.PER_EDAD_PADRE.ToString() == "0") TxtEdadP.Text = "";

                    }
                    else
                    {
                        Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx");
                    }
                }
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (R == "3")
            {
                Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
            }
            else if (R == "4")
            {
                Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
            }
            else
            {
                Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx?&FM=" + FM + "&R=" + R);
            }
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtEdadM.Text == "") TxtEdadM.Text = "0";
            if (TxtEdadP.Text == "") TxtEdadP.Text = "0";
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.PERSONA p = new Models.PERSONA();

                if (Modo == "E")
                {
                    p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == ID_PERSONA);
                    if (p == null) return;

                }

                p.ID_PERSONA = TxtIdentificador.Text;
                p.PER_APELLIDO_PATERNO = TxtApellidoP.Text;
                p.PER_APELLIDO_MATERNO = TxtApellidoM.Text;
                p.PER_NOMBRES = TxtNombres.Text;
                p.PER_EDAD = TxtEdad.Text;
                p.PER_SEXO = CmbGenero.SelectedValue;
                p.PER_RELIGION = TxtReligion.Text;
                p.PER_MEDICO_TRATANTE = TxtMedicoT.Text;
                p.PER_NOMBRE_MADRE = TxtNombresM.Text;
                p.EDAD_MADRE = TxtEdadM.Text;
                p.PER_NOMBRE_PADRE = TxtNombresP.Text;
                p.PER_EDAD_PADRE = TxtEdadP.Text;
                p.PER_CEDULA = TxtIDPersona.Text;
                if (this.Modo == "C") bd.PERSONA.Add(p);

                try
                {
                    bd.SaveChanges();
                    if(R == "3")
                    {
                        Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
                    }
                    else if (R == "4")
                    {
                        Response.Redirect("~/Sistema/FichaOdontologica/FichaOdontologica.aspx?Modo=E&FO=" + FO);
                    }
                    else 
                    {
                        Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx?&FM=" + FM + "&R=" + R);
                    }
                    
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('" + TxtIdentificador.Text + " ?','Ya existe un registro con esta identificacion','error') </script>");
                    TxtIDPersona.Text = "";

                }
            }

        }

        private string A { get { string parametro = Request.QueryString["A"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string FM { get { string parametro = Request.QueryString["FM"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string FO { get { string parametro = Request.QueryString["FO"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }

        private bool ValidarCampos()
        {
            //if (TxtIDPersona.Text.Length < 10 || TxtIDPersona.Text.Length > 10)
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Validacion','El ID Debe contener 10 caracteres','error',) </script>");
            //    return false;
            //}

            //if (TxtIDPersona.Text.Trim() == "")
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('La " + LblIDPersona.Text + " es Requerida')</script>");
            //    ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "CambiarColor();", true);
            //    return false;
            //}
            if (TxtApellidoP.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El Apellido Paterno es Necesario.')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "CambiarColor();", true);
                return false;
            }
            if (TxtApellidoM.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El Apellido Materno es requerido.')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "CambiarColor();", true);
                return false;
            }
            if (TxtNombres.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Los Nombres son requeridos.')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "CambiarColor();", true);
                return false;
            }

            if (TxtEdad.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('La edad es Requerida.')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "CambiarColor();", true);
                return false;
            }
            return true;
        }

        protected void BtnGenerar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            int cont = bd.PERSONA.Count();

            BtnGenerar.Visible = false;


            int a = 0;
            do
            {
                Models.PERSONA q = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == cont.ToString());

                if (q != null)
                {
                    cont = cont + 1;
                    TxtIdentificador.Text = cont.ToString();
                    a = 1;
                }
                else if (q == null)
                {
                    if (cont == 0)
                    {
                        cont = cont + 1;
                        TxtIdentificador.Text = cont.ToString();
                        a = 2;
                    }
                    else if (cont != 0)
                    {
                        TxtIdentificador.Text = cont.ToString();
                        a = 2;
                    }
                }

            } while (a != 2);

        }
    }


}