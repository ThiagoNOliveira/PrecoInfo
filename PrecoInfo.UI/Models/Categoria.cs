using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrecoInfo.UI.Models
{
    public class Categoria
    {
        public string Nome { get; set; }
        public string NomeImagem { get; set; }
        public List<Categoria> SubCategorias { get; set; }
    }
}