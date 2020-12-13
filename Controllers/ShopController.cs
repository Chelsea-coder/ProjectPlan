using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toy_Story_Directory.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Toy_Story_Directory.Data;

namespace Toy_Story_Directory.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            //Get a list of categories to display to customers
            var categories = _context.Categories.OrderBy(c => c.Name).ToList();
            return View(categories);
        }
        //Shop/Browse  
        public IActionResult Browse(int id)
        {
            //Query Products for the selected Category 
            var products = _context.Products.Where(p => p.CategoryId == id).OrderBy(p => p.Name).ToList();

            //Get the name of the selected Category. Find() only and filter by Key fields   
            ViewBag.category = _context.Categories.Find(id).Name.ToString();
            return View(products);
        }
    }
}