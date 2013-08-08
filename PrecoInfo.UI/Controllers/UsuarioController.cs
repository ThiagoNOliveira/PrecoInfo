using PrecoInfo.Domain.ComponenteUsuario;
using PrecoInfo.UI.Models;
using ProcuraFacil.Core.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrecoInfo.UI.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Loja()
        {
            return View();
        }
        public ActionResult Prestador()
        {
            return View();
        }
        public ActionResult Usuario()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["msg"]))
            {
 
            }

            return View();
        }

        public ActionResult EsqueciMinhaSenha()
        {
            return View();
        }

        public ActionResult SalvarUsuario(UsuarioDTO usuarioDTO)
        {
            PessoaFisica usuario = new PessoaFisica
            {
                Email = usuarioDTO.Email,
                Celular = usuarioDTO.Celular,
                Senha = usuarioDTO.Senha,
                TipoUsuario = TipoUsuario.Usuario,
                Nome = usuarioDTO.Nome
            };

            Repositorio<UsuarioBase> usuarios = new Repositorio<UsuarioBase>();

            usuarios.Adicionar(usuario);

            return Redirect("/cadastrar/usuario?msg=cadastrado com sucesso");
        }

        public ActionResult Logar(string username, string senha)
        {
            return null;
        }
    }
}
