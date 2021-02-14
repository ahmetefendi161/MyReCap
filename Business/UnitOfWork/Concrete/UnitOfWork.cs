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
        RentACarContext _context;

        public UnitOfWork(RentACarContext context)
        {
            _context = context;
        }

        //fields

        IBrandService brandService;
        ICarService carService;
        IColorService colorService;
        


        public IBrandService BrandService => brandService ?? (brandService=new BrandManager(new EfBrandDal(_context)));

        public ICarService CarService => carService ?? (carService = new CarManager(new EfCarDal(_context)));

        public IColorService ColorService => colorService ?? (colorService = new ColorManager(new EfColorDal(_context)));

        public IBaseService<Car> CarServiceTest => throw new NotImplementedException();// bakılacak bole kullanılabılıormu

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; //To detect redundant calss
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        } 
        #endregion
    }
}
