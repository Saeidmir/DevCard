using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.Controllers;

public class HomeController : Controller
{
    public HomeController()
    {
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Contact()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Contact(Contact model)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.error = "اطلاعات وارد شده صحیح نیست لطفا دوباره تلاش کنید.";
            return View(model);
        }

        ViewBag.success = "اطلاعات شما با موفقیت ثبت گردید.";
        return View();
    }
}