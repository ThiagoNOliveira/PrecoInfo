using PrecoInfo.Domain.ComponenteProduto;
using PrecoInfo.Domain.ComponenteUsuario.ComponenteEndereco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Domain.ComponenteUsuario
{
    public abstract class Usuario
    {
        public virtual Guid Id { get; set; }
        public virtual TipoUsuario TipoUsuario { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Email { get; set; }
        public virtual string Celular { get; set; }
        public virtual string Telefone { get; set; }
        public virtual string OutroTelefone { get; set; }
        public virtual string WebSite { get; set; }
        public virtual string TextoInstitucional { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
