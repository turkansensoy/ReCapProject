using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    //Context:db tabloları ile proje classlarını baglamak
    class RentACarContext: DbContext
    {
        //context hangi veritabanına baglanacagını buldu.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=RentACar;Trusted_Connection=true");

        }
        //hangi classım hangi tabloya karsılık geliyor
        public DbSet<Color> Color { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Brand> Brand { get; set; }
    }
}
