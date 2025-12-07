using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _MainPanelLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
