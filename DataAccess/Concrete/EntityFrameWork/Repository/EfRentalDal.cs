using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork.Context;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork.Repository
{
    
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        //private RentACarContext _context;

        //public EfRentalDal(RentACarContext context) : base(context)
        //{
        //    _context = context;
        //}
        public IEnumerable<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext _context = new RentACarContext())
            {
                var result = from rd in filter is null ? _context.Rentals : _context.Rentals.Where(filter)
                             join cr in _context.Cars
                             on rd.CarId equals cr.Id
                             join br in _context.Brands
                             on cr.BrandId equals br.Id
                             join cus in _context.Customers
                             on rd.CustomerId equals cus.Id
                             join ur in _context.Users
                             on cus.UserId equals ur.Id
                             select new RentalDetailDto()
                             {
                                 Id = rd.Id,
                                 CarId = rd.CarId,
                                 IsRented = rd.IsRented,
                                 BrandName = br.BrandName,
                                 UserFirstName = ur.FirstName,
                                 UserLastName = ur.LastName,
                                 CompanyName = cus.CompanyName,
                                 RentDate = rd.RentDate,
                                 ReturnDate = rd.ReturnDate
                             };
                return result.ToList();

            }


            


        }
    }
}
