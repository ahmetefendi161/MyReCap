using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental businessEntity)
        {
            var result = IsNotRented(businessEntity.CarId);
            if (result.Success)
            {
                businessEntity.IsRented = true;
                _rentalDal.Add(businessEntity);
                return new SuccessResult(Messages.rentalAdded);
               
            }
            return new ErrorResult(Messages.rentalAddError + " " + result.Message);

        }

        public IResult Update(Rental businessEntity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Rental businessEntity)
        {
            var result = IsNotRented(businessEntity.CarId);
            if (result.Success)
            {

                _rentalDal.Delete(businessEntity);
                return new SuccessResult(Messages.rentalDeleted);

            }
            return new ErrorResult(Messages.rentalDeleteError + " " + result.Message);
            
        }

        public IDataResult<List<Rental>> IsNotRented(int carId)
        {
            var result = _rentalDal.GetAll(c => c.CarId == carId && c.IsRented == true);
            if (result.ToList().Count > 0)
            {

                return new ErrorDataResult<List<Rental>>(result.ToList(), Messages.rentalIsRentedTrue);

            }
            return new SuccessDataResult<List<Rental>>();

        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());

        }

        public IDataResult<List<Rental>> GetAllByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(x=>x.CarId==carId));
        }

        public IDataResult<List<Rental>> GetAllByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(x => x.CustomerId == customerId));
        }

        public IDataResult<Rental> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<IEnumerable<RentalDetailDto>> GetRentalDetailsByCarIdDto(int carId)
        {
            return new SuccessDataResult<IEnumerable<RentalDetailDto>>(_rentalDal.GetRentalDetails(x => x.CarId == carId));
        }

        public IDataResult<IEnumerable<RentalDetailDto>> GetRentalDetailsDto()
        {
            return new SuccessDataResult<IEnumerable<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Receive(int carId)
        {
            var result = IsNotRented(carId);
            if (!result.Success)
            {
                var rentedCar = result.Data.FirstOrDefault();
                rentedCar.ReturnDate = DateTime.Now;
                rentedCar.IsRented = false;
                _rentalDal.Update(rentedCar);
                return new SuccessResult(Messages.rentalReceivedCar);
            }
            return new ErrorResult();

        }
    }
}
