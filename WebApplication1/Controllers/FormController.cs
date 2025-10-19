using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using DataFormUsingController = Microsoft.AspNetCore.Mvc.Controller;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostUsingParameters(string firstname, string lastname)
        {
            return Content($"First Name: {firstname}, Last Name: {lastname}");
        }
        public IActionResult PostUsingRequest()
        {
            string? firstname = Request.Form["firstname"];
            string? lastname = Request.Form["lastname"];

            return Content($"First Name: {firstname}, Last Name: {lastname}");
        }
        public IActionResult PostUsingFormCollection(IFormCollection form)
        {
            string? firstname = form["firstname"];
            string? lastname = form["lastname"];

            return Content($"First Name: {firstname}, Last Name: {lastname}");
        }
        public IActionResult PostUsingBinding(FormModel form)
        {
            return Content($"First Name: {form.firstname}, Last Name: {form.lastname}");
        }
        }
}
