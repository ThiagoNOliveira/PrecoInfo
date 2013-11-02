using FluentNHibernate.Mapping;
using PrecoInfo.Domain.ComponenteProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Produto
{
    public class DescricaoProdutoMap : ClassMap<DescricaoProduto>
    {
        public DescricaoProdutoMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.Especificacao);
            References(x => x.Marca);
        }
    }
}
