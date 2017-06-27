using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        //GET /home/Index
        public ActionResult Index()
        {
            return View();
        }
        //GET /home/About 
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        //GET /home/Contact
        [HttpPost]
        public ActionResult Contact(string message)
        {
            // TODO : send message to HQ
            ViewBag.TheMessage = "Haing trouble? Send us a message.";

            return View();
        }

        //GET /home/Product
        public ActionResult Product()
        {
            return View();
        }
        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC5ATM1";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());
            }
            return Content(serial);
        }
        public ActionResult Calcurate(int value1, int value2, string calci)
        {
            int total = 0;
            switch (calci)
            {
                case "+":
                    total = value1 + value2;
                    break;
                case "-":
                    total = value1 - value2;
                    break;
                case "*":
                    total = value1 * value2;
                    break;
                case "/":
                    total = value1 / value2;
                    break;
                default:
                    break;
            }
            return Content("Result " + total);
        }

        private void NutFunction()
        {
            // I add this function for testing. Nut
            // Nut
        }

        // Test
    }
}