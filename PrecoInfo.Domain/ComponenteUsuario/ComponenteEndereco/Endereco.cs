using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecoInfo.Domain.ComponenteUsuario.ComponenteEndereco
{
    public class Endereco
    {
        public virtual Guid Id { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Logradouro { get; set; }
        public virtual string Numero { get; set; }
        public virtual Zona Zona { get; set; }
        public virtual Bairro Bairro { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual Estado Estado { get; set; }

    }

    public class Estado
    {
        public virtual Guid Id { get; set; }
        public virtual string UF { get; set; }
        public virtual IList<Cidade> Cidades { get; set; }
    }

    public class Cidade
    {
        public virtual Guid Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Zona> Zonas { get; set; }
    }

    public class Zona
    {
        public virtual Guid Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual IList<Bairro> Bairros { get; set; }
    }

    public class Bairro
    {
        public virtual Guid Id { get; set; }
        public virtual string Nome { get; set; }
    }
}
