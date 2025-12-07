using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _HeadLayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
