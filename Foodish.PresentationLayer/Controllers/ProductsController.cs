using Foodish.BusinessLayer.Abstract;
using Foodish.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Foodish.PresentationLayer.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult ProductList()
        {
            var values = _productService.TGetAll();
            return View(values);
        }
        public IActionResult ProductListWithCategory()
        {
            var values = _productService.TProductListWithCategory();
            return View(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return RedirectToAction("ProductListWithCategory");

        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            var categories = _categoryService.TGetAll()
                                .Where(c => c != null && !string.IsNullOrEmpty(c.CategoryName))
                                .ToList();

            // Eğer hiç kategori yoksa boş liste ver
            ViewBag.categories = categories.Any()
                                 ? new SelectList(categories, "CategoryID", "CategoryName")
                                 : new SelectList(new List<Category>(), "CategoryID", "CategoryName");

            return View(new Product());
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("ProductListWithCategory");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var productValues = _productService.TGetByID(id);

            if (productValues == null)
            {
                return NotFound("Ürün bulunamadı!");
            }

            var categories = _categoryService.TGetAll() ?? new List<Category>();

            ViewBag.categories = new SelectList(categories, "CategoryID", "CategoryName", productValues.CategoryID);

            return View(productValues);
        }


        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("ProductListWithCategory");
        }
    }
}