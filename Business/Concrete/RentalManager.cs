﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;
using System.Linq;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;

        }
        public IResult Add(Rental rental)
        {
            var result = CheckReturnDate(rental.CarId);
            if (!result.Success)
            {
              return new ErrorResult(result.Message);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(result.Message);

        }

        private IResult CheckReturnDate(int id)
        {
          var result= _rentalDal.GetRentalDetail(x=>x.CarId==id && x.ReturnDate==null);
            if (result.Any())
            {
                 return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(Messages.RentalAddedInvalid);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetail()
        {
           return new SuccessDataResult<List<RentalDetailDto>>( _rentalDal.GetRentalDetail());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
