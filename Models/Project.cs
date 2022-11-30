using System.ComponentModel.DataAnnotations;

namespace DevCard.Models;

public class Project
{
    public long Id { get; set; }   
    public string Name { get; set; }   
    public string Description { get; set; } 
    public string Image { get; set; }
    public string  Client { get; set; }

    public Project(long id, string name, string description, string image, string client)
    {
        Id = id;
        Name = name;
        Description = description;
        Image = image;
        Client = client;
    }
}

public class Article
{
    public long Id { get; set; }
    public string Title { get; set; } 
    public string Description { get; set; }
    public string Image { get; set; }

    /*public Article(long id, string title, string description, string image)
    {
        Id = id;
        Title = title;
        Description = description;
        Image = image;
    }*/
}

public class Contact
{
    [Required(ErrorMessage = "این فیلداجباری است.")]
    [MinLength(3,ErrorMessage = "حداقل 3 کاراکتر")]
    [MaxLength(100,ErrorMessage = "حداکثر 100کاراکتر")]
    public string Name { get; set; }
    [Required(ErrorMessage = "این فیلداجباری است.")]
    [EmailAddress]
    public string Email { get; set; }
    public string Message { get; set; }
    public string Service { get; set; }
}

