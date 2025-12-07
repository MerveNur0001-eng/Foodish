using Foodish.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Foodish.PresentationLayer.ViewComponents.DefaultViewComponents
{
    public class _DefaultProductSectionComponentPartial:ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductSectionComponentPartial(IProductService productService)
        {
            _productService = productService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _productService.ProductListWithCategoryAndLast12Items();
            return View(values);
        }
    }
}
