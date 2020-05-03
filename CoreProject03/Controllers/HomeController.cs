using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreProject03.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreProject03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var thebookModel = new Book() { Author = "Fáusio", Title = "Mastarpeace" };
            return View(thebookModel);
        }
    }
}