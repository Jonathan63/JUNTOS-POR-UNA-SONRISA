using JuntosPorUnaSonrisa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace JuntosPorUnaSonrisa
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);



            BaseDatosEntities bd = new BaseDatosEntities();

            if (bd.USUARIO_SIS.Count() == 0)
            {
                USUARIO_SIS nuevo = new USUARIO_SIS();
                nuevo.USR_ID = "Administrador";
                nuevo.USR_FIRSTNAME = "Administrador";
                nuevo.USR_SECONDNAME = "Administrador";
                nuevo.USR_APELLIDOP = "Administrador";
                nuevo.USR_APELLIDOM = "Administrador";
                nuevo.USR_ESTADO = "A";
                nuevo.USR_ROLES = "A";
                nuevo.USR_CONTRASENA = "JPUSadmin2020";
                bd.USUARIO_SIS.Add(nuevo);
                bd.SaveChanges();
            }
        }
    }
}
