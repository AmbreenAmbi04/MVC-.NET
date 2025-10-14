using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            var person = new PersonModel
            {
                FirstName = "Emma",
                LastName = "Green",
                Address = "456 Elm St, New York, Manhattan",
                isPresent = false
            };

            return View(person);
        }
        [HttpPost]
        public IActionResult Index(PersonModel person)
        {
            return View();
        }
    }
}
