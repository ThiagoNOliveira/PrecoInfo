using FluentNHibernate.Mapping;
using PrecoInfo.Domain.ComponenteProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Produto
{
    public class CategoriaMap : ClassMap<Categoria>
    {
        public CategoriaMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            Map(x => x.NomeImagem);
            Map(x => x.Ordem);
            HasMany(x => x.SubCategorias).Cascade.AllDeleteOrphan();
        }
    }
}
