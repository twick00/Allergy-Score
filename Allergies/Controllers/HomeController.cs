using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Allergies.Models;

namespace Allergies.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return View("index");
        }
        [HttpPost("/")]
        public IActionResult PostIndex()
        {
            int userInput = Convert.ToInt32(Request.Form["allergy-score"]);
            Allergy myAllergy = new Allergy();
            List<String> myAllergyList = myAllergy.GetAllergyList(userInput);
            return View("index", myAllergyList);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
