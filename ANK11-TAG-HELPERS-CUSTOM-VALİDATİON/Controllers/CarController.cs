using ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Controllers
{
    public class CarController : Controller
    {
        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CarDetails()
        {
            return View(new Car());
        }
        [HttpPost]
        public IActionResult CarDetails(Car car)
        {
            return View(car);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
