﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticketing.Data.Models
{
    public class User_City
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public int CityId { get; set; }
        public City? City { get; set; }
    }
}
