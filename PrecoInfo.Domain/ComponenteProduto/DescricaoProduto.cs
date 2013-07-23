using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Domain.ComponenteProduto
{
    public class DescricaoProduto
    {
        public virtual Guid Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Especificacao { get; set; }
        public virtual Marca Marca { get; set; }
    }
}
