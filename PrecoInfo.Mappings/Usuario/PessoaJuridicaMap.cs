using FluentNHibernate.Mapping;
using PrecoInfo.Domain.ComponenteUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Usuario
{
    public class PessoaJuridicaMap : SubclassMap<PessoaJuridica>
    {
        public PessoaJuridicaMap()
        {
            Map(x => x.CNPJ);
            Map(x => x.NomeFantasia);
            Map(x => x.NomeResponsavel);
            Map(x => x.RazaoSocial);

            DiscriminatorValue(2);
        }
    }
}
