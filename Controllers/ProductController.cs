using Practical__6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical__6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View(GetProducts());
        }

        public ActionResult Details(int id)
        {
            var product = GetProducts()
                .FirstOrDefault(p => p.ProductId == id);

            return View(product);
        }

        private List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { ProductId = 1, ProductName = "Laptop", Description = "Dell laptop with 16GB RAM and 512GB SSD", Price = 55000, Category = "Electronics" },
                new Product { ProductId = 2, ProductName = "Mobile", Description = "Samsung smartphone with AMOLED display", Price = 25000, Category = "Electronics" },
                new Product { ProductId = 3, ProductName = "Headphones", Description = "Wireless headphones with clear sound", Price = 3000, Category = "Accessories" },
                new Product { ProductId = 4, ProductName = "Keyboard", Description = "USB keyboard for office and gaming", Price = 1500, Category = "Accessories" },
                new Product { ProductId = 5, ProductName = "Smart Watch", Description = "Smart watch with fitness tracking", Price = 5000, Category = "Electronics" },
                new Product { ProductId = 6, ProductName = "Mouse", Description = "Wireless mouse with adjustable sensitivity", Price = 800, Category = "Accessories" },
                new Product { ProductId = 7, ProductName = "Tablet", Description = "Portable tablet for reading and classes", Price = 18000, Category = "Electronics" },
                new Product { ProductId = 8, ProductName = "Speaker", Description = "Bluetooth speaker with powerful audio", Price = 2200, Category = "Accessories" },
                new Product { ProductId = 9, ProductName = "Monitor", Description = "24-inch Full HD monitor", Price = 12000, Category = "Electronics" },
                new Product { ProductId = 10, ProductName = "Power Bank", Description = "10000mAh portable charger", Price = 1200, Category = "Accessories" }
            };
        }
    }
}