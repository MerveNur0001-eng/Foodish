using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodish.EntityLayer.Concrete;

namespace Foodish.DataAccessLayer.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Product> ProductListWithCategory();
        List<Product> ProductListWithCategoryAndLast12Items();

    }
}
