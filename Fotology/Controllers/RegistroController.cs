using Microsoft.AspNetCore.Mvc;

namespace Fotology.Controllers
{
    public class RegistroController : Controller
    {
        public IActionResult RegistroUsuario()
        {
            return View();
        }

        public IActionResult RegistroFotografo()
        {
            return View();
        }
    }
}
