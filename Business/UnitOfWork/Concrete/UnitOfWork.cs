using Business.Abstract;
using Business.Concrete;
using Business.UnitOfWork.Abstract;
using DataAccess.Concrete.EntityFrameWork.Context;
using DataAccess.Concrete.EntityFrameWork.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        //RentACarContext _context;
        ////public IBrandService BrandService { get; private set; }
        ////public ICarService CarService { get; private set; }
        ////public IColorService ColorService { get; private set; }
        ////public ICustomerService CustomerService { get; private set; }
        ////public IRentalService RentalService { get; private set; }
        ////public IUserService UserService { get; private set; }

        //public UnitOfWork(RentACarContext context /*IBrandService brandService,ICarService carService,IColorService colorService,ICustomerService customerService,IRentalService rentalService,IUserService userService*/)
        //{
        //    _context = context;
        //    //BrandService = brandService;
        //    //CarService = carService;
        //    //ColorService = colorService;
        //    //CustomerService = customerService;
        //    //RentalService = rentalService;
        //    //UserService = userService;
        //}

        ////fields
        //IBrandService brandService;
        //IColorService colorService;
        //ICustomerService customerService;
        //IRentalService rentalService;
        //IUserService userService;
        //ICarService carService;
        


        ////public IBrandService BrandService
        ////{
        ////    get
        ////    {

        ////        brandService = new BrandManager(new EfBrandDal(_context));
        ////        return brandService;

        ////    }
        ////}

        //public IBrandService BrandService => brandService ?? (brandService = new BrandManager(new EfBrandDal(_context)));

        //public ICarService CarService => carService ?? (carService = new CarManager(new EfCarDal(_context)));

        //public IColorService ColorService => colorService ?? (colorService = new ColorManager(new EfColorDal(_context)));

        //public IBaseService<Car> CarServiceTest => throw new NotImplementedException();// bakılacak bole kullanılabılıormu

        //public ICustomerService CustomerService => customerService ?? (customerService = new CustomerManager(new EfCustomerDal(_context)));

        //public IRentalService RentalService => rentalService ?? (rentalService = new RentalManager(new EfRentalDal(_context)));

        //public IUserService UserService => userService ?? (userService = new UserManager(new EfUserDal(_context)));

        //public int SaveChanges()
        //{
        //    return _context.SaveChanges();
        //}

        //#region IDisposable Support
        //private bool disposedValue = false; //To detect redundant calss
        //protected virtual void Dispose(bool disposing)
        //{
        //    if (!disposedValue)
        //    {
        //        if (disposing)
        //        {
        //            _context.Dispose();
        //        }

        //        // TODO: free unmanaged resources (unmanaged objects) and override finalizer
        //        // TODO: set large fields to null
        //        disposedValue = true;
        //    }
        //}

        //// // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        //// ~UnitOfWork()
        //// {
        ////     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        ////     Dispose(disposing: false);
        //// }

        //public void Dispose()
        //{
        //    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //    Dispose(disposing: true);
        //    GC.SuppressFinalize(this);
        //}
        //#endregion
    }
}
