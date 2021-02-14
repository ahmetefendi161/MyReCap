using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IRentalDal: IEntityRepository<Rental>
    {
        IEnumerable<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null);
    }
}