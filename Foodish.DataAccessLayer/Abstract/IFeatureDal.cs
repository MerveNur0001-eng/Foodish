using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodish.EntityLayer.Concrete;

namespace Foodish.DataAccessLayer.Abstract
{
    public interface IFeatureDal:IGenericDal<Feature>
    {
        List<Feature> FeatureListByStatusTrue();
    }
}
