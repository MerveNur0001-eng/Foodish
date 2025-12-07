using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foodish.BusinessLayer.Abstract;
using Foodish.DataAccessLayer.Abstract;
using Foodish.EntityLayer.Concrete;

namespace Foodish.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public void TDelete(int id)
        {
           _socialMediaDal.Delete(id);
        }

        public List<SocialMedia> TGetAll()
        {
           return _socialMediaDal.GetAll();
        }

        public SocialMedia TGetByID(int id)
        {
            return _socialMediaDal.GetByID(id);
        }

        public void TInsert(SocialMedia entity)
        {
            _socialMediaDal.Insert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
       
    }

