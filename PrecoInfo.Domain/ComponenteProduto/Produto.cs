using PrecoInfo.Domain.ComponenteUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Domain.ComponenteProduto
{
    public class Produto
    {
        public virtual Guid Id { get; set; }
        public virtual double Preco { get; set; }
        public virtual DescricaoProduto DescricaoProduto { get; set; }
        public virtual Usuario Fornecedor { get; set; }
    }
}
