using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JuntosPorUnaSonrisa.Models;

namespace JuntosPorUnaSonrisa.Sistema.Brigada
{
    public partial class ListarMedico : System.Web.UI.Page
    {
        private string F { get { string parametro = Request.QueryString["F"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        private string R { get { string parametro = Request.QueryString["R"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        //protected void DisplayData()
        //{
        //    BaseDatosEntities bd = new BaseDatosEntities();
        //    var q = from H in bd.HORARIO
        //            join M in bd.MEDICO
        //            on H.HORA_ID equals M.HORA_ID
        //            join E in bd.ESPECIALIDAD
        //            on M.MED_ESPECIALIDAD equals E.TCON_ID
                    
        //            select new
        //            {

        //                M.MED_ID,
        //                M.MED_NOMBRE,
        //                M.MED_APELLIDO,
        //                E.TCON_NOMBRE,
        //                H.HORA_DIAS

        //            }

        //            ;

        //    GriListado.DataSource = q.ToList();
        //    GriListado.DataBind();
        //}
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNuevo_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}