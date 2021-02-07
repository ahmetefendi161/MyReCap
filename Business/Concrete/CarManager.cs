using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car businessEntity)
        {
            if(businessEntity.DailyPrice>0)
            {
                _carDal.Add(businessEntity);
                Console.WriteLine("{0} Added", businessEntity.BrandId);
            }
            else
            {
                Console.WriteLine("Daily prica must be greater than Zero (0)");

            }
        }

        public void Delete(Car businessEntity)
        {
            _carDal.Delete(businessEntity);
            Console.WriteLine("{0} Deleted", businessEntity.BrandId);

        }

        public void Update(Car businessEntity)
        {
            _carDal.Update(businessEntity);
            Console.WriteLine("{0} Updated", businessEntity.BrandId);

        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
            
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(c => c.ColorId == id);
        }

        public List<Car> GetAllByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >=min && c.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetAllByModelYear(string year)
        {
            return _carDal.GetAll(c => c.ModelYear == year);

        }

        public IEnumerable<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
