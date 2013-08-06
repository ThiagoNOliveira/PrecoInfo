using FluentNHibernate.Mapping;
using PrecoInfo.Domain.ComponenteProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Produto
{
    public class FavoritoMap : ClassMap<Favorito>
    {
        public FavoritoMap()
        {
            Id(x => x.Id);
            References(x => x.Usuario);
            References(x => x.Produto);
        }
    }
}
