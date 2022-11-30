using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.Controllers;

public class HomeController:Controller
{
    public HomeController(){}
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
    public IActionResult Contact(Contact contact)
    {
        return Json(Ok());
    }
}