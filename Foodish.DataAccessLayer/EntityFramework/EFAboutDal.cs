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
    public class EFAboutDal : GenericRepository<About>, IAboutDal
    {
        public EFAboutDal(FoodishContext context) : base(context)
        {
        }
    }
}
