using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Mappings.Usuario
{
    public class UsuarioMap : ClassMap<PrecoInfo.Domain.ComponenteUsuario.UsuarioBase>
    {
        public UsuarioMap()
        {
            Id(x => x.Id);
            Map(x => x.Celular);
            Map(x => x.Email);
            Map(x => x.OutroTelefone);
            Map(x => x.Senha);
            Map(x => x.Telefone);
            Map(x => x.TextoInstitucional);
            Map(x => x.WebSite);
            Map(x => x.TipoUsuario);

            References(x => x.Endereco);

            DiscriminateSubClassesOnColumn("DefUsuario");
        }
    }
}
