﻿using System.Security.Principal;

namespace JwtApp.Api.Core.Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string? Definition { get; set; }

        //Relational Properties
        public List<Product> Products{ get; set; }

    }
}
