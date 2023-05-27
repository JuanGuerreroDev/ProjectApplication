using Microsoft.AspNetCore.Mvc;

namespace ProjectApplication.Controllers;

public class ServiceTypeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    // GET
    public IActionResult Create()
    {
        return View();
    }
    
    // POST
    [HttpPost]
    public IActionResult Create(string name)
    {
        return View();
    }
    
    // GET
    public IActionResult Edit(int id)
    {
        return View();
    }
    
    // POST
    [HttpPost]
    public IActionResult Edit(int id, string name)
    {
        return View();
    }
}