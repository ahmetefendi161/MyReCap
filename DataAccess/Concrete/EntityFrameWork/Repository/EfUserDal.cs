using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork.Repository
{
    
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarContext>, IUserDal
    {
        //public EfUserDal(RentACarContext context) : base(context)
        //{
        //}
    }
}
