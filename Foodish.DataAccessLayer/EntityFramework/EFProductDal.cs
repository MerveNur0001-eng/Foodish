using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodish.DataAccessLayer.Abstract;
using Foodish.DataAccessLayer.Context;
using Foodish.DataAccessLayer.Repositories;
using Foodish.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Foodish.DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly FoodishContext _context;
        public EFProductDal(FoodishContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            var values = _context.Products.Include(x=> x.Category).ToList();
            return values;
        }

        public List<Product> ProductListWithCategoryAndLast12Items()
        {
            var values = _context.Products.OrderByDescending(x=> x.ProductID).Take(12).Include(y => y.Category).ToList();
            return values;
        }
    }
}
