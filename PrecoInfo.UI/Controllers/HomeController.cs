using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PrecoInfo.UI.Infraestrutura;

namespace PrecoInfo.UI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {

            ViewBag.Clima = ConsumingWeatherJsonWebService.ObterInformacoes();
            
            return View();
        }

    }
}
