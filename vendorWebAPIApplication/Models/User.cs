﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vendorWebAPIApplication.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime UserAddedDate { get; set; }
    }
}
