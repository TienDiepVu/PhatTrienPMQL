using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class PersonController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index( Person ps)
        {
            string str = ps.PersonID + " - " + ps.FullName;
            ViewBag.Export = str;
            return View();
        }
    }
}