using FluentNHibernate.Mapping;
using PrecoInfo.Domain.ComponenteUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Usuario
{
    public class PessoaFisicaMap : SubclassMap<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            Map(x => x.Nome);
            Map(x => x.CPF);

            DiscriminatorValue(1);
        }
    }
}
