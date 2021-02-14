using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.UnitOfWork.Abstract
{
    public interface IUnitOfWork: IDisposable
    {
        IBrandService BrandService { get; }
        ICarService CarService { get; }
        IColorService ColorService { get; }
        IBaseService<Car> CarServiceTest { get; }
        int SaveChanges();


    }
}
