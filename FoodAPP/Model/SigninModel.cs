﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodAPP.Model
{
    internal class Signin
    {
        [PrimaryKey]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}