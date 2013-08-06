using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Domain.ComponenteUsuario
{
    public class PessoaFisica : UsuarioBase
    {
        public virtual string Nome { get; set; }
        public virtual string CPF { get; set; }
    }
}
