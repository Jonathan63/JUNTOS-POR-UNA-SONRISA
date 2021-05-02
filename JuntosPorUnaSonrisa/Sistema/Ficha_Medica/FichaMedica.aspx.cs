using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;
using System.Web.Security;


using Rotativa;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using System.Web.Mvc;

namespace JuntosPorUnaSonrisa.Sistema.Ficha_Medica
{
    public partial class FichaMedica : System.Web.UI.Page
    {
        private bool ValidarCampos()
        {
            if (TxtFichaMedica.Text.Trim() == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('El numero de ficha medica es Requerida')</script>");
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "CambiarColor();", true);
                return false;
            }
            return true;
        }

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
        protected void History(string ID_FICHAMEDICA)
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
            hf.NUMERO = "Ficha Nº " + ID_FICHAMEDICA.ToString();

            bd.HISTORIALFICHASCEE.Add(hf);
            try
            {
                bd.SaveChanges();
            }
            catch
            {

            }
        }
        private void ActivarDesactivarFM(char Modo)
        {
            if (Modo == 'C')
            {

                TxtFechaFM.Text = DateTime.Today.ToString("dd/MM/yyyy");
                TxtFechaFM.Enabled = false;
                TxtPersona.Enabled = false;
                BtnBuscarP.Visible = false;
                BtnAceptar.Visible = false;
                BtnEditarPersona.Visible = false;

                ContenidoEdicion.Visible = false;
                Padecimientos.Visible = false;
            }
            if (Modo == 'E')
            {
                TxtFechaFM.Text = DateTime.Today.ToString("dd/MM/yyyy");
                TxtFechaFM.Enabled = false;
                TxtPersona.Enabled = false;
                BtnBuscarP.Visible = false;
                BtnGenerar.Visible = false;
                TxtFichaMedica.Enabled = false;
                BtnBuscarFM.Visible = false;

                Padecimientos.Visible = false;
                AgregarListar.Visible = true;
                ListarHistorial.Visible = true;
                DisplayData();



            }


        }
        private void YaExiste()
        {

            BtnAceptar.Visible = false;
            BtnCancelar.Text = "Limpiar Datos";

        }
        protected void Recuperar()
        {
            BaseDatosEntities bds = new BaseDatosEntities();
            Models.FICHA_MEDICA fm = bds.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
            Models.PERSONA p = bds.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == fm.ID_PERSONA);
            LblPerNombres.Text = p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;
            TxtFichaMedica.Text = fm.ID_FICHA_MEDICA.ToString();
            TxtPersona.Text = p.ID_PERSONA;
            TxtCedula.Text = p.PER_CEDULA;

        }
        protected void Recuperar1()
        {
            BaseDatosEntities bds = new BaseDatosEntities();
            Models.FICHA_MEDICA fm = bds.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
            Models.PERSONA p = bds.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == A);
            LblPerNombres.Text = p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;
            TxtFichaMedica.Enabled = false;
            BtnBuscarFM.Visible = false;
            BtnGenerar.Visible = false;
            TxtFichaMedica.Text = FM;
            TxtPersona.Text = A;
            TxtCedula.Text = p.PER_CEDULA;
            BtnBuscarP.Visible = true;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Modo != "C" && Modo != "E")
            {
                Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx");
            }
            if (Modo == "C")
            {
                ActivarDesactivarFM('C');


                if (FM != "")
                {
                    Recuperar1();
                    ValidacionPersona();
                }

            }

            if (Modo == "E")
            {
                if (Page.IsPostBack == false)
                {
                    ActivarDesactivarFM('E');
                    BaseDatosEntities bd = new BaseDatosEntities();
                    Models.FICHA_MEDICA p = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (p != null)
                    {
                        Recuperar();


                    }
                }
            }

        }


        private string A { get { string parametro = Request.QueryString["A"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string FM { get { string parametro = Request.QueryString["FM"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (Modo == "C" && TxtPersona.Text != "" && TxtFichaMedica.Text != "") Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=C");
            else Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx?");
        }
        protected void BtnAceptar_Click(object sender, EventArgs e)
        {

            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA p = new Models.FICHA_MEDICA();
            //Models.FICHA_MEDICA per = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_PERSONA == TxtPersona.Text);
            if (Modo == "E")
            {
                p = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM || x.ID_PERSONA.ToString() == A);
                if (p == null) return;
            }

            p.ID_FICHA_MEDICA = int.Parse(FM);
            p.ID_PERSONA = TxtPersona.Text;

            if (this.Modo == "C") bd.FICHA_MEDICA.Add(p);
            try
            {
                History(TxtFichaMedica.Text);
                bd.SaveChanges();
                if (Modo == "C")
                {
                    Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + TxtFichaMedica.Text);

                }
                if (Modo == "E")
                {
                    Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx");
                }


            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya existe un registro con estas caracteristicas') </script>");
                YaExiste();
            }

        }
        protected void BtnBuscarP_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/Personas/ListarPersonas.aspx?&FM=" + TxtFichaMedica.Text + "&R=" + 1);
        }
        protected void BtnAntcFamiliar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentesFamiliares.aspx?FM=" + TxtFichaMedica.Text + "&R=" + 1);
        }

        protected void BtnVacuna_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.VACUNA v = bd.VACUNA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/Vacunas.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/Vacunas.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnExploracionFis_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.EXPLORACION_FISICA v = bd.EXPLORACION_FISICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/ExploracionFisica.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/ExploracionFisica.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnAntcPerinatal_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ANTECEDENTE_PERINATAL v = bd.ANTECEDENTE_PERINATAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedentePerinatal.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedentePerinatal.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnPsicomotor_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.DESARROLLO_PSICOMOTOR v = bd.DESARROLLO_PSICOMOTOR.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/DesarrolloSicomotor.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/DesarrolloSicomotor.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnQuirurgico_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ANTECEDENTE_QUIRURGICO v = bd.ANTECEDENTE_QUIRURGICO.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteQuirurgico.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteQuirurgico.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnAntcNeuropsico_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ANTECEDENTE_NEUROPSICOLOGICO v = bd.ANTECEDENTE_NEUROPSICOLOGICO.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedentesNeuropsicologico.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedentesNeuropsicologico.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnValoracionFunc_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.VALORACION_FUNCIONAL v = bd.VALORACION_FUNCIONAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/ValoracionFuncional.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/ValoracionFuncional.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnAntcNutricional_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ANTECEDENTE_NUTRICIONAL v = bd.ANTECEDENTE_NUTRICIONAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteNutricional.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Antecedentes/AntecedenteNutricional.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnIntAparSis_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.INT_APARATO_SISTEMA v = bd.INT_APARATO_SISTEMA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (v != null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica/AparatoSistema.aspx?Modo=E&FM=" + FM);
            }
            if (v == null)
            {
                Response.Redirect("~/Sistema/Ficha_Medica//AparatoSistema.aspx?Modo=C&FM=" + FM);
            }
        }

        protected void BtnBuscarFM_Click(object sender, ImageClickEventArgs e)
        {
            if (ValidarCampos())
            {
                Validacion();
            }
        }
        protected void Validacion()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA p = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == TxtFichaMedica.Text);
            if (p != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Registro Existente','Ya existe un registro con esta especificacion','error',) </script>");
                YaExiste();
            }
            else if (p == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Registro Inexistente','Puede Continuar con la creación','success',) </script>");
                BtnBuscarP.Visible = true;
                BtnBuscarFM.Visible = false;
                BtnGenerar.Visible = false;
            }

        }
        protected void ValidacionPersona()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA per = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_PERSONA == TxtPersona.Text);
            if (per != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('" + LblPerNombres.Text + " ?','Ya tiene asignada una ficha medica','error',) </script>");
                YaExiste();
                BtnAceptar.Visible = false;
            }
            else BtnAceptar.Visible = true;
        }


        protected void BtnGenerar_Click(object sender, ImageClickEventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA p = new Models.FICHA_MEDICA();
            int cont = bd.FICHA_MEDICA.Count();
            BtnBuscarP.Visible = true;
            BtnGenerar.Visible = false;
            BtnBuscarFM.Visible = false;

            int a = 0;
            do
            {
                Models.FICHA_MEDICA q = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA == cont);

                if (q != null)
                {
                    cont = cont + 1;
                    TxtFichaMedica.Text = cont.ToString();
                    a = 1;
                }
                else if (q == null)
                {
                    if (cont == 0)
                    {
                        cont = cont + 1;
                        TxtFichaMedica.Text = cont.ToString();
                        a = 2;
                    }
                    else if (cont != 0)
                    {
                        TxtFichaMedica.Text = cont.ToString();
                        a = 2;
                    }
                }

            } while (a != 2);




        }

        protected void BtnEditarPersona_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/Sistema/Personas/ProcesarPersonas.aspx?Modo=E&ID_PERSONA=" + TxtPersona.Text + "&R=" + 3 + "&FM=" + FM);
        }

       




        protected void DisplayData()
        {

            BaseDatosEntities bd = new BaseDatosEntities();
            var q = from fm in bd.HISTORIAL_FICHA
                    where FM == fm.ID_FICHA_MEDICA.ToString()
                    select new
                    {
                        fm.ID_HISTORIAL,
                        fm.FIC_MED_FECHA,
                        fm.FICHAPADECIMIENTOACT

                    };
            GriListado.DataSource = q.ToList();
            GriListado.DataBind();
        }

        protected void GriListado_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {
                ListarHistorial.Visible = false;
                Padecimientos.Visible = true;
                Botones.Visible = false;
                Botones1.Visible = true;
                RecuperarHistoria(e.CommandArgument.ToString());


            }
            else if (e.CommandName == "Borrar")
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "abrir();", true);
                LblEstado.Text = e.CommandArgument.ToString();


            }
        }
        protected void RecuperarHistoria(string v)
        {
            BaseDatosEntities bds = new BaseDatosEntities();
            Models.HISTORIAL_FICHA p = bds.HISTORIAL_FICHA.FirstOrDefault(x => x.ID_HISTORIAL.ToString() == v && x.ID_FICHA_MEDICA.ToString() == FM);
            if (p != null)
            {
                LblNumeroH.Text = p.ID_HISTORIAL.ToString();
                LblFechaH.Text = p.FIC_MED_FECHA.ToString();
                TxtExamenLab.InnerText = p.FICHAEXAMENLAVOR;
                TxtTerapeutica.InnerText = p.FICHATERAPEUTA;
                CmbDiagnostico.SelectedItem.Text = p.FICHADIAGNOSTICO;
                TxtComentarios.InnerText = p.FICHACOMENTARIO;
                TxtComMedicoTrat.InnerText = p.FICHACOMENTMEDICO;
                TxtPadecimientoActual.InnerText = p.FICHAPADECIMIENTOACT;

            }

        }
        protected void GriListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GriListado.PageIndex = e.NewPageIndex;
            DisplayData();
        }
        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {
            ListarHistorial.Visible = false;
            Padecimientos.Visible = true;
            BtnNuevo.Enabled = false;
            BtnListar.Enabled = true;
            AutoNumerar();
            Botones.Visible = false;
            Botones1.Visible = true;
        }

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            ListarHistorial.Visible = true;
            Padecimientos.Visible = false;
            BtnListar.Enabled = false;
            BtnNuevo.Enabled = true;
            DisplayData();
            Botones.Visible = true;
            Botones1.Visible = false;
        }
        protected void BtnCancelar1_Click(object sender, EventArgs e)
        {
            BtnListar_Click(sender, e);
            TxtPadecimientoActual.InnerText = "";
            TxtExamenLab.InnerText = "";
            TxtTerapeutica.InnerText = "";
            //TxtDiagnostico.InnerText = "";
            TxtComentarios.InnerText = "";
            TxtComMedicoTrat.InnerText = "";
        }



        protected void AutoNumerar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            int cont = 1;



            int a = 0;
            do
            {
                Models.HISTORIAL_FICHA q = bd.HISTORIAL_FICHA.FirstOrDefault(x => x.ID_HISTORIAL.ToString() == cont.ToString() && FM == x.ID_FICHA_MEDICA.ToString());

                if (q != null)
                {
                    cont = cont + 1;
                    LblNumeroH.Text = cont.ToString();

                    LblFechaH.Text = DateTime.Today.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("H:mm:ss");
                    a = 1;

                }
                else if (q == null)
                {
                    if (cont == 0)
                    {
                        cont = cont + 1;
                        LblNumeroH.Text = cont.ToString();

                        LblFechaH.Text = DateTime.Today.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("H:mm:ss");
                        a = 2;
                    }
                    else if (cont != 0)
                    {
                        LblNumeroH.Text = cont.ToString();

                        LblFechaH.Text = DateTime.Today.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("H:mm:ss");
                        a = 2;

                    }
                }

            } while (a != 2);
        }

        protected void BtnCancelarE_Click(object sender, EventArgs e)
        {

            LblEstado.Text = "";
        }

        protected void BtnAceptarE_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            //Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx?S=" + 1);
            Models.HISTORIAL_FICHA p = bd.HISTORIAL_FICHA.FirstOrDefault(x => x.ID_HISTORIAL.ToString() == LblEstado.Text);



            if (p != null)
            {
                bd.HISTORIAL_FICHA.Remove(p);

                try
                {

                    bd.SaveChanges();
                    //Las siguientes 3 lineas sirve para refrescar la grilla
                    DisplayData();
                    ScriptManager.RegisterStartupScript(this, GetType(), "mykey", "Eliminado();", true);
                    LblEstado.Text = "";
                }
                catch (Exception ex)
                {
                    Response.Write(ex.Message);
                }
            }
        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            BaseDatosEntities bd = new BaseDatosEntities();
            Models.HISTORIAL_FICHA p = new Models.HISTORIAL_FICHA();
            Models.HISTORIAL_FICHA a = new Models.HISTORIAL_FICHA();
            p = bd.HISTORIAL_FICHA.FirstOrDefault(x => x.ID_HISTORIAL.ToString() == LblNumeroH.Text && x.ID_FICHA_MEDICA.ToString() == FM);
            if (p != null)
            {
                p.ID_HISTORIAL = int.Parse(LblNumeroH.Text);
                p.ID_FICHA_MEDICA = int.Parse(FM);
                p.FIC_MED_FECHA = DateTime.Parse(LblFechaH.Text);
                p.FICHAEXAMENLAVOR = TxtExamenLab.InnerText;
                p.FICHATERAPEUTA = TxtTerapeutica.InnerText;
                p.FICHADIAGNOSTICO = CmbDiagnostico.SelectedItem.ToString();
                p.FICHACOMENTARIO = TxtComentarios.InnerText;
                p.FICHACOMENTMEDICO = TxtComMedicoTrat.InnerText;
                p.FICHAPADECIMIENTOACT = TxtPadecimientoActual.InnerText;
                try
                {

                    bd.SaveChanges();
                    BtnListar_Click(sender, e);
                    enserar();

                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('No se registran cambios') </script>");
                    
                }
            }
            else
            {

                a.ID_HISTORIAL = int.Parse(LblNumeroH.Text);
                a.ID_FICHA_MEDICA = int.Parse(FM);
                a.FIC_MED_FECHA = DateTime.Parse(LblFechaH.Text);
                a.FICHAEXAMENLAVOR = TxtExamenLab.InnerText;
                a.FICHATERAPEUTA = TxtTerapeutica.InnerText;
                a.FICHACOMENTARIO = TxtComentarios.InnerText;
                a.FICHADIAGNOSTICO = CmbDiagnostico.SelectedItem.ToString();
                a.FICHACOMENTMEDICO = TxtComMedicoTrat.InnerText;
                a.FICHAPADECIMIENTOACT = TxtPadecimientoActual.InnerText;

                bd.HISTORIAL_FICHA.Add(a);
                try
                {

                    bd.SaveChanges();
                    BtnListar_Click(sender, e);
                    enserar();

                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('No se registran cambios') </script>");
                    
                }
            }

        }
        private void enserar()
        {
            LblNumeroH.Text = "";
            LblFechaH.Text = "";
            TxtExamenLab.InnerText = "";
            TxtTerapeutica.InnerText = "";
            TxtComentarios.InnerText = "";
            //TxtDiagnostico.InnerText = "";
            TxtComMedicoTrat.InnerText = "";
            TxtPadecimientoActual.InnerText = "";

        }
        

        
    }
}