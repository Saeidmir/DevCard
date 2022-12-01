using DevCard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard.Controllers;

public class HomeController : Controller
{

    private readonly List<Service> _servicesList = new List<Service>()
    {
        new Service(id:1,name:"برنزی"),
        new Service(id : 2, name: "نقره ای"),
        new Service(id:3, name:"طلایی") { Id = 3, Name = "طلایی" },
        new Service(id:4,name:"پلاتینیوم") 
    };

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Contact()
    {
        var model = new Contact()
        {
            Services = new SelectList(_servicesList, "Id", "Name")
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult Contact(Contact model)
    {
        model.Services = new SelectList(_servicesList, "Id", "Name");
        if (!ModelState.IsValid)
        {
            var errors = ModelState.Values.SelectMany(v => v.Errors);
            ViewBag.error = "اطلاعات وارد شده صحیح نیست لطفا دوباره تلاش کنید.";
            return View(model);
        }
        
        ModelState.Clear();
        model = new Contact()
        {
            Services = new SelectList(_servicesList, "Id", "Name")
        };
        ViewBag.success = "پیغام شما با موفقیت ثبت گردید.";
        return View(model);
    }
}