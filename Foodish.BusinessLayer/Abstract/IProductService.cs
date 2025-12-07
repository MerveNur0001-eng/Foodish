using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodish.EntityLayer.Concrete;

namespace Foodish.BusinessLayer.Abstract
{
    public interface IProductService:IGenericService<Product>
    {
        List<Product> TProductListWithCategory();
        List<Product> ProductListWithCategoryAndLast12Items();
    }
}
