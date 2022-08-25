using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u20500964_HW4.Models
{
    public class Donations : Product
    {
        
        public Donations(int productId, string name, string description, string donationType, string paymentType, int price) : base(productId, name, description, price)
        {
            DonationType = donationType;
            PaymentType = paymentType;
        }

        public string DonationType { get; set; }
        public string PaymentType { get; set; }

        public override string DisplyaProduct()
        {
            throw new NotImplementedException();
        }

        public Donations() : base()
        {

        }
    }
}