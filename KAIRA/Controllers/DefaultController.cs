using Microsoft.AspNetCore.Mvc;

namespace KAIRA.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
