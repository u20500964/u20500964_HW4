using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20500964_HW4.Models;

namespace u20500964_HW4.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Admin()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult AddMaarchendise(string name, int price, int quantity, string description, string brand, string size)
        {
            // Create Mech object 
            Random random = new Random();
            int id = random.Next(0, 50002);
            Marchendise marchendise = new Marchendise(id,name, description,brand, size, price);

           
            // Add to the list 
            Database.Products.Add(marchendise);

            return RedirectToAction("Admin");
        }

        [HttpPost]
        public ActionResult AddFood(string name, int price, int quantity, string description, string instructions, string ingredients)
        {
            // Create Mech object 
            Random random = new Random();
            int id = random.Next(0, 50002);
            Food food = new Food(id, name, description,instructions , ingredients, price);

            // Add to the list 
            Database.Products.Add(food);

            return RedirectToAction("Admin");
        }
    }
}