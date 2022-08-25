using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20500964_HW4.Models;

namespace u20500964_HW4.Controllers
{
    public class ShopController : Controller
    {
        // List of products of that are bought
        
        // GET: Shop
        public ActionResult Index()
        {
            Marchendise marchendise1 = new Marchendise(5, "Jacket", "winter jacket", "Nike", "small", 100);
            Database.Products.Add(marchendise1);
            // List of the products 
            return View(Database.Products);
        }

        [HttpGet]
        public ActionResult Cart()
        {
            // Lis of products
            return View();
        }

        // Action to buy product

        public ActionResult BuyProduct(int id)
        {
            int t = 0;
                       
            // Find the products 
            // Find the products 
            int i = Database.Products.FindIndex(p => p.ProductId == id);
            // Add to the cart 
            var product = Database.Products[i];
            Database.ProductsIncart.Add(product);
            foreach (Product p in Database.ProductsIncart)
            {
                t += p.Price;
            }
            @ViewBag.Message = t;
            return View("Cart", Database.ProductsIncart);
        }


        // decrease 

        public ActionResult Decrease(int id)
        {
            // Find the products
            int t = 0;
            int i = Database.ProductsIncart.FindIndex(p => p.ProductId == id);
            Database.ProductsIncart[i].Quantity--;
            foreach (Product p in Database.ProductsIncart)
            {
                t += p.Price;
            }
            @ViewBag.Message = t;
            return View("Cart", Database.ProductsIncart);

        }


        public ActionResult Increase(int id)
        {
            // Find the products
            int t = 0;
            int i = Database.ProductsIncart.FindIndex(p => p.ProductId == id);
            Database.ProductsIncart[i].Quantity++;
            foreach (Product p in Database.ProductsIncart)
            {
                t += p.Price;
            }
            @ViewBag.Message = t;
            return View("Cart", Database.ProductsIncart);

        }


        public ActionResult Delete(int id)
        {
            int i = Database.ProductsIncart.FindIndex(p => p.ProductId == id);
            var prod = Database.ProductsIncart[i];
            Database.ProductsIncart.Remove(prod);

            return View("Cart", Database.ProductsIncart);
        }

        public ActionResult Donation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Donation(Donations donation)
        {
            Database.ProductsIncart.Add(donation);
            return View("Cart", Database.ProductsIncart);
        }




    }
}