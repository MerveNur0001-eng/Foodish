using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
