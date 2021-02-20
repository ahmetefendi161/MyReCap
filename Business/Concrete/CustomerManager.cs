using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer businessEntity)
        {
           
            if (_customerDal.Get(c => c.Id == businessEntity.Id) != null)
            {
                return new ErrorResult(Messages.customerAddError);
            }
            _customerDal.Add(businessEntity);
            return new SuccessResult(Messages.customerAdded);

        }

        public IResult Update(Customer businessEntity)
        {
            _customerDal.Update(businessEntity);
            return new SuccessResult(Messages.customerUpdated);

        }

        public IResult Delete(Customer businessEntity)
        {
            var result = _customerDal.Get(c => c.Id == businessEntity.Id);
            if (result != null)
            {
                _customerDal.Delete(result);
                return new SuccessResult(Messages.customerDeleted);
            }

            return new ErrorResult(Messages.customerDeletedError);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IDataResult<Customer> GetById(int id)
        {
            var result = _customerDal.Get(b => b.Id == id);
            if (result != null)
            {
                return  new SuccessDataResult<Customer>(result);
            }
            
            return new ErrorDataResult<Customer>(Messages.customerGetByIdError);

        }

        
    }
}
