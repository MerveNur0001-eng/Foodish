using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _SidebarLayoutComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
