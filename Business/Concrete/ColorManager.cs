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
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color businessEntity)
        {
            var validationResult = ValidationTool.Validate(new ColorValidator(), businessEntity);
            if (validationResult.Errors.Count > 0)
            {
                return new ErrorResult(validationResult.Errors.Select(x => x.ErrorMessage).Aggregate((a, b) => $"--{a}\n--{b}"));
            }
            else if (_colorDal.Get(c => c.ColorName.ToLower() == businessEntity.ColorName.ToLower()) != null)
            {
                return new ErrorResult(Messages.colorAddError);
            }
            _colorDal.Add(businessEntity);
            return new SuccessResult(Messages.colorAdded);

        }

        public IResult Delete(Color businessEntity)
        {
            if (_colorDal.Get(c => c.Id == businessEntity.Id) != null)
            {
                _colorDal.Delete(businessEntity);
                return new SuccessResult(Messages.colorDeleted);
            }

            return new ErrorResult(Messages.colorDeleteError);

        }

        public IResult Update(Color businessEntity)
        {
            var validationResult = ValidationTool.Validate(new ColorValidator(), businessEntity);
            if (validationResult.Errors.Count > 0)
            {
                return new ErrorResult(validationResult.Errors.Select(x => x.ErrorMessage).Aggregate((a, b) => $"--{a}\n--{b}"));
            }
            else if (_colorDal.Get(c => c.ColorName.ToLower() == businessEntity.ColorName.ToLower()) != null)
            {
                return new ErrorResult(Messages.colorUpdateError);
            }
            _colorDal.Update(businessEntity);
            return new SuccessResult(Messages.colorUpdated);



        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll());
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(b => b.Id == id));


        }




    }
}
