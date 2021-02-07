
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBaseService<TBusiness> where TBusiness : class, IEntity, new()
    {
        void Add(TBusiness businessEntity);
        void Update(TBusiness businessEntity);
        void Delete(TBusiness businessEntity);
        List<TBusiness> GetAll();
    }
}
