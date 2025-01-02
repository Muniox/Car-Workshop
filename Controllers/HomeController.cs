using CarWorkshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarWorkshop.MVC.Controllers
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

        public IActionResult Privacy()
        {
            var model = new List<Person>()
            {
                new Person() {
                    FirstName = "Jakub",
                    LastName = "Kozera"
                },
                new Person()
                {
                    FirstName = "Adam",
                    LastName = "Ma³ysz"
                }
            };

            return View("Privacy", model);
        }

        public IActionResult About()
        {

            var Message = new Message()
            {
                Title = "CarWorkshop application",
                Descritpion = "To jest opis",
                Tags = ["pierwszyTag", "dreugiTag"]
            };


            return View(Message);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
