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
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Add(Color businessEntity)
        {
            
            if (_colorDal.Get(c => c.ColorName.ToLower() == businessEntity.ColorName.ToLower()) != null)
            {
                return new ErrorResult(Messages.colorAddError);
            }
            _colorDal.Add(businessEntity);
            return new SuccessResult(Messages.colorAdded);

        }

        [ValidationAspect(typeof(ColorValidator))]
        public IResult Update(Color businessEntity)
        {


            _colorDal.Update(businessEntity);
            return new SuccessResult(Messages.colorUpdated);



        }

        public IResult Delete(Color businessEntity)
        {
            var result = _colorDal.Get(c => c.Id == businessEntity.Id);
            if (result != null)
            {
                _colorDal.Delete(result);
                return new SuccessResult(Messages.colorDeleted);
            }

            return new ErrorResult(Messages.colorDeleteError);

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
