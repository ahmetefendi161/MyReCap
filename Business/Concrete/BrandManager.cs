using Business.Abstract;
using Business.Constants;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
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

        public IResult Add(Brand businessEntity)
        {
            var validationResult = ValidationTool.Validate(new BrandValidator(), businessEntity);
            if (validationResult.Errors.Count > 0)
            {
                return new ErrorResult(validationResult.Errors.Select(x => x.ErrorMessage).Aggregate((a, b) => $"--{a}\n--{b}"));
            }
            else if (_brandDal.Get(c => c.BrandName.ToLower() == businessEntity.BrandName.ToLower()) != null)
            {
                return new ErrorResult(Messages.brandAddError);
            }
            _brandDal.Add(businessEntity);
            return new SuccessResult(Messages.brandAdded);

        }

        public IResult Delete(Brand businessEntity)
        {
             if (_brandDal.Get(c => c.Id == businessEntity.Id) != null)
             {
                _brandDal.Delete(businessEntity);
                return new SuccessResult(Messages.brandDeleted);
             }
            
            return new ErrorResult(Messages.brandDeletedError);

        }

        public IResult Update(Brand businessEntity)
        {
            var validationResult = ValidationTool.Validate(new BrandValidator(), businessEntity);
            if (validationResult.Errors.Count > 0)
            {
                return new ErrorResult(validationResult.Errors.Select(x => x.ErrorMessage).Aggregate((a, b) => $"--{a}\n--{b}"));
            }
            else if (_brandDal.Get(c => c.BrandName.ToLower() == businessEntity.BrandName.ToLower()) != null)
            {
                return new ErrorResult(Messages.brandUpdateError);
            }
            _brandDal.Update(businessEntity);
            return new SuccessResult(Messages.brandUpdated);
            
           

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
