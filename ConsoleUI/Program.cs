using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car();
            // BrandTest();
            // ColorTest();
            // UserTest();
             //CustomerTest();
             RentalTest();
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental{CarId=6,CustomerId=2, RentDate =new DateTime(2021,2,14)});
            var result = rentalManager.GetAll();
            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.CarId +"Return Date"+rental.RentDate);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            // userManager.Add(new User {FirstName="turkan",LastName="sensoy",Email="senso@gmail.com",Password="1234"});
            var result = userManager.GetAll();
            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.FirstName + "/" + user.LastName + "/" + user.Email);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            // customerManager.Add(new Customer { UserId = 3, CompanyName = "RentACar" });
            var result = customerManager.GetAll();
            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Lila" });
            var result = colorManager.GetAll();
            if (!result.Success)
            {
                Console.WriteLine(result.Message);
            }
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            // Brand brand1 = new Brand {BrandName="Volvo"};
            brandManager.Add(new Brand { BrandName = "Opel" });
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }

        private static void Car()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice + "/" + car.Description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
