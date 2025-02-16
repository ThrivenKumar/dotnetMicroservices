using Microsoft.EntityFrameworkCore;

namespace PlatformSerice.Data;

public class AppDbContext: DbContext{
    public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
    {
        
    }
}