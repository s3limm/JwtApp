﻿namespace JwtApp.Api.Core.Domain
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        //Relational Properties
        public Category Category { get; set; }
        public Product()
        {
            Category = new Category();
        }
    }
}
