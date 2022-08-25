using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20500964_HW4.Models
{
    public class Food: Product
    {
         
    
        public Food(int productId, string name, string description, string instruction, string ingredients, int price) : base(productId, name, description, price)
        {
            Instruction = instruction;
            Ingredients = ingredients;
        }

        public string Instruction { get; set; }
        public string Ingredients { get; set; }

        public override string DisplyaProduct()
        {
            throw new NotImplementedException();
        }
    }
}