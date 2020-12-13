using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Toy_Story_Directory.Models;

namespace Toy_Story_Directory.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            // Use fake category class/model to create and display 10 categories
            // Create an Obect to hold a list of categories
            var categories = new List<Category>();
            for (var i = 1; i <= 10; i++)
            {
                categories.Add(new Category { CategoryId = i, Name = "Category " + i.ToString() });
            }
            // Modify the return View
            return View(categories);
        }

        public IActionResult Browse(string category)
        {
            ViewBag.category = category;
            return View();
        }

        // /Store/AddCategory
        public IActionResult AddCategory()
        {
            // Load a form to capture an object from a user
            return View();
        }
    }

}