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
        
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var results = from c in context.Cars
                              join b in context.Brands on c.BrandId equals b.BrandId
                              join cl in context.Colors on c.ColorId equals cl.ColorId
                              select new CarDetailDto
                              {
                                  Description = c.Description,
                                  BrandName = b.BrandName,
                                  ColorName = cl.ColorName,
                                  DailyPrice = c.DailyPrice   
                              };
                return results.ToList();
            }
        }
        
    }
}
