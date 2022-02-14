using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetail(Expression<Func<Rental,bool>>filter=null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var results = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                              join c in context.Cars on re.CarId equals c.CarId
                              join customer in context.Customers on re.CustomerId equals customer.Id
                              join user in context.Users on re.CustomerId equals user.Id
                              select new RentalDetailDto
                              {
                                  Id = re.Id,
                                  CarId = c.CarId,
                                  CarName = c.Name,
                                  UserName = user.FirstName + " " + user.LastName,
                                  RentDate = re.RentDate,
                                  ReturnDate = re.ReturnDate,
                                  CompanyName = customer.CompanyName
                              };
              return  results.ToList();
                           
            }
        }
    }
}
