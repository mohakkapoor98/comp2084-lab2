using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            string[] products = { "Laptop", "Tablet", "Desktop" };
            ViewData["products"] = products;
            return View();
        }
        public String Details(string product)
        {
            string prompt = "You have selected " + product;
            return prompt;
        }

    }
}