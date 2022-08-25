using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20500964_HW4.Models
{
    public class Marchendise : Product
    {
        

        public Marchendise(int productId, string name, string description, string brand, string size, int price) : base(productId, name, description, price)
        {
            Brand = brand;
            Size = size;
        }

        public string Brand { get; set; }
        public string Size { get; set; }

        public override string DisplyaProduct()
        {
            return "<div class='panel panel-info'>" +
        "< div class='panel-heading'>" + "@mech.Name" + "</div>" +
         "<div class='panel-body'>Brand :" + "@mech.Brand + </div>" +
        "<div class='panel-body'>Size : @mech.Size</div>" +
         "<div class='panel-body'>Price : @mech.Brand</div>" +
         " <div class='panel-body'>Description : @mech.Description</div>" +
         "</div>";
        }
    }
}