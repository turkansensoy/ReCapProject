using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal :EfEntityRepositoryBase<Car,RentACarContext>,ICarDal
    { 
        /*
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var results = from c in context.Car
                              join b in context.Brand on c.BrandId equals b.BrandId
                              join cl in context.Color on c.ColorId equals cl.ColorId
                              select new CarDetailDto
                              {
                                  CarId = c.CarId,
                                  Name = b.Name,
                                  DailyPrice = c.DailyPrice,
                                  ColorName = cl.Name
                              };
                return results.ToList();
            }
        }
        */
    }
}
