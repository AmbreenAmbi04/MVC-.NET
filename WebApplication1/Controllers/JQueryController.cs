using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class JQueryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetData()
        {
            var json = new JsonModel()
            {
                Id = 22,
                Name = "Ambreen Akhtar",
                Age = 24
            };

            return Json(json);
        }
    }
}
