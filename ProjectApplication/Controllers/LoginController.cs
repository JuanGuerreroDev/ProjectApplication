using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BCrypt.Net;
using ProjectApplication.Data;

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
        var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (user == null)
        {
            return RedirectToAction("Index", "Login");
        }
        if (!BCrypt.Net.BCrypt.Verify(password, user.Password))
        {
            return RedirectToAction("Index", "Login");
        }
        return RedirectToAction("Index", "Home");
    }
}