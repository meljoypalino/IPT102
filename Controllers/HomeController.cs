using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Meljoy Palino", StudentId = "21-2110", StudentAge = "20", ContactNumber = "09451581639" },
            new StudentInfoModel { Name = "SpongeBob Squarepants", StudentId = "20-0001", StudentAge = "22", ContactNumber = "09153367524" },
            new StudentInfoModel { Name = "Patrick Starfish", StudentId = "20-2394", StudentAge = "24", ContactNumber = "09985432752" }
        };

        return View(studentInfoArray);
    }
}
