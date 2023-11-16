using BAZE.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BAZE.Controllers
{
    public class CadastroController : Controller
    {
        //armazenando usuários em uma lista estática
        private static List<Usuario> _users = new List<Usuario>();

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["msg"] = "Cadastro de Cliente";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            ViewData["msg"] = "Sucesso!";
            return View(usuario);
        }
    }
}
