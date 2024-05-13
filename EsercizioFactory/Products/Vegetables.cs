﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFactory.Products
{
    internal class Vegetables : IFood
    {
        public string name { get; set; }
        public float price { get; set; }
        public string description { get; set; }
        public string expirationDate { get; set; }
        public int productId { get; set; }
        public Vegetables(string name, float price, string description, string expirationDate, int productId)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.expirationDate = expirationDate;
            this.productId = productId;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Description: {description}");
            Console.WriteLine($"Expiration Date: {expirationDate}");
        }

        public int GetID() => productId;
    }
}
