using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.AdminLayoutViewComponents
{
    public class _CustomTemplateLayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
