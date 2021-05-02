using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.FichaOdontologica
{
    public partial class Odont : System.Web.UI.Page
    {
        protected void AutoNumerar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            int cont = 1;



            int a = 0;
            do
            {
                Models.ODONTOGRAMA q = bd.ODONTOGRAMA.FirstOrDefault(x => x.IDDIENTE.ToString() == cont.ToString() && FO == x.ID_ODONTO.ToString());

                if (q != null)
                {
                    cont = cont + 1;
                    LblNHistorial.Text = cont.ToString();
                    a = 1;

                }
                else if (q == null)
                {
                    if (cont == 0)
                    {
                        cont = cont + 1;
                        LblNHistorial.Text = cont.ToString();
                        a = 2;
                    }
                    else if (cont != 0)
                    {
                        LblNHistorial.Text = cont.ToString();
                        a = 2;

                    }
                }

            } while (a != 2);
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

        private string FO { get { string parametro = Request.QueryString["FO"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private void Recuperar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_ODONTOLOGICA pk = bd.FICHA_ODONTOLOGICA.FirstOrDefault(x => x.ID_ODONTO.ToString() == FO);
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == pk.ID_PERSONA);
            LblFichaMedica.Text = "Nº Ficha Odontologica: " + FO;
            LblPersona.Text = "Cedula: " + p.PER_CEDULA;
            LblPerNombres.Text = "Nombre: " + p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.ODONTOGRAMA p = bd.ODONTOGRAMA.FirstOrDefault(x => x.IDDIENTE.ToString() == R && x.ID_ODONTO.ToString() == FO);
                if (Modo != "E" && Modo != "C")
                {
                    Response.Redirect("~/Sistema/FichaOdontologica/ListarDiagnostico.aspx");
                }
                if (Modo == "C")
                {
                    AutoNumerar();
                    Recuperar();
                }
                if (Modo == "E")
                {

                    Recuperar();
                    if (p != null)
                    {
                        LblNHistorial.Text = p.IDDIENTE.ToString();
                        CmbDiente.SelectedValue = p.NDIENTE;
                        CmbEnfermedades.SelectedItem.Text = p.ENFERMEDAD;
                        TxtEnfermedad.InnerText = p.DESCRIPCION;


                    }
                    else
                    {
                        Response.Redirect("~/Sistema/FichaOdontologica/ListarOdontograma.aspx");
                    }
                }


            }

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.ODONTOGRAMA p = new Models.ODONTOGRAMA();

            if (Modo == "E")
            {
                p = bd.ODONTOGRAMA.FirstOrDefault(x => x.IDDIENTE.ToString() == LblNHistorial.Text && x.ID_ODONTO.ToString() == FO);
                if (p == null) return;
            }

            p.ID_ODONTO = int.Parse(FO);
            p.NDIENTE = CmbDiente.SelectedValue;
            p.DESCRIPCION = TxtEnfermedad.InnerText;
            p.IDDIENTE = int.Parse(LblNHistorial.Text);
            p.ENFERMEDAD = CmbEnfermedades.SelectedItem.ToString();


            if (this.Modo == "C") bd.ODONTOGRAMA.Add(p);
            try
            {
                bd.SaveChanges();
                Response.Redirect("~/Sistema/FichaOdontologica/ListarOdontograma.aspx?FO=" + FO);
            }
            catch (Exception ex)
            {
                Existe();
            }
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/FichaOdontologica/ListarOdontograma.aspx?FO=" + FO);
        }
        private void Existe()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya existe un Para este numero de diente')</script>");

        }

       
    }
}