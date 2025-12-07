using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult ErrorPage404()
        {
            return View();
        }
    }
}
