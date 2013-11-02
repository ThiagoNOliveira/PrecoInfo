using FluentNHibernate.Mapping;
using PrecoInfo.Domain.ComponenteUsuario.ComponenteEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Usuario.Endereco
{
    public class EnderecoMap : ClassMap<PrecoInfo.Domain.ComponenteUsuario.ComponenteEndereco.Endereco>
    {
        public EnderecoMap()
        {
            Id(x => x.Id);
            Map(x => x.Cep);
            Map(x => x.Complemento);
            Map(x => x.Logradouro);
            Map(x => x.Numero);
            References(x => x.Estado);
            References(x => x.Cidade);
            References(x => x.Zona);
            References(x => x.Bairro);

        }
    }

    public class EstadoMap : ClassMap<Estado>
    {
        public EstadoMap()
        {
            Id(x => x.Id);
            Map(x => x.UF);
            HasMany(x => x.Cidades).Cascade.AllDeleteOrphan();
        }
    }

    public class CidadeMap : ClassMap<Cidade>
    {
        public CidadeMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            HasMany(x => x.Zonas).Cascade.AllDeleteOrphan();
        }
    }

    public class ZonaMap : ClassMap<Zona>
    {
        public ZonaMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
            HasMany(x => x.Bairros).Cascade.AllDeleteOrphan();
        }
    }

    public class BairroMap : ClassMap<Bairro>
    {
        public BairroMap()
        {
            Id(x => x.Id);
            Map(x => x.Nome);
        }
    }
}
