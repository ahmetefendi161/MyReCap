using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User businessEntity)
        {
            _userDal.Add(businessEntity);
            return new SuccessResult(Messages.userAdded);
        }

        public IResult Update(User businessEntity)
        {
            _userDal.Update(businessEntity);
            return new SuccessResult(Messages.userUpdated);
        }

        public IResult Delete(User businessEntity)
        {
            _userDal.Delete(businessEntity);
            return new SuccessResult(Messages.userDeleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            
             return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_userDal.Get(u=>u.Id==id));
        }

        
    }
}
