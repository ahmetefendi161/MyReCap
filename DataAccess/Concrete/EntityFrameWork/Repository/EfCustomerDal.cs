using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFrameWork.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork.Repository
{
   
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        //public EfCustomerDal(RentACarContext context) : base(context)
        //{

        //}
    }
}
