using FizzBuzzProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FizzBuzz()
        {
            var fizzBuzz = new FizzBuzzModel();
            return View(fizzBuzz);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FizzBuzz(FizzBuzzModel fb)
        {
            string message = "";
            for(var i= fb.StartValue;i<= fb.EndValue; i++)
            {
                if (i % 3==0) message += "Fizz";
                if (i % 5 == 0) message += "Buzz";
                if (string.IsNullOrEmpty(message)) message = i.ToString();

                fb.FizzBuzz.Add(message);
                message = "";
            }

            return View(fb);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
