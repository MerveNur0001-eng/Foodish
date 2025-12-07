using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _ScriptsLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
