using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultHeadSectionComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
