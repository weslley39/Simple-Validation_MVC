using ExemploValidacao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {


        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa)
        {
            //if (string.IsNullOrEmpty(pessoa.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O campo nome é Obrigatório");
            //}
            //if (pessoa.Senha != pessoa.ConfirmarSenha)
            //{
            //    ModelState.AddModelError("", "As senhas não Conferem");
            //}

            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }

            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string Login)
        {
            var bancodenomesexemplo = new Collection<string>
            {
                "Cleyton",
                "anderson",
                "Renata"
            };
            return Json(bancodenomesexemplo.All(x => x.ToLower() != Login.ToLower()), JsonRequestBehavior.AllowGet);

        }

    }
}
