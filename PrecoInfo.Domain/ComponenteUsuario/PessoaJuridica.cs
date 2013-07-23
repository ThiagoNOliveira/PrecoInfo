using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Domain.ComponenteUsuario
{
    public class PessoaJuridica : Usuario
    {
        public virtual string CNPJ { get; set; }
        public virtual string NomeResponsavel { get; set; }
        public virtual string RazaoSocial { get; set; }
        public virtual string NomeFantasia { get; set; }
    }
}
