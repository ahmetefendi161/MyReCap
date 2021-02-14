using Core.Utilities.Results.Abstract;
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService : IBaseService<Rental>
    {
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetAllByCarId(int carId);
        IDataResult<List<Rental>> GetAllByCustomerId(int customerId);
        IDataResult<List<Rental>> IsNotRented(int carId);
        IResult Receive(int carId);
        IDataResult<IEnumerable<RentalDetailDto>> GetRentalDetailsByCarIdDto(int carId);
        IDataResult<IEnumerable<RentalDetailDto>> GetRentalDetailsDto();
    }
}
