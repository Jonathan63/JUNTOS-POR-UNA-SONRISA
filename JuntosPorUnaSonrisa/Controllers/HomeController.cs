using JuntosPorUnaSonrisa.Models;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JuntosPorUnaSonrisa.Controllers
{
    public class HomeController : Controller
    {
        BaseDatosEntities bd;
        public HomeController()
        {
            bd = new BaseDatosEntities();
        }
        private string A { get { string parametro = Request.QueryString["A"]; if (string.IsNullOrEmpty(parametro) == true) { return ""; } return parametro; } }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected void Encabezado(string Ficha)
        {
            Models.FICHA_MEDICA fm = bd.FICHA_MEDICA.FirstOrDefault(x => x.ID_FICHA_MEDICA.ToString() == Ficha);
            Models.PERSONA p = bd.PERSONA.FirstOrDefault(x => x.ID_PERSONA.ToString() == fm.ID_PERSONA);


            ViewBag.Nombres = p.PER_APELLIDO_PATERNO + " " + p.PER_APELLIDO_MATERNO + " " + p.PER_NOMBRES;
            ViewBag.Cedula = p.PER_CEDULA.ToString();
            ViewBag.Ficha = Ficha;
        }

        public ActionResult Ficha(string Ficha = "")
        {
            Encabezado(Ficha);
            var Historial = bd.HISTORIAL_FICHA.ToList();
            ViewBag.Listado = Historial;


            var AllHistorias = bd.HISTORIAL_FICHA.Where(x => x.ID_FICHA_MEDICA.ToString() == Ficha).ToList();


            return View(AllHistorias);
        }
        public ActionResult Print()
        {
            ViewBag.Ficha = A;
            return new ActionAsPdf("Ficha", new { Ficha = A })

            { FileName = "Ficha " + A + ".pdf" };
        }
        //public ActionResult GetAll()
        //{
        //    var AllHistorias = bd.HISTORIAL_FICHA.ToList();
        //    return View(AllHistorias);
        //}
        //public ActionResult PrintAll()
        //{
        //    return new ActionAsPdf("GetAll");

        //}
        public ActionResult GetAll(string Ficha="")
        {
            //BaseDatosEntities bd = new BaseDatosEntities();
            //var q = from fm in bd.HISTORIAL_FICHA
            //        where Ficha == fm.ID_FICHA_MEDICA.ToString()
            //        select new
            //        {
            //            fm.FIC_MED_FECHA,
            //            fm.FICHAEXAMENLAVOR,
            //            fm.FICHATERAPEUTA,
            //            fm.FICHADIAGNOSTICO,
            //            fm.FICHACOMENTARIO,
            //            fm.FICHACOMENTMEDICO,
            //            fm.FICHAPADECIMIENTOACT
            //        };
            //q.ToList();
            
            var AllHistorias = bd.HISTORIAL_FICHA.Where(x => x.ID_FICHA_MEDICA.ToString() == Ficha).ToList();


            return View(AllHistorias);
        }
        public ActionResult PrintAll()
        {
            return new ActionAsPdf("GetAll", new { Ficha = A });

        }


    }
}