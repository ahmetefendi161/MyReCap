using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand businessEntity)
        {
            if (businessEntity.BrandName.Length>=2)
            {
                _brandDal.Add(businessEntity);
                Console.WriteLine("Brand {0} Added", businessEntity.BrandName);

            }
            else
            {
                Console.WriteLine("Brand Name characters must be 2 or more characters");

            }

        }

        public void Delete(Brand businessEntity)
        {
            _brandDal.Delete(businessEntity);
            Console.WriteLine("Brand {0} Deleted", businessEntity.BrandName);

        }

        public void Update(Brand businessEntity)
        {
            _brandDal.Update(businessEntity);
            Console.WriteLine("Brand {0} Updated", businessEntity.BrandName);

        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(b=>b.Id==id);
            
        }

        
    }
}
