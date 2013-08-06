using FluentNHibernate.Mapping;
using PrecoInfo.Domain.ComponenteProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Produto
{
    public class MarcaMap : ClassMap<Marca>
    {
        public MarcaMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
        }
    }
}
