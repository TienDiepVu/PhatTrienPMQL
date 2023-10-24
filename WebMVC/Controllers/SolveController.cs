using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
namespace WebMVC.Controllers
{
    public class SolveController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index( Solve Solve)
        {
            return View();
        }
    }

    
}