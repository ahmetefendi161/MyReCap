using Core.Entities;
using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseService<TBusiness> where TBusiness : class, IEntity, new()
    {
        IResult Add(TBusiness businessEntity);
        IResult Update(TBusiness businessEntity);
        IResult Delete(TBusiness businessEntity);
        IDataResult<List<TBusiness>> GetAll();
    }
}
