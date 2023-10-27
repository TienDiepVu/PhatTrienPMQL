using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class EmployeeController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index( Employee em)
        {
            string strEM = em.EmployeeID + " - " + em.FullName + " - " + em.Address + " - " + em.Age;
            ViewBag.Export2 = strEM;
            return View();
        }
    }
}