namespace WebMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
public class TinhLuongController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Sum(TinhLuong tl)
    {

        tl.TongLuong = tl.LuongCoBan * tl.HeSoLuong + tl.PhuCap;
        ViewBag.A="Luong=" +tl.TongLuong;
        return View("Index",tl);

    }
}