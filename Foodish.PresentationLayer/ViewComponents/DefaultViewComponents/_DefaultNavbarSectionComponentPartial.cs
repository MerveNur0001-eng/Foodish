using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultNavbarSectionComponentPartial:ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
