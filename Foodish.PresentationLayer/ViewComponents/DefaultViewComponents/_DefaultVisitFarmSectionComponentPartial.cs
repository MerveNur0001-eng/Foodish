using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultVisitFarmSectionComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}