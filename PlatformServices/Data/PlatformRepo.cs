using PlatformService.Data;
using PlatformService.Models;

namespace PlatformSerice.Data;

public class PlatformRepo : IPlatformRepo
{

    public PlatformRepo(AppDbContext dbContext){

    }
    public void CreatePlatform(Platform plat)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Platform> GetAllPlatforms()
    {
        throw new NotImplementedException();
    }

    public Platform GetPlatformById(int id)
    {
        throw new NotImplementedException();
    }

    public bool SaveChanges()
    {
        throw new NotImplementedException();
    }
}