using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreApp.Models;
using Test.Models;

namespace AspNetCoreApp.Controllers
{
    public class HomeController : Controller
    {
        RandomPin randomPin = new RandomPin();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Controller1()
        {
            randomPin.PinNo = 1;

            return View(randomPin);
        }

        public IActionResult Controller1Updated(RandomPin randomPinObj)
        {
            randomPinObj.SetPinState();
            return View("Controller1", randomPinObj);
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
