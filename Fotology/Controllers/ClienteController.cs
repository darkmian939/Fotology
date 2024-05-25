using Microsoft.AspNetCore.Mvc;

namespace Fotology.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult PagCliente()
        {
            return View();
        }
    }
}
