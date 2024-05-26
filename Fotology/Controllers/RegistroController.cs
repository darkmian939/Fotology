using Microsoft.AspNetCore.Mvc;
using SenaFotology.Models;
using static SenaFotology.Models.LoginViewModel;

namespace SenaFotology.Controllers
{
    public class RegistroController : Controller
    {
        public ActionResult RegistroUsuario()
        {
            return View();
        }
        public ActionResult RegistroFotografo()
        {
            return View();
        }

    }
}
