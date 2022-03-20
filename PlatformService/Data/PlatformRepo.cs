using PlatformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _appDbContext;

        public PlatformRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void CreatePlatform(Platform platform)
        {
            if (platform == null)
            {
                throw new ArgumentNullException(nameof(platform));
            }
            _appDbContext.platforms.Add(platform);   
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _appDbContext.platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _appDbContext.platforms.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_appDbContext.SaveChanges() >= 0);
        }
    }
}
