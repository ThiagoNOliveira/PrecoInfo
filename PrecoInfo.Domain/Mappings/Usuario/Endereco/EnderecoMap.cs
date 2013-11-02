using FluentNHibernate.Mapping;
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
            Map(x => x.Bairro);
            Map(x => x.Cep);
            Map(x => x.Cidade);
            Map(x => x.Complemento);
            Map(x => x.Logradouro);
            Map(x => x.Numero);
            Map(x => x.UF);

        }
    }
}
