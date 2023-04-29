using C_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace C_MVC.Controllers
{
 public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Results(FormViewModel formViewModel)
        {
            if (ModelState.IsValid)
            {
           
                return View(formViewModel);
            }
            else
            {
                return View("Index");
            }
        }
    }
}