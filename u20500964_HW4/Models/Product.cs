using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20500964_HW4.Models
{
    public abstract class Product
    {
       

        // Properties
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        // Constructors 

        public Product(int productId, string name, string description, int price)
        {
            ProductId = productId;
            Name = name;
            Description = description;
            Price = price;
        }
        // Methods 
        public abstract string DisplyaProduct();
       

        public virtual int TotalPrice()
        {
            return Quantity * Price;
        }

        public Product() { }



    }
}