using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace Fotology.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult InicioUsuario()
        {
            return View();
        }

        public IActionResult InicioFotografo()
        {
            return View();
        }

        public IActionResult InicioAdministrador()
        {
            return View();
        }

        public IActionResult RegistroUsuario()
        {
            return View();
        }

        public IActionResult RegistroFotografo()
        {
            return View();
        }

        public IActionResult PagCliente()
        {
            return View();
        }

        public IActionResult PagFotografo()
        {
            return View();
        }

        public IActionResult PagAdministrador()
        {
            return View();
        }

        public IActionResult Ayuda()
        {
            return View();
        }

    }
}
