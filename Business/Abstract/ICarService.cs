using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService : IBaseService<Car>
    {
        Car GetById(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);
        List<Car> GetAllByDailyPrice(decimal min, decimal max);
        List<Car> GetAllByModelYear(string year);
        IEnumerable<CarDetailDto> GetCarDetails();
    }
}
