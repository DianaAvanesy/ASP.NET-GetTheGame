using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETGetTheGame.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NETGetTheGame.Controllers
{
    public class CategoriesController : Controller //inherit MVC Base Controller class
        //Pascal case: Plural word(many) + Controler + .cs
    {
        public IActionResult Index()
        {
            //LINK: localhost:port/categories

            //use the category model to create 10 fake categories and send to the view for display
            //1. create an empty list of the categories
            var categories = new List<Category>();

            //2. use loop to create 10 categories
            for (var i = 1; i <= 10; i++)
            {
                categories.Add(new Category
                {
                    Id = i,
                    Name = "Category " + i.ToString()
                });          
            }

            //pass the list to the view
            return View(categories);
        }

        public IActionResult Browse(string categoryName)
        {
            //take the category name passed in with the link and store in the ViewBag for display
            ViewBag.categoryName = categoryName;

            return View();
        }

        //just a co
        //another test
        public IActionResult AddCategory()
        {
            //display an empty form where user can add new category
            var someString = "test";

            return View();
        }
    }
}
