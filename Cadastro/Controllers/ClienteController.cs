using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
