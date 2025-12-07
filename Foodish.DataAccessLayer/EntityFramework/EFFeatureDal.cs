using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodish.DataAccessLayer.Abstract;
using Foodish.DataAccessLayer.Context;
using Foodish.DataAccessLayer.Repositories;
using Foodish.EntityLayer.Concrete;

namespace Foodish.DataAccessLayer.EntityFramework
{
    public class EFFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EFFeatureDal(FoodishContext context) : base(context)
        {
        }

        public List<Feature> FeatureListByStatusTrue()
        {
           var context=new FoodishContext();
           var values = context.Features.Where(x => x.Status == true).ToList();
           return values;
        }
    }
}
