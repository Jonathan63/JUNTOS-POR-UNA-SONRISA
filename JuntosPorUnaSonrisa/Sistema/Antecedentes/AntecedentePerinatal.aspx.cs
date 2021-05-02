using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Antecedentes
{
    public partial class AntecedentePerinatal : System.Web.UI.Page
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
        private string FM { get { string parametro = Request.QueryString["FM"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private void Recuperar()
        {
            BaseDatosEntities bd = new BaseDatosEntities();
            Models.FICHA_MEDICA pk = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == pk.ID_PERSONA);
            LblFichaMedica.Text = "Nº Ficha Medica: " + FM;
            LblPersona.Text = "Cedula: " + p.PER_CEDULA;
            LblPerNombres.Text = "Nombre: " + p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.ANTECEDENTE_PERINATAL p = bd.ANTECEDENTE_PERINATAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);

                if (Modo != "C" && Modo != "E")
                {
                    Response.Redirect("~/Sistema/Antecedentes/ListarAntecedentePerinatal.aspx");
                }
                if (Modo == "C")
                {
                    Recuperar();

                }

                if (Modo == "E")
                {
                    if (p != null)
                    {
                        Recuperar();
                        CmbNumEmbarazo.SelectedValue = p.ANT_NUMERO_EMBARAZO.ToString();
                        ChkEmbarazoMult.SelectedValue = p.ANT_EMBARAZO_MULTIPLE;
                        ChkTomaMedic.SelectedValue = p.ANT_TOMA_MEDICAMENTOS;
                        TxtQueMedicamento.Text = p.ANT_QUE_MEDICAMENTOS;
                        ChkTomaVitam.SelectedValue = p.ANT_TOMA_VITAMINAS;
                        TxtQueVitaminas.Text = p.ANT_QUE_VITAMINAS;
                        TxtDurEmbarazo.Text = p.ANT_DURACION_EMBARAZO;
                        TxtFumoTomo.Text = p.ANT_FUMO_TOMO;
                        ChkPartoNorm.SelectedValue = p.ANT_PARTO_NORMAL;
                        TxtObsParto.Text = p.ANT_OBSERVACION_PARTO;
                        TxtPeso.Text = p.ANT_PESO;
                        TxtTalla.Text = p.ANT_TALLA;
                        TxtPerCfalico.Text = p.ANT_PERIMETRO_CEFALICO;
                        ChkTamizMeta.SelectedValue = p.ANT_TAMIZ_METABOLICO;
                        ChkTamizAudi.SelectedValue = p.ANT_TAMIZ_AUDITIVO;
                        ChkComplicParto.SelectedValue = p.ANT_PARTO_COMPLICACION;
                        TxtComParto.Text = p.ANT_OBSERVACION_COMP_PARTO;
                        ChkTomoSeno.SelectedValue = p.ANT_TOMO_SENO_MATERNO;
                        TxtTiempoSeno.Text = p.ANT_TIEMPO_SENO;
                        ChkTomoFormula.SelectedValue = p.ANT_TOMO_FORMULA;
                        TxtTomoFormula.Text = p.ANT_QUE_FORMULA;
                    }
                    else
                    {
                        Response.Redirect("~/Sistema/Ficha_Medica/ListarFichaMedica.aspx");
                    }
                }
            }

        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                BaseDatosEntities bd = new BaseDatosEntities();
                Models.ANTECEDENTE_PERINATAL p = new Models.ANTECEDENTE_PERINATAL();

                if (Modo == "E")
                {
                    p = bd.ANTECEDENTE_PERINATAL.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == FM);
                    if (p == null) return;
                }

                p.ID_FICHA_MEDICA = int.Parse(FM);
                p.ANT_NUMERO_EMBARAZO = CmbNumEmbarazo.SelectedValue;
                p.ANT_EMBARAZO_MULTIPLE = ChkEmbarazoMult.SelectedValue;
                p.ANT_TOMA_MEDICAMENTOS = ChkTomaMedic.SelectedValue;
                p.ANT_QUE_MEDICAMENTOS = TxtQueMedicamento.Text;
                p.ANT_TOMA_VITAMINAS = ChkTomaVitam.SelectedValue;
                p.ANT_QUE_VITAMINAS = TxtQueVitaminas.Text;
                p.ANT_DURACION_EMBARAZO = TxtDurEmbarazo.Text;
                p.ANT_FUMO_TOMO = TxtFumoTomo.Text;
                p.ANT_PARTO_NORMAL = ChkPartoNorm.SelectedValue;
                p.ANT_OBSERVACION_PARTO = TxtObsParto.Text;
                p.ANT_PESO = TxtPeso.Text;
                p.ANT_TALLA = TxtTalla.Text;
                p.ANT_PERIMETRO_CEFALICO = TxtPerCfalico.Text;
                p.ANT_TAMIZ_METABOLICO = ChkTamizMeta.SelectedValue;
                p.ANT_TAMIZ_AUDITIVO = ChkTamizAudi.SelectedValue;
                p.ANT_PARTO_COMPLICACION = ChkComplicParto.SelectedValue;
                p.ANT_OBSERVACION_COMP_PARTO = TxtComParto.Text;
                p.ANT_TOMO_SENO_MATERNO = ChkTomoSeno.SelectedValue;
                p.ANT_TIEMPO_SENO = TxtTiempoSeno.Text;
                p.ANT_TOMO_FORMULA = ChkTomoFormula.SelectedValue;
                p.ANT_QUE_FORMULA = TxtTomoFormula.Text;

                if (this.Modo == "C") bd.ANTECEDENTE_PERINATAL.Add(p);
                try
                {
                    bd.SaveChanges();
                    Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
                }
                catch (Exception ex)
                {
                    Existe();
                }
            }
        }
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Sistema/Ficha_Medica/FichaMedica.aspx?Modo=E&FM=" + FM);
        }
        private bool ValidarCampos()
        {
            if (ChkTomaMedic.SelectedValue == "N" && TxtQueMedicamento.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo MEDICAMENTO debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkTomaMedic.SelectedValue == "S" && TxtQueMedicamento.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo MEDICAMENTO no debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkTomaVitam.SelectedValue == "N" && TxtQueVitaminas.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo VITAMINA debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkTomaVitam.SelectedValue == "S" && TxtQueVitaminas.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo VITAMINA no debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkComplicParto.SelectedValue == "N" && TxtComParto.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo COMPLICACION debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkComplicParto.SelectedValue == "S" && TxtComParto.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo COMPLICACION no debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkTomoSeno.SelectedValue == "N" && TxtTiempoSeno.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo TIEMPO DE SENO debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkTomoSeno.SelectedValue == "S" && TxtTiempoSeno.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo TIEMPO DE SENO no debe estar vacio','warning')</script>");
                return false;
            }
            if (ChkTomoFormula.SelectedValue == "N" && TxtTomoFormula.Text != "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar NO','El Campo FORMULA debe estar vacio','warning')</script>");
                return false;
            }
            else if (ChkTomoFormula.SelectedValue == "S" && TxtTomoFormula.Text == "")
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Al Seleccionar SI','El Campo FORMULA no debe estar vacio','warning')</script>");
                return false;
            }

            

            return true;
        }
        private void Existe()
        {
            ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> Swal.fire('Ya existe un registro con esta Especificacion')</script>");
        }



    }
}