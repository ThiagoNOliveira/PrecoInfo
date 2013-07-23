using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Domain.ComponenteProduto
{
    public class Categoria
    {
        public virtual Guid Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Categoria> SubCategorias { get; set; }

        public Categoria()
        {
            SubCategorias = new List<Categoria>();
        }
    }
}
