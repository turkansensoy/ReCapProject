using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
       IDataResul<List<Car>> GetAll();
       IDataResul<List<Car>> GetCarsByBrandId(int id);
       IDataResul<List<Car>> GetCarsByColorId(int id);
       IDataResul<List<CarDetailDto>> GetCarDetail();
        IResult Add(Car car);
    }
}
