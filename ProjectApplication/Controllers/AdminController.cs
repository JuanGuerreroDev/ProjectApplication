using Microsoft.AspNetCore.Mvc;

namespace ProjectApplication.Controllers.Admin;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}