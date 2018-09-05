using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalApplication.Models
{
    public class Rental
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateReturned { get; set; }

    }
}