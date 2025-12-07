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
    public class EFAboutItemDal : GenericRepository<AboutItem>, IAboutItemDal
    {
        public EFAboutItemDal(FoodishContext context) : base(context)
        {
        }
    }
}
