using ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Models;
using Microsoft.AspNetCore.Mvc;

namespace ANK11_TAG_HELPERS_CUSTOM_VALİDATİON.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CarDetails()
        {
            return View(new Car());
        }
        public IActionResult CarDetails(Car car)
        {
            return View(car);
        }
    }
}
