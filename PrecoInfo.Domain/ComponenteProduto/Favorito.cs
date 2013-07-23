using PrecoInfo.Domain.ComponenteUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Domain.ComponenteProduto
{
    public class Favorito
    {
        public virtual Guid Id { get; set; }
        public virtual Produto Produto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
