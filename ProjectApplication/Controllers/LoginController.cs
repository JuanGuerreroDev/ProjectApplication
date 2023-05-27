using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BCrypt.Net;
using ProjectApplication.Data;
using static ProjectApplication.Models.User;

namespace ProjectApplication.Controllers;

public class LoginController : Controller
{
    private readonly ApplicationDbContext _dbContext;
    
    public LoginController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> Index(string email, string password)
    {
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.email == email && u.password == password);
        // user var validate if credentials in form are corrects, if not, user var will be null
        if (user != null)
        {
            return RedirectToAction("Index", "Admin");
        }
        else
        {
            ViewBag.error = "Invalid credentials";
            return RedirectToAction("Index","Home");
        }
    }
}