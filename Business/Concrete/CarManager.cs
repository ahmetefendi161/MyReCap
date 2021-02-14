using Business.Abstract;
using Business.Constants;
using Business.Utilities;
using Business.ValidationRules.FluentValidation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IResult Add(Car businessEntity)
        {
            var validationResult = ValidationTool.Validate(new CarValidator(), businessEntity);
            if (validationResult.Errors.Count > 0)
            {
                return new ErrorResult(validationResult.Errors.Select(x => x.ErrorMessage).Aggregate((a, b) => $"--{a}\n--{b}"));
            }
            
            _carDal.Add(businessEntity);
            return new SuccessResult(Messages.carAdded);
        }

        public IResult Delete(Car businessEntity)
        {
            if (_carDal.Get(c => c.Id == businessEntity.Id) != null)
            {
                _carDal.Delete(businessEntity);
                return new SuccessResult(Messages.carDeleted);
            }

            return new ErrorResult(Messages.carDeletedError);
        }

        public IResult Update(Car businessEntity)
        {
            var validationResult = ValidationTool.Validate(new BrandValidator(), businessEntity);
            if (validationResult.Errors.Count > 0)
            {
                return new ErrorResult(validationResult.Errors.Select(x => x.ErrorMessage).Aggregate((a, b) => $"--{a}\n--{b}"));
            }
            _carDal.Update(businessEntity);
            return new SuccessResult(Messages.carUpdated);

        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());

        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return  new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<Car>> GetAllByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >=min && c.DailyPrice <= max));
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Car>> GetAllByModelYear(string year)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ModelYear == year));

        }

        public IDataResult<IEnumerable<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<IEnumerable<CarDetailDto>>(_carDal.GetCarDetails());
        }
    }
}
