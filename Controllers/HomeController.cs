using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        public HomeController(MyContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs
            .Include(d => d.CreatedDishes)
            .ToList();

            return View();
        }

        [HttpGet("addChef")]
        public IActionResult AddChef()
        {
            return View();
        }

        [HttpPost("submit")]
        public IActionResult Submit(Chef newChef)
        {
            if(ModelState.IsValid)
            {
            _context.Chefs.Add(newChef);
            _context.SaveChanges();
            return RedirectToAction("Index");
            }
            
            return View("AddChef");
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllDishes = _context.Dishes
            .Include(c => c.Creator )
            .ToList();
            return View();
        }

        [HttpGet("newDish")]
        public IActionResult NewDish()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View();
        }

        [HttpPost("sendingdish")]
        public IActionResult SendDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
            _context.Dishes.Add(newDish);

            _context.SaveChanges();
            return RedirectToAction("Dishes");
            }
            
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View("NewDish");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
