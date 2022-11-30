using Microsoft.AspNetCore.Mvc;

namespace DevCard.Controllers;

public class HomeController:Controller
{
    public HomeController(){}
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }
}