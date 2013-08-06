using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrecoInfo.UI.Models
{
    public class UsuarioDTO
    {
        public virtual string Nome { get; set; }
        public virtual string CPF { get; set; }
        public virtual string CNPJ { get; set; }
        public virtual string NomeResponsavel { get; set; }
        public virtual string RazaoSocial { get; set; }
        public virtual string NomeFantasia { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Telefone { get; set; }
        public string OutroTelefone { get; set; }
        public string WebSite { get; set; }
        public string TextoInstitucional { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}