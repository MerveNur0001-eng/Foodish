using System;
using System.Collections.Generic;
using Foodish.BusinessLayer.Abstract;
using Foodish.DataAccessLayer.Abstract;
using Foodish.EntityLayer.Concrete;

namespace Foodish.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> ProductListWithCategoryAndLast12Items()
        {
            return _productDal.ProductListWithCategoryAndLast12Items();
        }

        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }

        public List<Product> TGetAll()
        {
            return _productDal.GetAll();
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public void TInsert(Product entity)
        {
            _productDal.Insert(entity);
        }

        public List<Product> TProductListWithCategory()
        {
            return _productDal.ProductListWithCategory();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }
    }
}
