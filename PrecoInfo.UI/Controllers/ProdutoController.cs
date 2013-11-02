using PrecoInfo.Domain.ComponenteProduto;
using PrecoInfo.UI.Models;
using ProcuraFacil.Core.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrecoInfo.UI.Controllers
{
    public class ProdutoController : Controller
    {
        //
        // GET: /Produto/

        public ActionResult Index()
        {
            var repoCategorias = new Repositorio<Categoria>();

            var categorias = repoCategorias.Todas().ToList().Where(x => x.SubCategorias.Count >0);

            ViewBag.Categorias = categorias.OrderBy(x => x.Ordem);

            return View();
        }

    }
}
