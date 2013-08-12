using PrecoInfo.UI.Models;
using System;
using System.Collections.Generic;
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
            List<Categoria> categorias = new List<Categoria>();

            Categoria categoria1 = new Categoria { Nome = "Computador", NomeImagem = "../Content/ico/cat_computador.png" };

            categoria1.SubCategorias = new List<Categoria>();

            categoria1.SubCategorias.Add(new Categoria { Nome = "Desktops"});
            categoria1.SubCategorias.Add(new Categoria { Nome = "Notebook" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "Netbook" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "Ultrabook" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "iPad/Tablet" });
            categoria1.SubCategorias.Add(new Categoria { Nome = "Acessórios Notebook/Netbook"});

            categorias.Add(categoria1);

            Categoria categoria2 = new Categoria { Nome = "CPU e memória", NomeImagem = "../Content/ico/cat_cpu-memoria.png" };

            categoria2.SubCategorias = new List<Categoria>();

            categoria2.SubCategorias.Add(new Categoria { Nome = "Placas Mãe" });
            categoria2.SubCategorias.Add(new Categoria { Nome = "Processadores" });
            categoria2.SubCategorias.Add(new Categoria { Nome = "Memórias" });
            categoria2.SubCategorias.Add(new Categoria { Nome = "Coolers e Ventiladores" });
            categoria2.SubCategorias.Add(new Categoria { Nome = "Acessórios"});

            categorias.Add(categoria2);

            Categoria categoria3 = new Categoria { Nome = "Armazenamento", NomeImagem = "../Content/ico/cat_armazenamento.png" };

            categoria3.SubCategorias = new List<Categoria>();

            categoria3.SubCategorias.Add(new Categoria { Nome = "Cartões de Memória"});
            categoria3.SubCategorias.Add(new Categoria { Nome = "Discos Rígidos"});
            categoria3.SubCategorias.Add(new Categoria { Nome = "Drives"});
            categoria3.SubCategorias.Add(new Categoria { Nome = "Mídias" });
            categoria3.SubCategorias.Add(new Categoria { Nome = "Pen drives" });

            categorias.Add(categoria3);

            Categoria categoria4 = new Categoria { Nome = "Multimídia", NomeImagem = "../Content/ico/cat_multimidia.png" };

            categoria4.SubCategorias = new List<Categoria>();

            categoria4.SubCategorias.Add(new Categoria { Nome = "Caixas de Som e Webcam" });
            categoria4.SubCategorias.Add(new Categoria { Nome = "Outros" });
            categoria4.SubCategorias.Add(new Categoria { Nome = "Placas de Som e Vídeo" });
            categoria4.SubCategorias.Add(new Categoria { Nome = "Player MP3, MP4, MP..., Ipod" });
            categoria4.SubCategorias.Add(new Categoria { Nome = "Projetores e telas" });

            categorias.Add(categoria4);

            Categoria categoria5 = new Categoria { Nome = "Periféricos", NomeImagem = "../Content/ico/cat_perifericos.png" };

            categoria5.SubCategorias = new List<Categoria>();

            categoria5.SubCategorias.Add(new Categoria { Nome = "Impressoras" });
            categoria5.SubCategorias.Add(new Categoria { Nome = "Monitores/TVs" });
            categoria5.SubCategorias.Add(new Categoria { Nome = "Mouses e Teclados" });
            categoria5.SubCategorias.Add(new Categoria { Nome = "Scanners e Mesas Digitalizadoras" });

            categorias.Add(categoria5);

            Categoria categoria6 = new Categoria { Nome = "Suprimentos", NomeImagem = "../Content/ico/cat_suprimentos.png" };

            categoria6.SubCategorias = new List<Categoria>();

            categoria6.SubCategorias.Add(new Categoria { Nome = "Impressoras" });
            categoria6.SubCategorias.Add(new Categoria { Nome = "Monitores/TVs" });
            categoria6.SubCategorias.Add(new Categoria { Nome = "Mouses e Teclados" });
            categoria6.SubCategorias.Add(new Categoria { Nome = "Scanners e Mesas Digitalizadoras" });

            categorias.Add(categoria6);

            ViewBag.Produtos = categorias;

            return View();
        }

    }
}
