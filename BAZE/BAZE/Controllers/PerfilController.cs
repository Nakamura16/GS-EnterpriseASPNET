using BAZE.Models;
using Microsoft.AspNetCore.Mvc;

namespace BAZE.Controllers
{
    public class PerfilController : Controller
    {
        public IActionResult Index(Usuario usuario)
        {
            return View();
        }
    }
}
