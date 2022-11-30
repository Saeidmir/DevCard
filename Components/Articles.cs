using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.Components;

public class Articles : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var articles = new List<Article>()
        {
           new Article {  Id=  1, Title="آموزش سی شارپ", Image="blog-post-thumb-card-1.jpg", Description=" به صحیح ترن روش برنامه نویسی به زبان سی شارپ را یاد بگیرید." },
            new Article{Id=2, Title="آموزش فریمورک React.js", Image="blog-post-thumb-card-2.jpg", Description = "به سادگی برنامه نویس front-end شوید" },
            new Article{Id=3, Title="آموزش زبان پایتون برای علم داده", Image="blog-post-thumb-card-3.jpg", Description="یادگیری علم داده، دانشمند داده کیست و چه مسئولیتهایی دارد."} ,
            new Article { Id=1, Title= "آموزش سی شارپ", Image= "blog-post-thumb-card-1.jpg", Description=" به صحیح ترن روش برنامه نویسی به زبان سی شارپ را یاد بگیرید." }
        };
        return View(articles);
    }
}