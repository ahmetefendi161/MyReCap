using Business.Abstract;
using Business.Constants;

using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Brand businessEntity)
        {
            
            if (_brandDal.Get(c => c.BrandName.ToLower() == businessEntity.BrandName.ToLower()) != null)
            {
                return new ErrorResult(Messages.brandAddError);
            }
            _brandDal.Add(businessEntity);
            return new SuccessResult(Messages.brandAdded);

        }

        [ValidationAspect(typeof(BrandValidator))]
        public IResult Update(Brand businessEntity)
        {

            _brandDal.Update(businessEntity);
            return new SuccessResult(Messages.brandUpdated);



        }

        public IResult Delete(Brand businessEntity)
        {
            var result = _brandDal.Get(c => c.Id == businessEntity.Id);
            if ( result != null)
            {
                _brandDal.Delete(result);
                return new SuccessResult(Messages.brandDeleted);
            }

            return new ErrorResult(Messages.brandDeletedError);

        }
               
        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id));
            
            
        }

        
    }
}
