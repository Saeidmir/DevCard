using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.Components;

public class Projects:ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var projects = new List<Project>()
        {
            new Project(1,"تاکسی شهری","درخواست آنلاین تاکسیهای درون شهری", "project-1.jpg","محمد سعید"),
            new Project(1,"فروشگاه آرایش","خرید محصولات آرایشی و بهداشتی", "project-2.jpg","محمد سعید2"),
            new Project(1,"لوازم التحریر","فروش آنلاین لوازم التحریر به قیمت مناسب","project-3.jpg", "محمد سعید3"),
            new Project(1,"فرم ساز هوشمند","فرم های پرسشنامه های تحقیقات بازار","project-4.jpg" ,"محمد سعید4")
        };
        return View(model:projects);
    }
}