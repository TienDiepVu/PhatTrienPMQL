using Microsoft.AspNetCore.Mvc;
namespace WebMVC.Controllers;
using WebMVC.Models;
public class GiaiPTController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Solve(GiaiPT Diep)
    {
        if (Diep.A == 0)
        {
            ViewBag.D = "A phai khac 0.";
            return View("Index", Diep);
        }

        Diep.Delta = Diep.B * Diep.B - 4 * Diep.A * Diep.C;
        ViewBag.A = "delta = " + Diep.Delta;
        if (Diep.Delta < 0)
        {
            ViewBag.B = "Phuong trinh vo nghiem.";
        }
        else if (Diep.Delta == 0)
        {
            Diep.X1 = -Diep.B / (2 * Diep.A);
            ViewBag.C = "Phuong trinh co nghiem kep: X1=X2=" + Diep.X1;
        }
        else
        {
            Diep.X1 = (-Diep.B + Math.Sqrt(Diep.Delta)) / (2 * Diep.A);
            Diep.X2 = (-Diep.B - Math.Sqrt(Diep.Delta)) / (2 * Diep.A);
            ViewBag.D = "Phuong trinh co 2 nghiem: " + " X1= " + Diep.X1 + " ; " + "X2 = " + Diep.X2;
        }


        return View("Index", Diep);
    }
}