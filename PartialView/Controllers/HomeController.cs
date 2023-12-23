using Microsoft.AspNetCore.Mvc;
using PartialView.Models;
using System.Diagnostics;

namespace PartialView.Controllers
{
    public class TestModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    public class HomeController : Controller
    {

        public HomeController()
        {

        }
        public IActionResult Index()
        {

            return View(new TestModel()
            {
                Name = "Sadık",
                Surname = "Turan"


            });
        }

        public IActionResult Privacy()
        {
            //bu şekilde partial view açabiliyoruz.
            return PartialView("_privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}