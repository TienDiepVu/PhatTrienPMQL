using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class UserController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CalculateSalary(Models.User user)
        {
            double salary = user.CalculateSalary();

            ViewBag.Salary = salary;

            return View();
        }
    }
}