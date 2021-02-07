using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public void Add(Color businessEntity)
        {
            _colorDal.Add(businessEntity);
            Console.WriteLine("Color {0} Added", businessEntity.ColorName);

        }

        public void Update(Color businessEntity)
        {
            _colorDal.Update(businessEntity);
            Console.WriteLine("Color {0} Updated", businessEntity.ColorName);
        }

        public void Delete(Color businessEntity)
        {
            _colorDal.Delete(businessEntity);
            Console.WriteLine("Color {0} Deleted", businessEntity.ColorName);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(c=>c.Id==id);
        }

        
    }
}
