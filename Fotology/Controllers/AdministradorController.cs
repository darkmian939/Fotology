using Microsoft.AspNetCore.Mvc;

namespace Fotology.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult PagAdministrador()
        {
            return View();
        }
    }
}
