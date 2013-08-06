using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Produto
{
    public class ProdutoMap: ClassMap<PrecoInfo.Domain.ComponenteProduto.Produto>
    {
        public ProdutoMap()
        {
            Id(x => x.Id);
            Map(x => x.Preco);
            References(x => x.Fornecedor);
            References(x => x.DescricaoProduto);
        }
    }
}
