using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrecoInfo.UI.Models
{
    public class CategoriaModel
    {
        public string Nome { get; set; }
        public string URL { get; set; }
        public string Icone { get; set; }
        public IList<String> Subcategorias { get; set; } 
    }
}