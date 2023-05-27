using Microsoft.EntityFrameworkCore;

namespace ProjectApplication.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public DbSet<Models.User> Users { get; set; }
}