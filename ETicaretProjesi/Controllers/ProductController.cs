using ETicaretProjesi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretProjesi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 25000, ImageUrl = "\"C:\\Users\\HP\\Pictures\\laptop.jpg\"", Description = "Güçlü bir laptop" },
            new Product { Id = 2, Name = "Telefon", Price = 14000, ImageUrl = "\"C:\\Users\\HP\\Pictures\\telefon.jpg\"", Description = "Akıllı telefon" }
        };

            return View(products);

        }
    }
}
