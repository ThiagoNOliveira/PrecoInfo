using System.Web.Mvc;
using System.Web.Routing;

namespace PrecoInfo.UI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "EsqueciMinhaSenha",
                url: "esqueci-minha-senha",
                defaults: new { controller = "Usuario", action = "EsqueciMinhaSenha" });

            routes.MapRoute(
                name: "Cadastro",
                url: "cadastro",
                defaults: new { controller = "Usuario", action = "Index" });


            routes.MapRoute(
                name: "Cadastrar",
                url: "cadastrar/{action}",
                defaults: new { controller = "Usuario" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}