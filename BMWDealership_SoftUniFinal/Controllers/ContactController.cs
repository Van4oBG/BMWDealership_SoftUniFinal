using Microsoft.AspNetCore.Mvc;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string Name, string Email, string Message)
    {
        ViewBag.Confirmation = $"Thanks for your message, {Name}! We'll reply soon.";

        return View();
    }
}
