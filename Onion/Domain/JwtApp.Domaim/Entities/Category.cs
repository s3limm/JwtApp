﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtApp.Domaim.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string? Definition { get; set; }

        //Relational Properties
        public List<Product> Products { get; set; }
    }
}
