﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Rental:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; } // RentDate=Kiralama Tarihi
        public DateTime? ReturnDate { get; set; } // ReturnDate=Teslim Tarihi
    }
}
