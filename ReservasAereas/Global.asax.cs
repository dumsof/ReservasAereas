
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ReservasAereas.Excepciones;
using System.Web.Http;

namespace ReservasAereas
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //permite que se realice la migracion de forma automatica, pasando como parametro el contexto y la clase configuration de la carpeta migrations.
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Models.ReservaAereaContext, Migrations.Configuration>());
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }


        /// <summary>
        /// poder centralizar capturar y enviar errores
        /// </summary>
        /// <param name="filters"></param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new ElmahHandleErrorAttribute());

        }
    }
}
